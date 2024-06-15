namespace Task1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            taskButton1 = new Button();
            taskButton2 = new Button();
            taskButton3 = new Button();
            taskButton4 = new Button();
            taskButton5 = new Button();
            taskButton6 = new Button();
            taskButton7 = new Button();
            taskButton8 = new Button();
            directoryTextBox = new TextBox();
            fileNameTextBox = new TextBox();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // taskButton1
            // 
            taskButton1.Location = new Point(14, 12);
            taskButton1.Name = "taskButton1";
            taskButton1.Size = new Size(75, 23);
            taskButton1.TabIndex = 0;
            taskButton1.Text = "Task1";
            taskButton1.UseVisualStyleBackColor = true;
            taskButton1.Click += TaskButton1_Click;
            // 
            // taskButton2
            // 
            taskButton2.Location = new Point(95, 12);
            taskButton2.Name = "taskButton2";
            taskButton2.Size = new Size(75, 23);
            taskButton2.TabIndex = 1;
            taskButton2.Text = "Task2";
            taskButton2.UseVisualStyleBackColor = true;
            taskButton2.Click += TaskButton2_Click;
            // 
            // taskButton3
            // 
            taskButton3.Location = new Point(176, 12);
            taskButton3.Name = "taskButton3";
            taskButton3.Size = new Size(75, 23);
            taskButton3.TabIndex = 2;
            taskButton3.Text = "Task3";
            taskButton3.UseVisualStyleBackColor = true;
            taskButton3.Click += TaskButton3_Click;
            // 
            // taskButton4
            // 
            taskButton4.Location = new Point(257, 12);
            taskButton4.Name = "taskButton4";
            taskButton4.Size = new Size(75, 23);
            taskButton4.TabIndex = 3;
            taskButton4.Text = "Task4";
            taskButton4.UseVisualStyleBackColor = true;
            taskButton4.Click += TaskButton4_Click;
            // 
            // taskButton5
            // 
            taskButton5.Location = new Point(338, 12);
            taskButton5.Name = "taskButton5";
            taskButton5.Size = new Size(75, 23);
            taskButton5.TabIndex = 4;
            taskButton5.Text = "Task5";
            taskButton5.UseVisualStyleBackColor = true;
            taskButton5.Click += TaskButton5_Click;
            // 
            // taskButton6
            // 
            taskButton6.Location = new Point(419, 12);
            taskButton6.Name = "taskButton6";
            taskButton6.Size = new Size(75, 23);
            taskButton6.TabIndex = 5;
            taskButton6.Text = "Task6";
            taskButton6.UseVisualStyleBackColor = true;
            taskButton6.Click += TaskButton6_Click;
            // 
            // taskButton7
            // 
            taskButton7.Location = new Point(500, 12);
            taskButton7.Name = "taskButton7";
            taskButton7.Size = new Size(75, 23);
            taskButton7.TabIndex = 6;
            taskButton7.Text = "Task7";
            taskButton7.UseVisualStyleBackColor = true;
            taskButton7.Click += TaskButton7_Click;
            // 
            // taskButton8
            // 
            taskButton8.Location = new Point(581, 12);
            taskButton8.Name = "taskButton8";
            taskButton8.Size = new Size(75, 23);
            taskButton8.TabIndex = 7;
            taskButton8.Text = "Task8";
            taskButton8.UseVisualStyleBackColor = true;
            taskButton8.Click += TaskButton8_Click;
            // 
            // directoryTextBox
            // 
            directoryTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            directoryTextBox.Location = new Point(14, 41);
            directoryTextBox.Name = "directoryTextBox";
            directoryTextBox.Size = new Size(641, 23);
            directoryTextBox.TabIndex = 8;
            directoryTextBox.Text = "C:\\Users\\kvale\\OneDrive\\Рабочий стол\\rpm";
            // 
            // fileNameTextBox
            // 
            fileNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fileNameTextBox.Location = new Point(14, 70);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.Size = new Size(641, 23);
            fileNameTextBox.TabIndex = 9;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(14, 125);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(641, 417);
            dataGridView.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 554);
            Controls.Add(dataGridView);
            Controls.Add(fileNameTextBox);
            Controls.Add(directoryTextBox);
            Controls.Add(taskButton8);
            Controls.Add(taskButton7);
            Controls.Add(taskButton6);
            Controls.Add(taskButton5);
            Controls.Add(taskButton4);
            Controls.Add(taskButton3);
            Controls.Add(taskButton2);
            Controls.Add(taskButton1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button taskButton1;
        private Button taskButton2;
        private Button taskButton3;
        private Button taskButton4;
        private Button taskButton5;
        private Button taskButton6;
        private Button taskButton7;
        private Button taskButton8;
        private TextBox directoryTextBox;
        private TextBox fileNameTextBox;
        private DataGridView dataGridView;
    }
}
