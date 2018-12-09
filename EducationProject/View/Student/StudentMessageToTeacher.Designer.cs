namespace EducationProject
{
    partial class MessageToTeacher
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
            this.tbxMessageBoxTeacher = new System.Windows.Forms.TextBox();
            this.lblMessageToTeacher = new System.Windows.Forms.Label();
            this.lblToTeacher = new System.Windows.Forms.Label();
            this.lblTeacherEmail = new System.Windows.Forms.Label();
            this.btnSendToTeacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxMessageBoxTeacher
            // 
            this.tbxMessageBoxTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMessageBoxTeacher.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxMessageBoxTeacher.Location = new System.Drawing.Point(91, 107);
            this.tbxMessageBoxTeacher.Multiline = true;
            this.tbxMessageBoxTeacher.Name = "tbxMessageBoxTeacher";
            this.tbxMessageBoxTeacher.Size = new System.Drawing.Size(381, 171);
            this.tbxMessageBoxTeacher.TabIndex = 0;
            // 
            // lblMessageToTeacher
            // 
            this.lblMessageToTeacher.AutoSize = true;
            this.lblMessageToTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageToTeacher.Location = new System.Drawing.Point(20, 109);
            this.lblMessageToTeacher.Name = "lblMessageToTeacher";
            this.lblMessageToTeacher.Size = new System.Drawing.Size(69, 17);
            this.lblMessageToTeacher.TabIndex = 1;
            this.lblMessageToTeacher.Text = "Message:";
            // 
            // lblToTeacher
            // 
            this.lblToTeacher.AutoSize = true;
            this.lblToTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToTeacher.Location = new System.Drawing.Point(20, 66);
            this.lblToTeacher.Name = "lblToTeacher";
            this.lblToTeacher.Size = new System.Drawing.Size(29, 17);
            this.lblToTeacher.TabIndex = 2;
            this.lblToTeacher.Text = "To:";
            // 
            // lblTeacherEmail
            // 
            this.lblTeacherEmail.AutoSize = true;
            this.lblTeacherEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherEmail.Location = new System.Drawing.Point(90, 66);
            this.lblTeacherEmail.Name = "lblTeacherEmail";
            this.lblTeacherEmail.Size = new System.Drawing.Size(42, 17);
            this.lblTeacherEmail.TabIndex = 3;
            this.lblTeacherEmail.Text = "Email";
            // 
            // btnSendToTeacher
            // 
            this.btnSendToTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendToTeacher.Location = new System.Drawing.Point(392, 294);
            this.btnSendToTeacher.Name = "btnSendToTeacher";
            this.btnSendToTeacher.Size = new System.Drawing.Size(80, 25);
            this.btnSendToTeacher.TabIndex = 4;
            this.btnSendToTeacher.Text = "Send";
            this.btnSendToTeacher.UseVisualStyleBackColor = true;
            // 
            // MessageToTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.Controls.Add(this.lblMessageToTeacher);
            this.Controls.Add(this.tbxMessageBoxTeacher);
            this.Controls.Add(this.btnSendToTeacher);
            this.Controls.Add(this.lblTeacherEmail);
            this.Controls.Add(this.lblToTeacher);
            this.Name = "MessageToTeacher";
            this.Text = "New Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMessageBoxTeacher;
        private System.Windows.Forms.Label lblMessageToTeacher;
        private System.Windows.Forms.Label lblToTeacher;
        private System.Windows.Forms.Label lblTeacherEmail;
        private System.Windows.Forms.Button btnSendToTeacher;
    }
}