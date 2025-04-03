namespace FireLog
{
    partial class NumericLeftRight
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nudcontrol = new System.Windows.Forms.NumericUpDown();
            buttonRight = new System.Windows.Forms.Button();
            buttonLeft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)nudcontrol).BeginInit();
            SuspendLayout();
            // 
            // nudcontrol
            // 
            nudcontrol.Location = new System.Drawing.Point(69, 80);
            nudcontrol.Name = "nudcontrol";
            nudcontrol.Size = new System.Drawing.Size(122, 39);
            nudcontrol.TabIndex = 0;
            // 
            // buttonRight
            // 
            buttonRight.Location = new System.Drawing.Point(160, 80);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new System.Drawing.Size(41, 39);
            buttonRight.TabIndex = 1;
            buttonRight.Text = ">";
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonRight_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.Location = new System.Drawing.Point(28, 80);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new System.Drawing.Size(41, 39);
            buttonLeft.TabIndex = 2;
            buttonLeft.Text = "<";
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // NumericLeftRight
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(buttonLeft);
            Controls.Add(buttonRight);
            Controls.Add(nudcontrol);
            Name = "NumericLeftRight";
            Size = new System.Drawing.Size(254, 178);
            ((System.ComponentModel.ISupportInitialize)nudcontrol).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudcontrol;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
    }
}
