using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<string> Type = new List<string>();
            List<string> Date = new List<string>();
            List<string> Time = new List<string>();
            List<string> Source = new List<string>();
            List<string> Destination = new List<string>();
            List<string> Transport = new List<string>();
        }

        private void StatusText_Click(object sender, EventArgs e)
        {
            this.StatusText.Text = "Boop!";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            // Show the open file dialog
            DialogResult result = openFileDialog1.ShowDialog();
            // I need the fucking signal somehow
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                this.StatusText.Text = "File selected:" + file;
                this.FileLocationTextBox.Text = file;   
            }
            
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            const Int32 BufferSize = 512; // sector size on Windows
            try { 
                //update to using statement
                FileStream fs = new FileStream(this.FileLocationTextBox.Text, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs, System.Text.Encoding.UTF8); // append utf-8 in the future
                

                this.fullLogBox.Items.Clear();
                String line;
                while ((line = sr.ReadLine()) != null) { 
                    this.fullLogBox.Items.Add(line);
                    line.Split
                }
                sr.Close();

            }
            catch (IOException err)
            {
                this.StatusText.Text = String.Format("Error: {err}", err.Message);
            }
        }
    }
}
