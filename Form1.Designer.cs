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
            StatusText = new System.Windows.Forms.Label();
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
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // TypeListBox
            // 
            TypeListBox.FormattingEnabled = true;
            TypeListBox.ItemHeight = 15;
            TypeListBox.Location = new System.Drawing.Point(13, 241);
            TypeListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            TypeListBox.Name = "TypeListBox";
            TypeListBox.Size = new System.Drawing.Size(94, 154);
            TypeListBox.TabIndex = 0;
            // 
            // StatusText
            // 
            StatusText.AutoSize = true;
            StatusText.Location = new System.Drawing.Point(11, 407);
            StatusText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            StatusText.Name = "StatusText";
            StatusText.Size = new System.Drawing.Size(60, 15);
            StatusText.TabIndex = 1;
            StatusText.Text = "StatusText";
            // 
            // DateListBox
            // 
            DateListBox.FormattingEnabled = true;
            DateListBox.ItemHeight = 15;
            DateListBox.Location = new System.Drawing.Point(109, 241);
            DateListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            DateListBox.Name = "DateListBox";
            DateListBox.Size = new System.Drawing.Size(94, 154);
            DateListBox.TabIndex = 2;
            // 
            // TimeListBox
            // 
            TimeListBox.FormattingEnabled = true;
            TimeListBox.ItemHeight = 15;
            TimeListBox.Location = new System.Drawing.Point(205, 241);
            TimeListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            TimeListBox.Name = "TimeListBox";
            TimeListBox.Size = new System.Drawing.Size(94, 154);
            TimeListBox.TabIndex = 3;
            // 
            // SourceListBox
            // 
            SourceListBox.FormattingEnabled = true;
            SourceListBox.ItemHeight = 15;
            SourceListBox.Location = new System.Drawing.Point(300, 241);
            SourceListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            SourceListBox.Name = "SourceListBox";
            SourceListBox.Size = new System.Drawing.Size(97, 154);
            SourceListBox.TabIndex = 4;
            // 
            // DestListBox
            // 
            DestListBox.FormattingEnabled = true;
            DestListBox.ItemHeight = 15;
            DestListBox.Location = new System.Drawing.Point(400, 241);
            DestListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            DestListBox.Name = "DestListBox";
            DestListBox.Size = new System.Drawing.Size(90, 154);
            DestListBox.TabIndex = 5;
            // 
            // TransportListBox
            // 
            TransportListBox.FormattingEnabled = true;
            TransportListBox.ItemHeight = 15;
            TransportListBox.Location = new System.Drawing.Point(492, 241);
            TransportListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            TransportListBox.Name = "TransportListBox";
            TransportListBox.Size = new System.Drawing.Size(101, 154);
            TransportListBox.TabIndex = 6;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new System.Drawing.Point(400, 18);
            buttonOpenFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new System.Drawing.Size(88, 37);
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
            fullLogBox.ItemHeight = 15;
            fullLogBox.Location = new System.Drawing.Point(13, 68);
            fullLogBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            fullLogBox.Name = "fullLogBox";
            fullLogBox.Size = new System.Drawing.Size(580, 139);
            fullLogBox.TabIndex = 8;
            // 
            // LoadButton
            // 
            LoadButton.Location = new System.Drawing.Point(13, 18);
            LoadButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new System.Drawing.Size(78, 37);
            LoadButton.TabIndex = 9;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // FileLocationTextBox
            // 
            FileLocationTextBox.Location = new System.Drawing.Point(109, 27);
            FileLocationTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            FileLocationTextBox.Name = "FileLocationTextBox";
            FileLocationTextBox.Size = new System.Drawing.Size(271, 23);
            FileLocationTextBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 219);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(31, 15);
            label1.TabIndex = 11;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(106, 219);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(31, 15);
            label2.TabIndex = 12;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(202, 219);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 15);
            label3.TabIndex = 13;
            label3.Text = "Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(297, 219);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(43, 15);
            label4.TabIndex = 14;
            label4.Text = "Source";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(397, 219);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(67, 15);
            label5.TabIndex = 15;
            label5.Text = "Destination";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(489, 219);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(56, 15);
            label6.TabIndex = 16;
            label6.Text = "Transport";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(505, 18);
            button1.Margin = new System.Windows.Forms.Padding(2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(88, 37);
            button1.TabIndex = 17;
            button1.Text = "About";
            button1.UseVisualStyleBackColor = true;
            button1.Click +=  About_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(618, 437);
            Controls.Add(button1);
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
            Controls.Add(StatusText);
            Controls.Add(TypeListBox);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox TypeListBox;
        private System.Windows.Forms.Label StatusText;
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
        private System.Windows.Forms.Button button1;
    }
}

