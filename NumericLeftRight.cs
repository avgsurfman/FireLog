using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireLog
{
    public partial class NumericLeftRight : UserControl
    {
        public NumericUpDown NumericUpDown
        {
            get
            {
                return this.nudcontrol;
            }
        }

        public NumericLeftRight()
        {
            InitializeComponent();
            this.nudcontrol.Value = 1;
            this.nudcontrol.Controls[0].Visible = false;
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            this.nudcontrol.DownButton();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            this.nudcontrol.UpButton();
        }   

    }
}
