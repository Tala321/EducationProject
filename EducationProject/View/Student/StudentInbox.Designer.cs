namespace EducationProject.View.Student
{
    partial class StudentInbox
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
            this.lblStudentInboxMessages = new System.Windows.Forms.Label();
            this.rchbxStudentInboxMessages = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblStudentInboxMessages
            // 
            this.lblStudentInboxMessages.AutoSize = true;
            this.lblStudentInboxMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentInboxMessages.Location = new System.Drawing.Point(9, 46);
            this.lblStudentInboxMessages.Name = "lblStudentInboxMessages";
            this.lblStudentInboxMessages.Size = new System.Drawing.Size(109, 17);
            this.lblStudentInboxMessages.TabIndex = 5;
            this.lblStudentInboxMessages.Text = "Sent Messages:";
            // 
            // rchbxStudentInboxMessages
            // 
            this.rchbxStudentInboxMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchbxStudentInboxMessages.Location = new System.Drawing.Point(12, 66);
            this.rchbxStudentInboxMessages.Name = "rchbxStudentInboxMessages";
            this.rchbxStudentInboxMessages.Size = new System.Drawing.Size(489, 270);
            this.rchbxStudentInboxMessages.TabIndex = 4;
            this.rchbxStudentInboxMessages.Text = "";
            // 
            // StudentInbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.Controls.Add(this.lblStudentInboxMessages);
            this.Controls.Add(this.rchbxStudentInboxMessages);
            this.Name = "StudentInbox";
            this.Text = "Inbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentInboxMessages;
        private System.Windows.Forms.RichTextBox rchbxStudentInboxMessages;
    }
}