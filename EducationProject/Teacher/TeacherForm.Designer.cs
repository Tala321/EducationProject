namespace EducationProject.View.Teacher
{
    partial class TeacherForm
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
            this.assignTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAssignedTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignTaskToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentorInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toMentorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toCollegueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colleguesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelTeacher = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalInfoToolStripMenuItem,
            this.taskToolStripMenuItem,
            this.assignTaskToolStripMenuItem,
            this.groupsToolStripMenuItem,
            this.mentorInfoToolStripMenuItem,
            this.myMessagesToolStripMenuItem,
            this.colleguesToolStripMenuItem,
            this.libraryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(577, 24);
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
            // assignTaskToolStripMenuItem
            // 
            this.assignTaskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAssignedTaskToolStripMenuItem,
            this.assignTaskToolStripMenuItem1});
            this.assignTaskToolStripMenuItem.Name = "assignTaskToolStripMenuItem";
            this.assignTaskToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.assignTaskToolStripMenuItem.Text = "Assign Task";
            // 
            // showAssignedTaskToolStripMenuItem
            // 
            this.showAssignedTaskToolStripMenuItem.Name = "showAssignedTaskToolStripMenuItem";
            this.showAssignedTaskToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.showAssignedTaskToolStripMenuItem.Text = "Assign a task";
            this.showAssignedTaskToolStripMenuItem.Click += new System.EventHandler(this.AssignTaskToStudent);
            // 
            // assignTaskToolStripMenuItem1
            // 
            this.assignTaskToolStripMenuItem1.Name = "assignTaskToolStripMenuItem1";
            this.assignTaskToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.assignTaskToolStripMenuItem1.Text = "Transcript";
            this.assignTaskToolStripMenuItem1.Click += new System.EventHandler(this.ShowEditTranscript);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.groupsToolStripMenuItem.Text = "Groups";
            this.groupsToolStripMenuItem.Click += new System.EventHandler(this.groupsToolStripMenuItem_Click);
            // 
            // mentorInfoToolStripMenuItem
            // 
            this.mentorInfoToolStripMenuItem.Name = "mentorInfoToolStripMenuItem";
            this.mentorInfoToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.mentorInfoToolStripMenuItem.Text = "Mentor Info";
            this.mentorInfoToolStripMenuItem.Click += new System.EventHandler(this.mentorInfoToolStripMenuItem_Click);
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
            this.sentToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.sentToolStripMenuItem.Text = "Sent";
            this.sentToolStripMenuItem.Click += new System.EventHandler(this.sentToolStripMenuItem_Click);
            // 
            // inboxToolStripMenuItem
            // 
            this.inboxToolStripMenuItem.Name = "inboxToolStripMenuItem";
            this.inboxToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.inboxToolStripMenuItem.Text = "Inbox";
            this.inboxToolStripMenuItem.Click += new System.EventHandler(this.inboxToolStripMenuItem_Click);
            // 
            // newMessageToolStripMenuItem
            // 
            this.newMessageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toStudentToolStripMenuItem,
            this.toMentorToolStripMenuItem,
            this.toCollegueToolStripMenuItem});
            this.newMessageToolStripMenuItem.Name = "newMessageToolStripMenuItem";
            this.newMessageToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.newMessageToolStripMenuItem.Text = "New Message";
            // 
            // toStudentToolStripMenuItem
            // 
            this.toStudentToolStripMenuItem.Name = "toStudentToolStripMenuItem";
            this.toStudentToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.toStudentToolStripMenuItem.Text = "To Group";
            this.toStudentToolStripMenuItem.Click += new System.EventHandler(this.toStudentToolStripMenuItem_Click);
            // 
            // toMentorToolStripMenuItem
            // 
            this.toMentorToolStripMenuItem.Name = "toMentorToolStripMenuItem";
            this.toMentorToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.toMentorToolStripMenuItem.Text = "To Mentor";
            this.toMentorToolStripMenuItem.Click += new System.EventHandler(this.TeacherWriteMessageToMentor);
            // 
            // toCollegueToolStripMenuItem
            // 
            this.toCollegueToolStripMenuItem.Name = "toCollegueToolStripMenuItem";
            this.toCollegueToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.toCollegueToolStripMenuItem.Text = "To Collegaue";
            this.toCollegueToolStripMenuItem.Click += new System.EventHandler(this.toColleagueToolStripMenuItem_Click);
            // 
            // colleguesToolStripMenuItem
            // 
            this.colleguesToolStripMenuItem.Name = "colleguesToolStripMenuItem";
            this.colleguesToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.colleguesToolStripMenuItem.Text = "Colleagues";
            this.colleguesToolStripMenuItem.Click += new System.EventHandler(this.ColleaguesToolStripMenuItem_Click);
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.libraryToolStripMenuItem.Text = "Library";
            this.libraryToolStripMenuItem.Click += new System.EventHandler(this.libraryToolStripMenuItem_Click);
            // 
            // PanelTeacher
            // 
            this.PanelTeacher.Location = new System.Drawing.Point(12, 27);
            this.PanelTeacher.Name = "PanelTeacher";
            this.PanelTeacher.Size = new System.Drawing.Size(552, 270);
            this.PanelTeacher.TabIndex = 1;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 303);
            this.Controls.Add(this.PanelTeacher);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TeacherForm";
            this.ShowInTaskbar = false;
            this.Text = "Teacher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentorInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myMessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colleguesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.Panel PanelTeacher;
        private System.Windows.Forms.ToolStripMenuItem sentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toMentorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toCollegueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAssignedTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignTaskToolStripMenuItem1;
    }
}