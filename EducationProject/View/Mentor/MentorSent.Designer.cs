namespace EducationProject.View.Mentor
{
    partial class MentorSent
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
            this.lblMentorSentMessages = new System.Windows.Forms.Label();
            this.rchbxMentorSentMessages = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblMentorSentMessages
            // 
            this.lblMentorSentMessages.AutoSize = true;
            this.lblMentorSentMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMentorSentMessages.Location = new System.Drawing.Point(9, 46);
            this.lblMentorSentMessages.Name = "lblMentorSentMessages";
            this.lblMentorSentMessages.Size = new System.Drawing.Size(109, 17);
            this.lblMentorSentMessages.TabIndex = 9;
            this.lblMentorSentMessages.Text = "Sent Messages:";
            // 
            // rchbxMentorSentMessages
            // 
            this.rchbxMentorSentMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchbxMentorSentMessages.Location = new System.Drawing.Point(12, 66);
            this.rchbxMentorSentMessages.Name = "rchbxMentorSentMessages";
            this.rchbxMentorSentMessages.Size = new System.Drawing.Size(489, 270);
            this.rchbxMentorSentMessages.TabIndex = 8;
            this.rchbxMentorSentMessages.Text = "";
            // 
            // MentorSent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.Controls.Add(this.lblMentorSentMessages);
            this.Controls.Add(this.rchbxMentorSentMessages);
            this.Name = "MentorSent";
            this.Text = "Sent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMentorSentMessages;
        private System.Windows.Forms.RichTextBox rchbxMentorSentMessages;
    }
}