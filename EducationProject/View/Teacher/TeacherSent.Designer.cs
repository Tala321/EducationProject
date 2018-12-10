namespace EducationProject.View.Teacher
{
    partial class TeacherSent
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
            this.lblTeacherSentMessages = new System.Windows.Forms.Label();
            this.rchbxTeacherSentMessages = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblTeacherSentMessages
            // 
            this.lblTeacherSentMessages.AutoSize = true;
            this.lblTeacherSentMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherSentMessages.Location = new System.Drawing.Point(9, 46);
            this.lblTeacherSentMessages.Name = "lblTeacherSentMessages";
            this.lblTeacherSentMessages.Size = new System.Drawing.Size(109, 17);
            this.lblTeacherSentMessages.TabIndex = 3;
            this.lblTeacherSentMessages.Text = "Sent Messages:";
            // 
            // rchbxTeacherSentMessages
            // 
            this.rchbxTeacherSentMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchbxTeacherSentMessages.Location = new System.Drawing.Point(12, 66);
            this.rchbxTeacherSentMessages.Name = "rchbxTeacherSentMessages";
            this.rchbxTeacherSentMessages.Size = new System.Drawing.Size(489, 270);
            this.rchbxTeacherSentMessages.TabIndex = 2;
            this.rchbxTeacherSentMessages.Text = "";
            // 
            // TeacherSent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.Controls.Add(this.lblTeacherSentMessages);
            this.Controls.Add(this.rchbxTeacherSentMessages);
            this.Name = "TeacherSent";
            this.Text = "Sent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeacherSentMessages;
        private System.Windows.Forms.RichTextBox rchbxTeacherSentMessages;
    }
}