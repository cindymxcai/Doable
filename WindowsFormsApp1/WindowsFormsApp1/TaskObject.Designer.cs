﻿namespace WindowsFormsApp1
{
    partial class TaskObject
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TaskObjectBackground = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TaskObjectBackground
            // 
            this.TaskObjectBackground.Image = global::WindowsFormsApp1.Properties.Resources.LightGray;
            this.TaskObjectBackground.Location = new System.Drawing.Point(-3, 0);
            this.TaskObjectBackground.Name = "TaskObjectBackground";
            this.TaskObjectBackground.Size = new System.Drawing.Size(153, 43);
            this.TaskObjectBackground.TabIndex = 0;
            // 
            // TaskObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TaskObjectBackground);
            this.Name = "TaskObject";
            this.Size = new System.Drawing.Size(126, 34);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TaskObjectBackground;
    }
}
