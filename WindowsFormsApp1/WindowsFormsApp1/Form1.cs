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
        private System.Windows.Forms.Panel[] taskP;
        private List<Panel> list;
        private System.Windows.Forms.Label[] taskL;
        private System.Windows.Forms.CheckBox[] taskC;
        List<TaskInformation> taskInformationList = new List<TaskInformation>();
        List<int> selectedTasks = new List<int>();
        private bool boxCheckedRecent = false;
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
            taskP = new Panel[6];
            taskL = new Label[6];
            taskC = new CheckBox[6];
            list = new List<Panel>();

            using (var form = new AddTaskForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    TaskInformation Tinfo = form.GetTInfo();

                    this.taskInformationList.Add(Tinfo);
                }
            }

            this.taskP[taskInformationList.Count - 1] = new Panel();


            this.taskP[taskInformationList.Count - 1].BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WhiteBackground;
            this.taskP[taskInformationList.Count - 1].BorderStyle = BorderStyle.FixedSingle;

            if((taskInformationList.Count - 2)  == (-1))
                {
                    this.taskP[taskInformationList.Count - 1].Location = new System.Drawing.Point(3, 3);
                taskInformationList[taskInformationList.Count - 1].setXLocation(3);
                taskInformationList[taskInformationList.Count - 1].setYLocation(3);
            }
            else
            {
                this.taskP[taskInformationList.Count - 1].Location = new System.Drawing.Point(3, taskInformationList[taskInformationList.Count - 2].getYLocation() + 38);
                taskInformationList[taskInformationList.Count - 1].setXLocation(taskInformationList[taskInformationList.Count - 2].getYLocation() + 3);
                taskInformationList[taskInformationList.Count - 1].setYLocation(taskInformationList[taskInformationList.Count - 2].getYLocation() + 38);
            }
            this.taskP[taskInformationList.Count - 1].Name = "taskP ";
            this.taskP[taskInformationList.Count - 1].Size = new Size(192, 35);
            this.taskP[taskInformationList.Count - 1].TabIndex = 13;
            this.taskP[taskInformationList.Count - 1].BringToFront();

            list.Add(taskP[taskInformationList.Count - 1]);

            panel1.Controls.Add(taskP[taskInformationList.Count - 1]);

            this.taskC[taskInformationList.Count - 1] = new CheckBox();
            this.taskC[taskInformationList.Count - 1].Location = new System.Drawing.Point(170, 10);
            this.taskC[taskInformationList.Count - 1].Size = new System.Drawing.Size(13, 13);
            this.taskC[taskInformationList.Count - 1].Name = "" + (taskInformationList.Count - 1);
            this.taskInformationList[taskInformationList.Count - 1].setNumber(taskInformationList.Count - 1);
            Int32.TryParse(this.taskC[taskInformationList.Count - 1].Name, out int comboBoxInt);
            this.taskC[taskInformationList.Count - 1].CheckedChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);

            this.taskP[taskInformationList.Count - 1].Controls.Add(taskC[taskInformationList.Count - 1]);

            this.taskL[taskInformationList.Count - 1] = new Label();
            this.taskL[taskInformationList.Count - 1].Text = taskInformationList[taskInformationList.Count - 1].GetTaskTitle();
            this.taskL[taskInformationList.Count - 1].Location = new System.Drawing.Point(3, 9);
            this.taskL[taskInformationList.Count - 1].Image = global::WindowsFormsApp1.Properties.Resources.WhiteBackground;
            this.taskL[taskInformationList.Count - 1].Size = new System.Drawing.Size(180, 35);
            

            this.taskP[taskInformationList.Count - 1].Controls.Add(taskL[taskInformationList.Count - 1]);
        }

        private void Panel1_DragEnter(object sender, DragEventArgs e, int i)
        {
            e.Effect = DragDropEffects.All;
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.boxCheckedRecent = true;

            /*for (int i = 0; i < taskInformationList.Count(); i++)
            {
                if (taskInformationList[selectedTasks[]].getSelected())
                {
                    taskInformationList[selectedTasks[]].setSelected(false);
                }
                else
                {
                    taskInformationList[selectedTasks[]].setSelected(true);
                }
            }*/
        }

        private void changeCheckedValue(int noBoxChecked)
        {
            if (taskInformationList[noBoxChecked].getSelected())
            {
                taskInformationList[noBoxChecked].setSelected(false);
            }
            else
            {
                taskInformationList[noBoxChecked].setSelected(true);
            }
        }
    }
}

