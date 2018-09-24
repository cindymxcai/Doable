using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class TaskInformation
    {
        private String taskTitle;
        private String description;
        private int priority;
        private String dueDate;

        public TaskInformation()
        {
            this.taskTitle = "";
            this.description = "";
            this.priority = 0;
        }

        public TaskInformation(String taskTitle)
        {
            this.taskTitle = taskTitle;
            this.description = "";
            this.priority = 0;
        }

        public TaskInformation(String taskTitle, String description)
        {
            this.taskTitle = taskTitle;
            this.description = description;
            this.priority = 0;
        }

        public TaskInformation(String taskTitle, String description, int priority)
        {
            this.taskTitle = taskTitle;
            this.description = description;
            this.priority = priority;
        }

        public TaskInformation(String taskTitle, String description, int priority, String dueDate)
        {
            this.taskTitle = taskTitle;
            this.description = description;
            this.priority = priority;
            this.dueDate = dueDate;
        }

        public String GetTaskTitle()
        {
            return taskTitle;
        }

        public void SetTaskTitle(String s)
        {
            this.taskTitle = s;
        }

        public String GetDescription()
        {
            return description;
        }

        public void SetDescription(String s)
        {
            this.description = s;
        }

        public int GetPriority()
        {
            return priority;
        }

        public void SetPriority(int p)
        {
            this.priority = p;
        }

        public String getDueDate()
        {
            return dueDate;
        }

        public void setDueDate(String d)
        {
            this.dueDate = d;
        }
    }
}
