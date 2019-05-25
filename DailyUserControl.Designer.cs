namespace WindowsFormsApp1
{
    partial class DailyUserControl
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
            this.DailyViewBackGround = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DailyViewBackGround
            // 
            this.DailyViewBackGround.Image = global::WindowsFormsApp1.Properties.Resources.DailyLayout;
            this.DailyViewBackGround.Location = new System.Drawing.Point(0, 0);
            this.DailyViewBackGround.Name = "DailyViewBackGround";
            this.DailyViewBackGround.Size = new System.Drawing.Size(456, 303);
            this.DailyViewBackGround.TabIndex = 0;
            this.DailyViewBackGround.Click += new System.EventHandler(this.DailyViewBackGround_Click);
            // 
            // DailyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DailyViewBackGround);
            this.Name = "DailyUserControl";
            this.Size = new System.Drawing.Size(456, 303);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DailyViewBackGround;
    }
}
