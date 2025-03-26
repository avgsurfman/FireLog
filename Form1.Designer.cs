namespace Lab2
{
    partial class Form1
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
            TypeListBox = new System.Windows.Forms.ListBox();
            DateListBox = new System.Windows.Forms.ListBox();
            TimeListBox = new System.Windows.Forms.ListBox();
            SourceListBox = new System.Windows.Forms.ListBox();
            DestListBox = new System.Windows.Forms.ListBox();
            TransportListBox = new System.Windows.Forms.ListBox();
            buttonOpenFile = new System.Windows.Forms.Button();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            fullLogBox = new System.Windows.Forms.ListBox();
            LoadButton = new System.Windows.Forms.Button();
            FileLocationTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            StatusText = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TypeListBox
            // 
            TypeListBox.FormattingEnabled = true;
            TypeListBox.Location = new System.Drawing.Point(11, 406);
            TypeListBox.Margin = new System.Windows.Forms.Padding(2);
            TypeListBox.Name = "TypeListBox";
            TypeListBox.Size = new System.Drawing.Size(130, 324);
            TypeListBox.TabIndex = 0;
            // 
            // DateListBox
            // 
            DateListBox.FormattingEnabled = true;
            DateListBox.Location = new System.Drawing.Point(145, 406);
            DateListBox.Margin = new System.Windows.Forms.Padding(2);
            DateListBox.Name = "DateListBox";
            DateListBox.Size = new System.Drawing.Size(156, 324);
            DateListBox.TabIndex = 2;
            // 
            // TimeListBox
            // 
            TimeListBox.FormattingEnabled = true;
            TimeListBox.Location = new System.Drawing.Point(305, 406);
            TimeListBox.Margin = new System.Windows.Forms.Padding(2);
            TimeListBox.Name = "TimeListBox";
            TimeListBox.Size = new System.Drawing.Size(235, 324);
            TimeListBox.TabIndex = 3;
            // 
            // SourceListBox
            // 
            SourceListBox.FormattingEnabled = true;
            SourceListBox.Location = new System.Drawing.Point(544, 406);
            SourceListBox.Margin = new System.Windows.Forms.Padding(2);
            SourceListBox.Name = "SourceListBox";
            SourceListBox.Size = new System.Drawing.Size(237, 324);
            SourceListBox.TabIndex = 4;
            // 
            // DestListBox
            // 
            DestListBox.FormattingEnabled = true;
            DestListBox.Location = new System.Drawing.Point(785, 406);
            DestListBox.Margin = new System.Windows.Forms.Padding(2);
            DestListBox.Name = "DestListBox";
            DestListBox.Size = new System.Drawing.Size(193, 324);
            DestListBox.TabIndex = 5;
            // 
            // TransportListBox
            // 
            TransportListBox.FormattingEnabled = true;
            TransportListBox.Location = new System.Drawing.Point(982, 406);
            TransportListBox.Margin = new System.Windows.Forms.Padding(2);
            TransportListBox.Name = "TransportListBox";
            TransportListBox.Size = new System.Drawing.Size(278, 324);
            TransportListBox.TabIndex = 6;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new System.Drawing.Point(1085, 57);
            buttonOpenFile.Margin = new System.Windows.Forms.Padding(2);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new System.Drawing.Size(175, 57);
            buttonOpenFile.TabIndex = 7;
            buttonOpenFile.Text = "Open File";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // fullLogBox
            // 
            fullLogBox.FormattingEnabled = true;
            fullLogBox.Location = new System.Drawing.Point(11, 127);
            fullLogBox.Margin = new System.Windows.Forms.Padding(2);
            fullLogBox.Name = "fullLogBox";
            fullLogBox.Size = new System.Drawing.Size(1249, 228);
            fullLogBox.TabIndex = 8;
            // 
            // LoadButton
            // 
            LoadButton.Location = new System.Drawing.Point(924, 57);
            LoadButton.Margin = new System.Windows.Forms.Padding(2);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new System.Drawing.Size(157, 57);
            LoadButton.TabIndex = 9;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // FileLocationTextBox
            // 
            FileLocationTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            FileLocationTextBox.Location = new System.Drawing.Point(114, 62);
            FileLocationTextBox.Margin = new System.Windows.Forms.Padding(2);
            FileLocationTextBox.Name = "FileLocationTextBox";
            FileLocationTextBox.Size = new System.Drawing.Size(714, 43);
            FileLocationTextBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 372);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 32);
            label1.TabIndex = 11;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(145, 372);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 32);
            label2.TabIndex = 12;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(305, 372);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 32);
            label3.TabIndex = 13;
            label3.Text = "Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(544, 370);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(87, 32);
            label4.TabIndex = 14;
            label4.Text = "Source";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(785, 372);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(136, 32);
            label5.TabIndex = 15;
            label5.Text = "Destination";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(982, 371);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(113, 32);
            label6.TabIndex = 16;
            label6.Text = "Transport";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, programToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1271, 40);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(279, 44);
            toolStripMenuItem1.Text = "Batch Load...";
            toolStripMenuItem1.Click += BatchImport_Click;
            // 
            // programToolStripMenuItem
            // 
            programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem2 });
            programToolStripMenuItem.Name = "programToolStripMenuItem";
            programToolStripMenuItem.Size = new System.Drawing.Size(124, 36);
            programToolStripMenuItem.Text = "Program";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(227, 44);
            toolStripMenuItem2.Text = "About...";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // StatusText
            // 
            StatusText.AutoSize = true;
            StatusText.Location = new System.Drawing.Point(11, 744);
            StatusText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            StatusText.Name = "StatusText";
            StatusText.Size = new System.Drawing.Size(121, 32);
            StatusText.TabIndex = 19;
            StatusText.Text = "StatusText";
            StatusText.Click += StatusText_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            label7.Location = new System.Drawing.Point(27, 65);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(82, 37);
            label7.TabIndex = 20;
            label7.Text = "Path:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1271, 794);
            Controls.Add(label7);
            Controls.Add(StatusText);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FileLocationTextBox);
            Controls.Add(LoadButton);
            Controls.Add(fullLogBox);
            Controls.Add(buttonOpenFile);
            Controls.Add(TransportListBox);
            Controls.Add(DestListBox);
            Controls.Add(SourceListBox);
            Controls.Add(TimeListBox);
            Controls.Add(DateListBox);
            Controls.Add(TypeListBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox TypeListBox;
        private System.Windows.Forms.ListBox DateListBox;
        private System.Windows.Forms.ListBox TimeListBox;
        private System.Windows.Forms.ListBox SourceListBox;
        private System.Windows.Forms.ListBox DestListBox;
        private System.Windows.Forms.ListBox TransportListBox;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox fullLogBox;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox FileLocationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.Label label7;
    }
}

