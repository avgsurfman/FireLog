namespace Lab2_WHDIBW
{
    partial class AboutForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelInfo = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new System.Drawing.Point(66, 16);
            labelInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new System.Drawing.Size(53, 15);
            labelInfo.TabIndex = 0;
            labelInfo.Text = "labelInfo";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(471, 169);
            Controls.Add(labelInfo);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "AboutForm";
            Text = "About";
            Load += AboutForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
    }
}