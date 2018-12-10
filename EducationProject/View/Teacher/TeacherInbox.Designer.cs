namespace EducationProject.View.Teacher
{
    partial class TeacherInbox
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
            this.rchbxTeacherInboxMessages = new System.Windows.Forms.RichTextBox();
            this.lblTeacherInboxMessages = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rchbxTeacherInboxMessages
            // 
            this.rchbxTeacherInboxMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchbxTeacherInboxMessages.Location = new System.Drawing.Point(12, 66);
            this.rchbxTeacherInboxMessages.Name = "rchbxTeacherInboxMessages";
            this.rchbxTeacherInboxMessages.Size = new System.Drawing.Size(489, 270);
            this.rchbxTeacherInboxMessages.TabIndex = 0;
            this.rchbxTeacherInboxMessages.Text = "";
            // 
            // lblTeacherInboxMessages
            // 
            this.lblTeacherInboxMessages.AutoSize = true;
            this.lblTeacherInboxMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherInboxMessages.Location = new System.Drawing.Point(9, 46);
            this.lblTeacherInboxMessages.Name = "lblTeacherInboxMessages";
            this.lblTeacherInboxMessages.Size = new System.Drawing.Size(113, 17);
            this.lblTeacherInboxMessages.TabIndex = 1;
            this.lblTeacherInboxMessages.Text = "Inbox Messages:";
            // 
            // TeacherInbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.Controls.Add(this.lblTeacherInboxMessages);
            this.Controls.Add(this.rchbxTeacherInboxMessages);
            this.Name = "TeacherInbox";
            this.Text = "Inbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchbxTeacherInboxMessages;
        private System.Windows.Forms.Label lblTeacherInboxMessages;
    }
}