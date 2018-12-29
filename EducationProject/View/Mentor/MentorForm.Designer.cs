namespace EducationProject.View.Mentor
{
    partial class MentorForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personalInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toCollegueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dwwdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelMentor = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalInfoToolStripMenuItem,
            this.taskToolStripMenuItem,
            this.groupToolStripMenuItem,
            this.myMessagesToolStripMenuItem,
            this.dwwdaToolStripMenuItem,
            this.libraryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personalInfoToolStripMenuItem
            // 
            this.personalInfoToolStripMenuItem.Name = "personalInfoToolStripMenuItem";
            this.personalInfoToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.personalInfoToolStripMenuItem.Text = "Personal Info";
            this.personalInfoToolStripMenuItem.Click += new System.EventHandler(this.personalInfoToolStripMenuItem_Click);
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.taskToolStripMenuItem.Text = "Task";
            this.taskToolStripMenuItem.Click += new System.EventHandler(this.taskToolStripMenuItem_Click);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.groupToolStripMenuItem.Text = "Group";
            this.groupToolStripMenuItem.Click += new System.EventHandler(this.groupToolStripMenuItem_Click);
            // 
            // myMessagesToolStripMenuItem
            // 
            this.myMessagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sentToolStripMenuItem,
            this.inboxToolStripMenuItem,
            this.newMessageToolStripMenuItem});
            this.myMessagesToolStripMenuItem.Name = "myMessagesToolStripMenuItem";
            this.myMessagesToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.myMessagesToolStripMenuItem.Text = "My Messages";
            // 
            // sentToolStripMenuItem
            // 
            this.sentToolStripMenuItem.Name = "sentToolStripMenuItem";
            this.sentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sentToolStripMenuItem.Text = "Sent";
            this.sentToolStripMenuItem.Click += new System.EventHandler(this.sentToolStripMenuItem_Click);
            // 
            // inboxToolStripMenuItem
            // 
            this.inboxToolStripMenuItem.Name = "inboxToolStripMenuItem";
            this.inboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inboxToolStripMenuItem.Text = "Inbox";
            this.inboxToolStripMenuItem.Click += new System.EventHandler(this.inboxToolStripMenuItem_Click);
            // 
            // newMessageToolStripMenuItem
            // 
            this.newMessageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toGroupToolStripMenuItem,
            this.toTeacherToolStripMenuItem,
            this.toCollegueToolStripMenuItem});
            this.newMessageToolStripMenuItem.Name = "newMessageToolStripMenuItem";
            this.newMessageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newMessageToolStripMenuItem.Text = "New Message";
            // 
            // toGroupToolStripMenuItem
            // 
            this.toGroupToolStripMenuItem.Name = "toGroupToolStripMenuItem";
            this.toGroupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toGroupToolStripMenuItem.Text = "To Group";
            this.toGroupToolStripMenuItem.Click += new System.EventHandler(this.toGroupToolStripMenuItem_Click);
            // 
            // toTeacherToolStripMenuItem
            // 
            this.toTeacherToolStripMenuItem.Name = "toTeacherToolStripMenuItem";
            this.toTeacherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toTeacherToolStripMenuItem.Text = "To Teacher";
            this.toTeacherToolStripMenuItem.Click += new System.EventHandler(this.toTeacherToolStripMenuItem_Click);
            // 
            // toCollegueToolStripMenuItem
            // 
            this.toCollegueToolStripMenuItem.Name = "toCollegueToolStripMenuItem";
            this.toCollegueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toCollegueToolStripMenuItem.Text = "To Mentor";
            this.toCollegueToolStripMenuItem.Click += new System.EventHandler(this.toMentorToolStripMenuItem_Click);
            // 
            // dwwdaToolStripMenuItem
            // 
            this.dwwdaToolStripMenuItem.Name = "dwwdaToolStripMenuItem";
            this.dwwdaToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.dwwdaToolStripMenuItem.Text = "Colleagues";
            this.dwwdaToolStripMenuItem.Click += new System.EventHandler(this.colleaguesToolStripMenuItem_Click);
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.libraryToolStripMenuItem.Text = "Library";
            this.libraryToolStripMenuItem.Click += new System.EventHandler(this.libraryToolStripMenuItem_Click);
            // 
            // PanelMentor
            // 
            this.PanelMentor.Location = new System.Drawing.Point(13, 28);
            this.PanelMentor.Name = "PanelMentor";
            this.PanelMentor.Size = new System.Drawing.Size(548, 263);
            this.PanelMentor.TabIndex = 1;
            // 
            // MentorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 303);
            this.Controls.Add(this.PanelMentor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MentorForm";
            this.Text = "Mentor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myMessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dwwdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.Panel PanelMentor;
        private System.Windows.Forms.ToolStripMenuItem sentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toCollegueToolStripMenuItem;
    }
}