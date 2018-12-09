namespace EducationProject.View.Teacher
{
    partial class Teacher
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.PanelTeacher.SuspendLayout();
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
            // assignTaskToolStripMenuItem
            // 
            this.assignTaskToolStripMenuItem.Name = "assignTaskToolStripMenuItem";
            this.assignTaskToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.assignTaskToolStripMenuItem.Text = "Assign Task";
            this.assignTaskToolStripMenuItem.Click += new System.EventHandler(this.assignTaskToolStripMenuItem_Click);
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
            this.newMessageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newMessageToolStripMenuItem.Text = "New Message";
            // 
            // toStudentToolStripMenuItem
            // 
            this.toStudentToolStripMenuItem.Name = "toStudentToolStripMenuItem";
            this.toStudentToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.toStudentToolStripMenuItem.Text = "To Group";
            this.toStudentToolStripMenuItem.Click += new System.EventHandler(this.toStudentToolStripMenuItem_Click);
            // 
            // toMentorToolStripMenuItem
            // 
            this.toMentorToolStripMenuItem.Name = "toMentorToolStripMenuItem";
            this.toMentorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toMentorToolStripMenuItem.Text = "To Mentor";
            this.toMentorToolStripMenuItem.Click += new System.EventHandler(this.TeacherWriteMessageToMentor);
            // 
            // toCollegueToolStripMenuItem
            // 
            this.toCollegueToolStripMenuItem.Name = "toCollegueToolStripMenuItem";
            this.toCollegueToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.toCollegueToolStripMenuItem.Text = "To Collegue";
            this.toCollegueToolStripMenuItem.Click += new System.EventHandler(this.toCollegueToolStripMenuItem_Click);
            // 
            // colleguesToolStripMenuItem
            // 
            this.colleguesToolStripMenuItem.Name = "colleguesToolStripMenuItem";
            this.colleguesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.colleguesToolStripMenuItem.Text = "Collegues";
            this.colleguesToolStripMenuItem.Click += new System.EventHandler(this.colleguesToolStripMenuItem_Click);
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
            this.PanelTeacher.Controls.Add(this.comboBox1);
            this.PanelTeacher.Controls.Add(this.label1);
            this.PanelTeacher.Location = new System.Drawing.Point(12, 27);
            this.PanelTeacher.Name = "PanelTeacher";
            this.PanelTeacher.Size = new System.Drawing.Size(552, 264);
            this.PanelTeacher.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 303);
            this.Controls.Add(this.PanelTeacher);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelTeacher.ResumeLayout(false);
            this.PanelTeacher.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}