using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Panel p;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.CheckBox c;
        private TaskUserControl TaskUserControl1;
        List<TaskInformation> taskInformationList = new List<TaskInformation>();

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Panel newTask)
        {
            InitializeComponent();
        }

        private void Daily_Button(object sender, EventArgs e)
        {
            if (dailyUserControl1.Visible == false)
            {
                dailyUserControl1.Visible = true;
                weeklyUserControl1.Visible = false;
                monthlyUserControl1.Visible = false;
            }
        }

        private void Weekly_Button(object sender, EventArgs e)
        {
            if (weeklyUserControl1.Visible == false)
            {
                weeklyUserControl1.Visible = true;
                dailyUserControl1.Visible = false;
                monthlyUserControl1.Visible = false;
            }
        }

        private void Monthly_Button(object sender, EventArgs e)
        {
            if (monthlyUserControl1.Visible == false)
            {
                monthlyUserControl1.Visible = true;
                dailyUserControl1.Visible = false;
                weeklyUserControl1.Visible = false;
            }
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            p = new Panel();
            l = new Label();
            c = new CheckBox();

            this.p.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WhiteBackground;
            this.p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p.Location = new System.Drawing.Point(3, 3);
            this.p.Name = "taskP";
            this.p.Size = new System.Drawing.Size(192, 35);
            this.p.TabIndex = 13;

            this.c.Location = new System.Drawing.Point(170, 15);
            this.c.Size = new System.Drawing.Size(13, 13);

            panel1.Controls.Add(c);
            panel1.Controls.Add(p);

            using (var form = new AddTaskForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    TaskInformation Tinfo = form.GetTInfo();

                    this.taskInformationList.Add(Tinfo);
                }
            }

            TaskUserControl t = new TaskUserControl(taskInformationList[taskInformationList.Count - 1].GetTaskTitle());

            this.l.Text = taskInformationList[taskInformationList.Count - 1].GetTaskTitle();
            this.l.Location = new System.Drawing.Point(3, 9);
            this.l.Image = global::WindowsFormsApp1.Properties.Resources.WhiteBackground;
            this.l.Size = new System.Drawing.Size(180, 35);

            this.p.Controls.Add(l);
        }

        private void Panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

