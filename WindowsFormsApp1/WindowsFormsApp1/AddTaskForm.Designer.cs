namespace WindowsFormsApp1
{
    partial class AddTaskForm
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
            this.TaskTitle = new System.Windows.Forms.Label();
            this.TaskTitleBox = new System.Windows.Forms.TextBox();
            this.Details = new System.Windows.Forms.Label();
            this.TaskDescriptionBox = new System.Windows.Forms.TextBox();
            this.Priority = new System.Windows.Forms.Label();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.AddTask = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TaskTitle
            // 
            this.TaskTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TaskTitle.Location = new System.Drawing.Point(175, 35);
            this.TaskTitle.Name = "TaskTitle";
            this.TaskTitle.Size = new System.Drawing.Size(50, 20);
            this.TaskTitle.TabIndex = 0;
            this.TaskTitle.Text = "Task";
            // 
            // TaskTitleBox
            // 
            this.TaskTitleBox.Location = new System.Drawing.Point(90, 58);
            this.TaskTitleBox.Multiline = true;
            this.TaskTitleBox.Name = "TaskTitleBox";
            this.TaskTitleBox.Size = new System.Drawing.Size(200, 40);
            this.TaskTitleBox.TabIndex = 1;
            // 
            // Details
            // 
            this.Details.AutoSize = true;
            this.Details.Location = new System.Drawing.Point(175, 118);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(39, 13);
            this.Details.TabIndex = 2;
            this.Details.Text = "Details";
            // 
            // TaskDescriptionBox
            // 
            this.TaskDescriptionBox.Location = new System.Drawing.Point(90, 134);
            this.TaskDescriptionBox.Multiline = true;
            this.TaskDescriptionBox.Name = "TaskDescriptionBox";
            this.TaskDescriptionBox.Size = new System.Drawing.Size(200, 40);
            this.TaskDescriptionBox.TabIndex = 3;
            // 
            // Priority
            // 
            this.Priority.AutoSize = true;
            this.Priority.Location = new System.Drawing.Point(175, 190);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(38, 13);
            this.Priority.TabIndex = 4;
            this.Priority.Text = "Priority";
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.priorityComboBox.Location = new System.Drawing.Point(133, 206);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(121, 21);
            this.priorityComboBox.TabIndex = 5;
            // 
            // AddTask
            // 
            this.AddTask.Location = new System.Drawing.Point(297, 326);
            this.AddTask.Name = "AddTask";
            this.AddTask.Size = new System.Drawing.Size(75, 23);
            this.AddTask.TabIndex = 6;
            this.AddTask.Text = "Add Task";
            this.AddTask.UseVisualStyleBackColor = true;
            this.AddTask.Click += new System.EventHandler(this.AddTask_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 271);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Due date dd/mm/yyyy";
            // 
            // AddTaskForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.AddTask);
            this.Controls.Add(this.priorityComboBox);
            this.Controls.Add(this.Priority);
            this.Controls.Add(this.TaskDescriptionBox);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.TaskTitleBox);
            this.Controls.Add(this.TaskTitle);
            this.Name = "AddTaskForm";
            this.Text = "Add Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskTitle;
        private System.Windows.Forms.TextBox TaskTitleBox;
        private System.Windows.Forms.Label Details;
        private System.Windows.Forms.TextBox TaskDescriptionBox;
        private System.Windows.Forms.Label Priority;
        private System.Windows.Forms.ComboBox priorityComboBox;
        private System.Windows.Forms.Button AddTask;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}