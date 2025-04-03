using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Lab2;
using System.Globalization;
using System.Text.RegularExpressions;

namespace FireLog
{

    public partial class BackgroundWorkerForm : Form
    {
        public BindingList<string> ListWrapper;
        public BindingList<string> TypeWrapper, DateWrapper, TimeWrapper, SourceWrapper, DestWrapper, TransportWrapper;
        private BackgroundWorker bw;
        private string folderPath;
        private Form1 parentForm;
        int lineCounter = 0;
        int correctLinecounter = 0;
        SqlConnection connection;

        public BackgroundWorkerForm(string folderPath, Form1 parent)
        {
            InitializeComponent();  
            this.folderPath = folderPath;
            this.parentForm = parent;
            this.Load += BackgroundWorkerForm_load;
        }

        public void BackgroundWorkerForm_load(object sender, EventArgs e) {
            InitializeBindingList();
            InitializeBackgroundWorker();
        }


        // Set up the BackgroundWorker object by 
        // attaching event handlers. 
        private void InitializeBackgroundWorker()
        {
            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }


        private void InitializeBindingList() 
        {
            ListWrapper = new BindingList<string>(parentForm.Logbox); 
            TypeWrapper = new BindingList<string>(parentForm.Type);
            DateWrapper = new BindingList<string>(parentForm.Date);
            TimeWrapper = new BindingList<string>(parentForm.Time);
            SourceWrapper = new BindingList<string>(parentForm.Source);
            DestWrapper = new BindingList<string>(parentForm.Destination);
            TransportWrapper = new BindingList<string>(parentForm.Transport);

            
            ListWrapper.RaiseListChangedEvents = true;
            DateWrapper.RaiseListChangedEvents = true;
            TimeWrapper.RaiseListChangedEvents = true;
            SourceWrapper.RaiseListChangedEvents = true;
            DestWrapper.RaiseListChangedEvents = true;
            TransportWrapper.RaiseListChangedEvents = true;
            ListWrapper.RaiseListChangedEvents = true;

            // Don't allow parts to be edited.
            ListWrapper.AllowEdit = false;
            //ListWrapper.Add("Does this work?");
            
        }

        private void Start_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            Start.Enabled = false;
            bw.RunWorkerAsync();
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (bw.IsBusy) bw.CancelAsync();
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("The operation failed");
                return;
            }
            else { 
                labelSneed.Text = string.Format("Read {0} lines, {1} of which are correct.", lineCounter, correctLinecounter);
                // reset bindings

            }
            //for (int i = 0; i < lineList.Count; i++)
            //{
            //    DirectoryLines.Items.Add(lineList[i]);
            //}
            //parentForm.ProcessLines(ref lineList);
        }

        void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int proc = e.ProgressPercentage;
            progressBar1.Value = proc;

        }

        // this runs on a separate Thread
        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.Write("doing work again...");
            OpenConnection();
            deleteFromDatabase();
            string[] files = Directory.GetFiles(folderPath, "*.txt");
            if (files.Length == 0) // hey copilot, can i just do if !files instead
                // no, you should check if the length is 0
                // why though? that's the cpp way
                // because this is c#
                // thanks

            {
                MessageBox.Show("There are no files in the specified directory", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int i = 0; i < files.Length; i++)
            {
                if (bw.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    ProcessLines(files[i]);
                    bw.ReportProgress((i + 1) * 100 / files.Length);
                }

            }
        }

        public void ProcessLines(string filename)
        {
            try
            {
                const int BufferSize = 512; // sector size on Windows
                const string Ignore = "type,date,time"; // TODO: IMPLEMENT A PROPER CSV PARSER

                using FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                using StreamReader sr = new StreamReader(fs, System.Text.Encoding.UTF8, true, BufferSize);
                string line;
                DirectoryLines.BeginInvoke(new UIUpdateDelegate(UIDelegateMethod), this.DirectoryLines, filename);

                while ((line = sr.ReadLine()) != null)
                {
                    lineCounter++;

                    ListWrapper.Add(line);
                    string[] values = line.Split(',');

                    if (values.Length != 6) continue; // Skip invalid lines
                    if (!line.Contains(Ignore))
                    {
                        correctLinecounter++;

                        
                        string type = values[0].Trim();
                        string dateString = values[1].Trim();
                        string timeString = values[2].Trim();
                        string source = values[3].Trim();
                        string destination = values[4].Trim();
                        string protocol = values[5].Trim();

                        string timeStringTrim = Regex.Match(timeString, @"^\d{2}:\d{2}:\d{2}").Value; // Pobiera tylko `HH:mm:ss`

                        string dateTimeStr = $"{dateString} {timeStringTrim}";

                        string[] formats = { "yyyy-MM-dd HH:mm:ss", "yyyy/MM/dd HH:mm:ss" };

                        if (DateTime.TryParseExact(dateTimeStr, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateTime))
                        {
                            string formattedDateTime = dateTime.ToString("yyyy-MM-dd HH:mm:ss");

                            this.TypeWrapper.Add(type);
                            this.DateWrapper.Add(dateString);
                            this.TimeWrapper.Add(timeString);
                            this.SourceWrapper.Add(source);
                            this.DestWrapper.Add(destination);
                            this.TransportWrapper.Add(protocol);

                            saveToDatabase(type, formattedDateTime, source, destination, protocol);
                        }
                        else
                        {
                            Debug.WriteLine($"Invalid date format: {dateTimeStr}");
                        }
                    }
                }
            }
            catch (IOException err)
            {
                this.labelSneed.Text = $"Error: {err.Message}";
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }



        private void ReadFileLines(string filename)
        {
            try {
                Debug.WriteLine($"Appending {filename}...");
                var lines = File.ReadAllLines(filename);

                //lineList.AddRange(lines);
                // update the interface, too
                //ListWrapper.ResetBindings();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"File reading error {filename}:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /* Delegate method responsible for handing UI asynchronously. */
        public delegate void UIUpdateDelegate(ListBox lb, string filename);

        public void UIDelegateMethod(ListBox lb, string filename)
        {
            lb.Items.Add($"Reading {filename}");

        }

        private void saveToDatabase(string type, string dateTime, string source, string destination, string protocol)
        {
            string commandText = "INSERT INTO ZoneAlarmLog (Zdarzenie, DataCzas, Source, Destination, Transport) " +
                                 "VALUES (@type, @dateTime, @source, @destination, @protocol);";

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();  
                }

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand command = new SqlCommand(commandText, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@type", type);
                            command.Parameters.AddWithValue("@dateTime", dateTime);  // Nie formatujemy, SQL Server obsłuży string
                            command.Parameters.AddWithValue("@source", source);
                            command.Parameters.AddWithValue("@destination", destination);
                            command.Parameters.AddWithValue("@protocol", protocol);

                            command.ExecuteNonQuery();
                        }

                        transaction.Commit(); 
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); 
                        MessageBox.Show($"Saving to database error: \n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection error: \n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close(); 
                }
            }*/
        }

        private void deleteFromDatabase()
        {
            string commandText = "DELETE FROM ZoneAlarmLog;";

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open(); 
                }

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand command = new SqlCommand(commandText, connection, transaction))
                        {
                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();  
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Deleting from database error: \n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection error: \n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close(); 
                }
            }
        }



        void OpenConnection()
        {
            String connectionString = "Data Source=(local);Initial Catalog=HurtowniaLab;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
    }

}
