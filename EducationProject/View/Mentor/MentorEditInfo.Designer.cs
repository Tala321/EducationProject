namespace EducationProject.View.Mentor
{
    partial class MentorEditInfo
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
            this.tbxMentorPhoneChange = new System.Windows.Forms.TextBox();
            this.btnMentorEditConfirm = new System.Windows.Forms.Button();
            this.lblMentorPhoneChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxMentorPhoneChange
            // 
            this.tbxMentorPhoneChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMentorPhoneChange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxMentorPhoneChange.Location = new System.Drawing.Point(110, 56);
            this.tbxMentorPhoneChange.Name = "tbxMentorPhoneChange";
            this.tbxMentorPhoneChange.Size = new System.Drawing.Size(107, 23);
            this.tbxMentorPhoneChange.TabIndex = 44;
            // 
            // btnMentorEditConfirm
            // 
            this.btnMentorEditConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMentorEditConfirm.Location = new System.Drawing.Point(149, 94);
            this.btnMentorEditConfirm.Name = "btnMentorEditConfirm";
            this.btnMentorEditConfirm.Size = new System.Drawing.Size(68, 25);
            this.btnMentorEditConfirm.TabIndex = 43;
            this.btnMentorEditConfirm.Text = "Confirm";
            this.btnMentorEditConfirm.UseVisualStyleBackColor = true;
            // 
            // lblMentorPhoneChange
            // 
            this.lblMentorPhoneChange.AutoSize = true;
            this.lblMentorPhoneChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMentorPhoneChange.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMentorPhoneChange.Location = new System.Drawing.Point(51, 58);
            this.lblMentorPhoneChange.Name = "lblMentorPhoneChange";
            this.lblMentorPhoneChange.Size = new System.Drawing.Size(53, 17);
            this.lblMentorPhoneChange.TabIndex = 42;
            this.lblMentorPhoneChange.Text = "Phone:";
            // 
            // MentorEditInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 158);
            this.Controls.Add(this.tbxMentorPhoneChange);
            this.Controls.Add(this.btnMentorEditConfirm);
            this.Controls.Add(this.lblMentorPhoneChange);
            this.Name = "MentorEditInfo";
            this.Text = "Edit Personal Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMentorPhoneChange;
        private System.Windows.Forms.Button btnMentorEditConfirm;
        private System.Windows.Forms.Label lblMentorPhoneChange;
    }
}