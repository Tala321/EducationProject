namespace EducationProject.View.Mentor
{
    partial class MentorMessageToTeacher
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
            this.cbxMentorMessageToTeacher = new System.Windows.Forms.ComboBox();
            this.lblMentorMessageToTeacher = new System.Windows.Forms.Label();
            this.tbxMentorMessageBoxTeacher = new System.Windows.Forms.TextBox();
            this.btnMentorSendToTeacher = new System.Windows.Forms.Button();
            this.lblMentorToTeacher = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxMentorMessageToTeacher
            // 
            this.cbxMentorMessageToTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMentorMessageToTeacher.FormattingEnabled = true;
            this.cbxMentorMessageToTeacher.Location = new System.Drawing.Point(91, 65);
            this.cbxMentorMessageToTeacher.Name = "cbxMentorMessageToTeacher";
            this.cbxMentorMessageToTeacher.Size = new System.Drawing.Size(121, 24);
            this.cbxMentorMessageToTeacher.TabIndex = 30;
            // 
            // lblMentorMessageToTeacher
            // 
            this.lblMentorMessageToTeacher.AutoSize = true;
            this.lblMentorMessageToTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMentorMessageToTeacher.Location = new System.Drawing.Point(20, 109);
            this.lblMentorMessageToTeacher.Name = "lblMentorMessageToTeacher";
            this.lblMentorMessageToTeacher.Size = new System.Drawing.Size(69, 17);
            this.lblMentorMessageToTeacher.TabIndex = 27;
            this.lblMentorMessageToTeacher.Text = "Message:";
            // 
            // tbxMentorMessageBoxTeacher
            // 
            this.tbxMentorMessageBoxTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMentorMessageBoxTeacher.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxMentorMessageBoxTeacher.Location = new System.Drawing.Point(91, 107);
            this.tbxMentorMessageBoxTeacher.Multiline = true;
            this.tbxMentorMessageBoxTeacher.Name = "tbxMentorMessageBoxTeacher";
            this.tbxMentorMessageBoxTeacher.Size = new System.Drawing.Size(381, 171);
            this.tbxMentorMessageBoxTeacher.TabIndex = 26;
            // 
            // btnMentorSendToTeacher
            // 
            this.btnMentorSendToTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMentorSendToTeacher.Location = new System.Drawing.Point(392, 294);
            this.btnMentorSendToTeacher.Name = "btnMentorSendToTeacher";
            this.btnMentorSendToTeacher.Size = new System.Drawing.Size(80, 25);
            this.btnMentorSendToTeacher.TabIndex = 29;
            this.btnMentorSendToTeacher.Text = "Send";
            this.btnMentorSendToTeacher.UseVisualStyleBackColor = true;
            // 
            // lblMentorToTeacher
            // 
            this.lblMentorToTeacher.AutoSize = true;
            this.lblMentorToTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMentorToTeacher.Location = new System.Drawing.Point(20, 66);
            this.lblMentorToTeacher.Name = "lblMentorToTeacher";
            this.lblMentorToTeacher.Size = new System.Drawing.Size(29, 17);
            this.lblMentorToTeacher.TabIndex = 28;
            this.lblMentorToTeacher.Text = "To:";
            // 
            // MentorMessageToTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.Controls.Add(this.cbxMentorMessageToTeacher);
            this.Controls.Add(this.lblMentorMessageToTeacher);
            this.Controls.Add(this.tbxMentorMessageBoxTeacher);
            this.Controls.Add(this.btnMentorSendToTeacher);
            this.Controls.Add(this.lblMentorToTeacher);
            this.Name = "MentorMessageToTeacher";
            this.Text = "New Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxMentorMessageToTeacher;
        private System.Windows.Forms.Label lblMentorMessageToTeacher;
        private System.Windows.Forms.TextBox tbxMentorMessageBoxTeacher;
        private System.Windows.Forms.Button btnMentorSendToTeacher;
        private System.Windows.Forms.Label lblMentorToTeacher;
    }
}