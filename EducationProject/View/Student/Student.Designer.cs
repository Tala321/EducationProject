namespace EducationProject.View.Student
{
    partial class StudentForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personalInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentorInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toMentorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toGroupmateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupmatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelStudent = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalInfoToolStripMenuItem,
            this.showTasksToolStripMenuItem,
            this.teacherInfoToolStripMenuItem,
            this.mentorInfoToolStripMenuItem,
            this.myMessagesToolStripMenuItem,
            this.groupmatesToolStripMenuItem,
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
            // showTasksToolStripMenuItem
            // 
            this.showTasksToolStripMenuItem.Name = "showTasksToolStripMenuItem";
            this.showTasksToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.showTasksToolStripMenuItem.Text = "Show Tasks";
            this.showTasksToolStripMenuItem.Click += new System.EventHandler(this.showTasksToolStripMenuItem_Click);
            // 
            // teacherInfoToolStripMenuItem
            // 
            this.teacherInfoToolStripMenuItem.Name = "teacherInfoToolStripMenuItem";
            this.teacherInfoToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.teacherInfoToolStripMenuItem.Text = "Teacher Info ";
            this.teacherInfoToolStripMenuItem.Click += new System.EventHandler(this.teacherInfoToolStripMenuItem_Click);
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
            this.toTeacherToolStripMenuItem,
            this.toMentorToolStripMenuItem,
            this.toGroupmateToolStripMenuItem});
            this.newMessageToolStripMenuItem.Name = "newMessageToolStripMenuItem";
            this.newMessageToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.newMessageToolStripMenuItem.Text = "New Message";
            // 
            // toTeacherToolStripMenuItem
            // 
            this.toTeacherToolStripMenuItem.Name = "toTeacherToolStripMenuItem";
            this.toTeacherToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.toTeacherToolStripMenuItem.Text = "To Teacher";
            this.toTeacherToolStripMenuItem.Click += new System.EventHandler(this.WritePrivateMessageToTeacher);
            // 
            // toMentorToolStripMenuItem
            // 
            this.toMentorToolStripMenuItem.Name = "toMentorToolStripMenuItem";
            this.toMentorToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.toMentorToolStripMenuItem.Text = "To Mentor";
            this.toMentorToolStripMenuItem.Click += new System.EventHandler(this.WritePrivateMessageToMentor);
            // 
            // toGroupmateToolStripMenuItem
            // 
            this.toGroupmateToolStripMenuItem.Name = "toGroupmateToolStripMenuItem";
            this.toGroupmateToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.toGroupmateToolStripMenuItem.Text = "To Groupmate";
            this.toGroupmateToolStripMenuItem.Click += new System.EventHandler(this.toGroupmateToolStripMenuItem_Click);
            // 
            // groupmatesToolStripMenuItem
            // 
            this.groupmatesToolStripMenuItem.Name = "groupmatesToolStripMenuItem";
            this.groupmatesToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.groupmatesToolStripMenuItem.Text = "Groupmates";
            this.groupmatesToolStripMenuItem.Click += new System.EventHandler(this.groupmatesToolStripMenuItem_Click);
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.libraryToolStripMenuItem.Text = "Library";
            this.libraryToolStripMenuItem.Click += new System.EventHandler(this.libraryToolStripMenuItem_Click);
            // 
            // PanelStudent
            // 
            this.PanelStudent.Location = new System.Drawing.Point(13, 28);
            this.PanelStudent.Name = "PanelStudent";
            this.PanelStudent.Size = new System.Drawing.Size(548, 263);
            this.PanelStudent.TabIndex = 1;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 303);
            this.Controls.Add(this.PanelStudent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentForm";
            this.Text = "Student";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentorInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myMessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupmatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.Panel PanelStudent;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem sentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toMentorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toGroupmateToolStripMenuItem;
    }
}