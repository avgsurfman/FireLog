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
            SuspendLayout();
            // 
            // Start
            // 
            Start.Location = new System.Drawing.Point(12, 12);
            Start.Name = "Start";
            Start.Size = new System.Drawing.Size(124, 54);
            Start.TabIndex = 0;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new System.Drawing.Point(156, 12);
            Cancel.Name = "Cancel";
            Cancel.Size = new System.Drawing.Size(124, 54);
            Cancel.TabIndex = 1;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(14, 89);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(699, 25);
            progressBar1.TabIndex = 2;
            // 
            // DirectoryLines
            // 
            DirectoryLines.FormattingEnabled = true;
            DirectoryLines.ItemHeight = 15;
            DirectoryLines.Location = new System.Drawing.Point(12, 132);
            DirectoryLines.Name = "DirectoryLines";
            DirectoryLines.Size = new System.Drawing.Size(701, 259);
            DirectoryLines.TabIndex = 3;
            // 
            // BackgroundWorkerForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(729, 403);
            Controls.Add(DirectoryLines);
            Controls.Add(progressBar1);
            Controls.Add(Cancel);
            Controls.Add(Start);
            Name = "BackgroundWorkerForm";
            Text = "BackgroundWorkerForm";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox DirectoryLines;
    }
}