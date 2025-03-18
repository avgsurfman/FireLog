using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using Lab2_WHDIBW;

namespace Lab2
{
    public partial class Form1 : Form
    {
        List<string> Type, Date, Time, Source, Destination, Transport;
        private string directoryPath;
        private int lineCounter;

        public Form1()
        {
            InitializeComponent();
            this.Type = new List<string>();
            this.Date = new List<string>();
            this.Time = new List<string>();
            this.Source = new List<string>();
            this.Destination = new List<string>();
            this.Transport = new List<string>();

            this.StatusText.Text = "Welcome.";

        }

        // clear items

        public void ListClearItems()
        {
            Console.WriteLine("Clearing items...");
            this.fullLogBox.Items.Clear();
            this.Type.Clear();
            this.Date.Clear();
            this.Time.Clear();
            this.Source.Clear();
            this.Destination.Clear();
            this.Transport.Clear();

            TypeListBox.DataSource = null;
            DateListBox.DataSource = null;
            TimeListBox.DataSource = null;
            SourceListBox.DataSource = null;
            DestListBox.DataSource = null;
            TransportListBox.DataSource = null;


            // it would be better to use a collection for the above items
            // but this implementations is straightforward

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            // Show the open file dialog
            DialogResult result = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Title = "Select a log file...";
            openFileDialog1.InitialDirectory = @"C:\";
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                this.StatusText.Text = "File selected:" + file; // Stringformat fails here - why?
                this.FileLocationTextBox.Text = file;
            }

        }

        void SearchFiles()
        {
            string searchPattern = "*.txt";
            string[] files = Directory.GetFiles(directoryPath, searchPattern);
            foreach (string file in files)
            {
                this.FileLocationTextBox.Text = file;
                ReadFile();
            }
            this.FileLocationTextBox.Text = directoryPath;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            ListClearItems();
            SearchFiles();
        }


        private void About_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void StatusText_Click(object sender, EventArgs e)
        {

            if (this.StatusText.Text == "Welcome." || this.StatusText.Text == "Boop!") this.StatusText.Text = "Boop!";
            else if (this.StatusText.Text != "Copied to clipboard.")
            {
                // copy to clipboard
                Clipboard.SetText(this.StatusText.Text);
                this.StatusText.Text = "Copied to clipboard.";
            }
        }

        private void BatchImport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                directoryPath = fbd.SelectedPath;
                this.StatusText.Text = "Directory selected: " + directoryPath;
                this.FileLocationTextBox.Text = directoryPath;
            }
        }


        void ReadFile()
        {
            try
            {
                const Int32 BufferSize = 512; // sector size on Windows
                const string Ignore = "type,date,time"; //TODO: IMPLEMENT A PROPER CSV PARSER
                using FileStream fs = new FileStream(this.FileLocationTextBox.Text, FileMode.Open, FileAccess.Read);
                using StreamReader sr = new StreamReader(fs, System.Text.Encoding.UTF8);//,true, BufferSize); //convert encodings later
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lineCounter++;
                    this.fullLogBox.Items.Add(line);
                    Array values = line.Split(',');
                    if (values.Length != 6) continue; // might want to implement a csv parser at some point
                    if (!line.Contains(Ignore))
                    {
                        // this.StatusText.Text = "Trying to append" + values.ToString();
                        // TODO : unpack this in a pythonic way
                        this.Type.Add(values.GetValue(0).ToString());
                        this.Date.Add(values.GetValue(1).ToString());
                        this.Time.Add(values.GetValue(2).ToString());
                        this.Source.Add(values.GetValue(3).ToString());
                        this.Destination.Add(values.GetValue(4).ToString());
                        this.Transport.Add(values.GetValue(5).ToString());
                    }
                }

                this.StatusText.Text = $"Loaded {lineCounter} lines of data from the files.";
                //rebind listboxes
                TypeListBox.DataSource = this.Type;
                DateListBox.DataSource = this.Date;
                TimeListBox.DataSource = this.Time;
                SourceListBox.DataSource = this.Source;
                DestListBox.DataSource = this.Destination;
                TransportListBox.DataSource = this.Transport;

                sr.Close();
                fs.Close();





            }
            catch (IOException err)
            {
                this.StatusText.Text = string.Format("Error: {err}", err.Message);
            }

            catch (ArgumentException err)
            {

                // show messagebox
                if (err.Message == "The value cannot be an empty string. (Parameter 'path')")
                {
                    string msg = "Valid path cannot be empty, please select a file first.";
                    string caption = "Invalid Path";
                    MessageBox.Show(msg, caption,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //https://stackoverflow.com/questions/2109441/how-to-show-a-custom-error-or-warning-message-box-in-net-winforms
                }
                else
                {
                    this.StatusText.Text = "Error: " + err.Message;
                }
            }
        }
    }
}
