namespace EducationProject
{
    partial class MessageToMentor
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
            this.lblMessageToMentor = new System.Windows.Forms.Label();
            this.tbxMessageBoxMentor = new System.Windows.Forms.TextBox();
            this.btnSendToMentor = new System.Windows.Forms.Button();
            this.lblMentorEmail = new System.Windows.Forms.Label();
            this.lblToMentor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMessageToMentor
            // 
            this.lblMessageToMentor.AutoSize = true;
            this.lblMessageToMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageToMentor.Location = new System.Drawing.Point(20, 109);
            this.lblMessageToMentor.Name = "lblMessageToMentor";
            this.lblMessageToMentor.Size = new System.Drawing.Size(69, 17);
            this.lblMessageToMentor.TabIndex = 6;
            this.lblMessageToMentor.Text = "Message:";
            // 
            // tbxMessageBoxMentor
            // 
            this.tbxMessageBoxMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMessageBoxMentor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxMessageBoxMentor.Location = new System.Drawing.Point(91, 107);
            this.tbxMessageBoxMentor.Multiline = true;
            this.tbxMessageBoxMentor.Name = "tbxMessageBoxMentor";
            this.tbxMessageBoxMentor.Size = new System.Drawing.Size(381, 171);
            this.tbxMessageBoxMentor.TabIndex = 5;
            // 
            // btnSendToMentor
            // 
            this.btnSendToMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendToMentor.Location = new System.Drawing.Point(392, 294);
            this.btnSendToMentor.Name = "btnSendToMentor";
            this.btnSendToMentor.Size = new System.Drawing.Size(80, 25);
            this.btnSendToMentor.TabIndex = 9;
            this.btnSendToMentor.Text = "Send";
            this.btnSendToMentor.UseVisualStyleBackColor = true;
            // 
            // lblMentorEmail
            // 
            this.lblMentorEmail.AutoSize = true;
            this.lblMentorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMentorEmail.Location = new System.Drawing.Point(90, 66);
            this.lblMentorEmail.Name = "lblMentorEmail";
            this.lblMentorEmail.Size = new System.Drawing.Size(42, 17);
            this.lblMentorEmail.TabIndex = 8;
            this.lblMentorEmail.Text = "Email";
            // 
            // lblToMentor
            // 
            this.lblToMentor.AutoSize = true;
            this.lblToMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToMentor.Location = new System.Drawing.Point(20, 66);
            this.lblToMentor.Name = "lblToMentor";
            this.lblToMentor.Size = new System.Drawing.Size(29, 17);
            this.lblToMentor.TabIndex = 7;
            this.lblToMentor.Text = "To:";
            // 
            // MessageToMentor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.Controls.Add(this.lblMessageToMentor);
            this.Controls.Add(this.tbxMessageBoxMentor);
            this.Controls.Add(this.btnSendToMentor);
            this.Controls.Add(this.lblMentorEmail);
            this.Controls.Add(this.lblToMentor);
            this.Name = "MessageToMentor";
            this.Text = "New Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessageToMentor;
        private System.Windows.Forms.TextBox tbxMessageBoxMentor;
        private System.Windows.Forms.Button btnSendToMentor;
        private System.Windows.Forms.Label lblMentorEmail;
        private System.Windows.Forms.Label lblToMentor;
    }
}