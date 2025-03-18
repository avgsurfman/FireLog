using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab2;

namespace FireLog
{

    public partial class BackgroundWorkerForm : Form
    {
        private BackgroundWorker bw;
        private List<string> lineList = new List<string>();
        private string folderPath;
        private Form1 parentForm;

        public BackgroundWorkerForm(string folderPath, Form1 parent)
        {
            InitializeComponent();
            this.folderPath = folderPath;
            this.parentForm = parent;
            lineList = new List<string>();
            bw = new BackgroundWorker();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            bw.RunWorkerAsync();
            Start.Enabled = false;
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
            for (int i = 0; i < lineList.Count; i++)
            {
                DirectoryLines.Items.Add(lineList[i]);
            }
        }

        void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int proc = e.ProgressPercentage;
            progressBar1.Value = proc;
        }
        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] files = Directory.GetFiles(folderPath, "*.txt");
            if (files.Length == 0)
            {
                MessageBox.Show("There is no files in directory", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int i = 0; i < files.Length; i++)
            {
                if (bw.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                ReadFileLines(files[i]);
                bw.ReportProgress((i + 1) * 100 / files.Length);
            }
        }

        private void ReadFileLines(string name)
        {
            try
            {
                using (StreamReader sr = new StreamReader(name))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lineList.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"File reading error {name}:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
