namespace FireLog
{
    partial class BackgroundWorkerForm
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
            Start = new System.Windows.Forms.Button();
            Cancel = new System.Windows.Forms.Button();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            DirectoryLines = new System.Windows.Forms.ListBox();
            labelSneed = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // Start
            // 
            Start.Location = new System.Drawing.Point(22, 39);
            Start.Margin = new System.Windows.Forms.Padding(6);
            Start.Name = "Start";
            Start.Size = new System.Drawing.Size(262, 115);
            Start.TabIndex = 0;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new System.Drawing.Point(656, 39);
            Cancel.Margin = new System.Windows.Forms.Padding(6);
            Cancel.Name = "Cancel";
            Cancel.Size = new System.Drawing.Size(296, 115);
            Cancel.TabIndex = 1;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(26, 190);
            progressBar1.Margin = new System.Windows.Forms.Padding(6);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(926, 53);
            progressBar1.TabIndex = 2;
            // 
            // DirectoryLines
            // 
            DirectoryLines.FormattingEnabled = true;
            DirectoryLines.Location = new System.Drawing.Point(22, 282);
            DirectoryLines.Margin = new System.Windows.Forms.Padding(6);
            DirectoryLines.Name = "DirectoryLines";
            DirectoryLines.Size = new System.Drawing.Size(930, 484);
            DirectoryLines.TabIndex = 3;
            // 
            // labelSneed
            // 
            labelSneed.AutoSize = true;
            labelSneed.Location = new System.Drawing.Point(32, 797);
            labelSneed.Name = "labelSneed";
            labelSneed.Size = new System.Drawing.Size(329, 32);
            labelSneed.TabIndex = 4;
            labelSneed.Text = "Press the start Button to start.";
            // 
            // BackgroundWorkerForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(982, 860);
            Controls.Add(labelSneed);
            Controls.Add(DirectoryLines);
            Controls.Add(progressBar1);
            Controls.Add(Cancel);
            Controls.Add(Start);
            Margin = new System.Windows.Forms.Padding(6);
            Name = "BackgroundWorkerForm";
            Text = "BackgroundWorkerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox DirectoryLines;
        private System.Windows.Forms.Label labelSneed;
    }
}