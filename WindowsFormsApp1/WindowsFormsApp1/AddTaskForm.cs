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
    public partial class AddTaskForm : Form
    {
        private TaskInformation TInfo = new TaskInformation();

        public AddTaskForm()
        {
            InitializeComponent();
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            Int32.TryParse(priorityComboBox.Text, out int comboBoxInt);

            TInfo.SetTaskTitle(TaskTitleBox.Text);
            TInfo.SetDescription(TaskDescriptionBox.Text);
            TInfo.SetPriority(comboBoxInt);

            this.DialogResult = DialogResult.OK;
            Close();
        }

        public TaskInformation GetTInfo()
        {
            return this.TInfo;
        }
    }
}
