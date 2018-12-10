namespace EducationProject.View.Student
{
    partial class StudentSent
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
            this.lblStudentSentMessages = new System.Windows.Forms.Label();
            this.rchbxStudentSentMessages = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblStudentSentMessages
            // 
            this.lblStudentSentMessages.AutoSize = true;
            this.lblStudentSentMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentSentMessages.Location = new System.Drawing.Point(9, 46);
            this.lblStudentSentMessages.Name = "lblStudentSentMessages";
            this.lblStudentSentMessages.Size = new System.Drawing.Size(109, 17);
            this.lblStudentSentMessages.TabIndex = 5;
            this.lblStudentSentMessages.Text = "Sent Messages:";
            // 
            // rchbxStudentSentMessages
            // 
            this.rchbxStudentSentMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchbxStudentSentMessages.Location = new System.Drawing.Point(12, 66);
            this.rchbxStudentSentMessages.Name = "rchbxStudentSentMessages";
            this.rchbxStudentSentMessages.Size = new System.Drawing.Size(489, 270);
            this.rchbxStudentSentMessages.TabIndex = 4;
            this.rchbxStudentSentMessages.Text = "";
            // 
            // StudentSent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.Controls.Add(this.lblStudentSentMessages);
            this.Controls.Add(this.rchbxStudentSentMessages);
            this.Name = "StudentSent";
            this.Text = "Sent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentSentMessages;
        private System.Windows.Forms.RichTextBox rchbxStudentSentMessages;
    }
}