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
            labelInfo.Text = "Firewall logging util for the \"Introduction to Data Warehouses\"\n" +
                             "course at the University of Zielona Góra\n\n" +
                             "Authors:\n" +
                             "- Karol Mądraszek\n" +
                             "- Franciszek Moszczuk\n\n" +
                             "2025";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
