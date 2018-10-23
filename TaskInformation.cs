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
        private int xLocation = 0;
        private int yLocation = 0;
        private bool selected = false;
        private int number;

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

        public TaskInformation(String taskTitle, String description, int priority, String dueDate, int xLocation)
        {
            this.taskTitle = taskTitle;
            this.description = description;
            this.priority = priority;
            this.dueDate = dueDate;
            this.xLocation = xLocation;
        }

        public TaskInformation(String taskTitle, String description, int priority, String dueDate, int yLocation, int xLocation)
        {
            this.taskTitle = taskTitle;
            this.description = description;
            this.priority = priority;
            this.dueDate = dueDate;
            this.yLocation = yLocation;
            this.xLocation = xLocation;
        }

        public TaskInformation(String taskTitle, String description, int priority, String dueDate, int yLocation, int xLocation, int n)
        {
            this.taskTitle = taskTitle;
            this.description = description;
            this.priority = priority;
            this.dueDate = dueDate;
            this.yLocation = yLocation;
            this.xLocation = xLocation;
            this.number = n;
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

        public int getXLocation()
        {
            return this.xLocation;
        }

        public void setXLocation(int x)
        {
            this.xLocation = x;
        }

        public int getYLocation()
        {
            return this.yLocation;
        }

        public void setYLocation(int y)
        {
            this.yLocation = y;
        }

        public bool getSelected()
        {
            return selected;
        }

        public void setSelected(bool sel)
        {
            this.selected = sel;
        }

        public int getNumber()
        {
            return number;
        }

        public void setNumber(int n)
        {
            this.number = n;
        }
    }
}
