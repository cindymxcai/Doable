namespace WindowsFormsApp1
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
            this.Daily = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DoableLogo = new System.Windows.Forms.Label();
            this.AddTask = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthlyUserControl1 = new WindowsFormsApp1.MonthlyUserControl();
            this.dailyUserControl1 = new WindowsFormsApp1.DailyUserControl();
            this.weeklyUserControl1 = new WindowsFormsApp1.WeeklyUserControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Daily
            // 
            this.Daily.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.DailyButton1;
            this.Daily.FlatAppearance.BorderSize = 0;
            this.Daily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Daily.Location = new System.Drawing.Point(619, 26);
            this.Daily.Margin = new System.Windows.Forms.Padding(0);
            this.Daily.Name = "Daily";
            this.Daily.Size = new System.Drawing.Size(35, 35);
            this.Daily.TabIndex = 0;
            this.Daily.TabStop = false;
            this.Daily.UseVisualStyleBackColor = true;
            this.Daily.Click += new System.EventHandler(this.Daily_Button);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.MonthlyButton1;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(701, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Monthly_Button);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WeeklyButton;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(660, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 3;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Weekly_Button);
            // 
            // DoableLogo
            // 
            this.DoableLogo.Image = global::WindowsFormsApp1.Properties.Resources.DoableLogo;
            this.DoableLogo.Location = new System.Drawing.Point(333, 37);
            this.DoableLogo.Name = "DoableLogo";
            this.DoableLogo.Size = new System.Drawing.Size(135, 60);
            this.DoableLogo.TabIndex = 6;
            this.DoableLogo.Text = " ";
            // 
            // AddTask
            // 
            this.AddTask.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Addtaskbutton1;
            this.AddTask.FlatAppearance.BorderSize = 0;
            this.AddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTask.Location = new System.Drawing.Point(3, 247);
            this.AddTask.Name = "AddTask";
            this.AddTask.Size = new System.Drawing.Size(50, 50);
            this.AddTask.TabIndex = 11;
            this.AddTask.TabStop = false;
            this.AddTask.UseVisualStyleBackColor = true;
            this.AddTask.Click += new System.EventHandler(this.AddTask_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WhiteBackground;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AddTask);
            this.panel1.Location = new System.Drawing.Point(30, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 302);
            this.panel1.TabIndex = 13;
            // 
            // monthlyUserControl1
            // 
            this.monthlyUserControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.monthlyUserControl1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.MonthlyLayout;
            this.monthlyUserControl1.Location = new System.Drawing.Point(280, 116);
            this.monthlyUserControl1.Margin = new System.Windows.Forms.Padding(0);
            this.monthlyUserControl1.Name = "monthlyUserControl1";
            this.monthlyUserControl1.Size = new System.Drawing.Size(456, 303);
            this.monthlyUserControl1.TabIndex = 10;
            this.monthlyUserControl1.Visible = false;
            // 
            // dailyUserControl1
            // 
            this.dailyUserControl1.Location = new System.Drawing.Point(280, 115);
            this.dailyUserControl1.Name = "dailyUserControl1";
            this.dailyUserControl1.Size = new System.Drawing.Size(456, 303);
            this.dailyUserControl1.TabIndex = 9;
            this.dailyUserControl1.Visible = false;
            // 
            // weeklyUserControl1
            // 
            this.weeklyUserControl1.Location = new System.Drawing.Point(280, 115);
            this.weeklyUserControl1.Name = "weeklyUserControl1";
            this.weeklyUserControl1.Size = new System.Drawing.Size(456, 303);
            this.weeklyUserControl1.TabIndex = 8;
            this.weeklyUserControl1.Visible = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WhiteBackground;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.DoableLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Daily);
            this.Controls.Add(this.monthlyUserControl1);
            this.Controls.Add(this.dailyUserControl1);
            this.Controls.Add(this.weeklyUserControl1);
            this.Name = "Form1";
            this.Text = "Doable";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Daily;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label DoableLogo;
        private WeeklyUserControl weeklyUserControl1;
        private DailyUserControl dailyUserControl1;
        private MonthlyUserControl monthlyUserControl1;
        private System.Windows.Forms.Button AddTask;
        private System.Windows.Forms.Panel panel1;
    }
}

