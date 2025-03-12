using System;
using System.Windows.Forms;

namespace Lab2_WHDIBW
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            labelInfo.Text = @"Firewall logging utility created for 
the ""Introduction to Data Warehouses"" course at the
University of Zielona Góra. 
© 2025 Karol Mądraszek, Franciszek Moszczuk";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
