namespace EducationProject.View.Mentor
{
    partial class MentorInbox
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
            this.lblMentorInboxMessages = new System.Windows.Forms.Label();
            this.rchbxMentorInboxMessages = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblMentorInboxMessages
            // 
            this.lblMentorInboxMessages.AutoSize = true;
            this.lblMentorInboxMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMentorInboxMessages.Location = new System.Drawing.Point(9, 46);
            this.lblMentorInboxMessages.Name = "lblMentorInboxMessages";
            this.lblMentorInboxMessages.Size = new System.Drawing.Size(109, 17);
            this.lblMentorInboxMessages.TabIndex = 7;
            this.lblMentorInboxMessages.Text = "Sent Messages:";
            // 
            // rchbxMentorInboxMessages
            // 
            this.rchbxMentorInboxMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchbxMentorInboxMessages.Location = new System.Drawing.Point(12, 66);
            this.rchbxMentorInboxMessages.Name = "rchbxMentorInboxMessages";
            this.rchbxMentorInboxMessages.Size = new System.Drawing.Size(489, 270);
            this.rchbxMentorInboxMessages.TabIndex = 6;
            this.rchbxMentorInboxMessages.Text = "";
            // 
            // MentorInbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.Controls.Add(this.lblMentorInboxMessages);
            this.Controls.Add(this.rchbxMentorInboxMessages);
            this.Name = "MentorInbox";
            this.Text = "Inbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMentorInboxMessages;
        private System.Windows.Forms.RichTextBox rchbxMentorInboxMessages;
    }
}