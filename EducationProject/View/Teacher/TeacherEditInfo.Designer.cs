namespace EducationProject.View.Teacher
{
    partial class TeacherEditInfo
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
            this.tbxTeacherPhoneChange = new System.Windows.Forms.TextBox();
            this.btnTeacherEditConfirm = new System.Windows.Forms.Button();
            this.lblTeacherPhoneChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxTeacherPhoneChange
            // 
            this.tbxTeacherPhoneChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTeacherPhoneChange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxTeacherPhoneChange.Location = new System.Drawing.Point(110, 56);
            this.tbxTeacherPhoneChange.Name = "tbxTeacherPhoneChange";
            this.tbxTeacherPhoneChange.Size = new System.Drawing.Size(107, 23);
            this.tbxTeacherPhoneChange.TabIndex = 41;
            // 
            // btnTeacherEditConfirm
            // 
            this.btnTeacherEditConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherEditConfirm.Location = new System.Drawing.Point(149, 94);
            this.btnTeacherEditConfirm.Name = "btnTeacherEditConfirm";
            this.btnTeacherEditConfirm.Size = new System.Drawing.Size(68, 25);
            this.btnTeacherEditConfirm.TabIndex = 40;
            this.btnTeacherEditConfirm.Text = "Confirm";
            this.btnTeacherEditConfirm.UseVisualStyleBackColor = true;
            // 
            // lblTeacherPhoneChange
            // 
            this.lblTeacherPhoneChange.AutoSize = true;
            this.lblTeacherPhoneChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherPhoneChange.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTeacherPhoneChange.Location = new System.Drawing.Point(51, 58);
            this.lblTeacherPhoneChange.Name = "lblTeacherPhoneChange";
            this.lblTeacherPhoneChange.Size = new System.Drawing.Size(53, 17);
            this.lblTeacherPhoneChange.TabIndex = 39;
            this.lblTeacherPhoneChange.Text = "Phone:";
            // 
            // TeacherEditInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 158);
            this.Controls.Add(this.tbxTeacherPhoneChange);
            this.Controls.Add(this.btnTeacherEditConfirm);
            this.Controls.Add(this.lblTeacherPhoneChange);
            this.Name = "TeacherEditInfo";
            this.Text = "Edit Personal Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTeacherPhoneChange;
        private System.Windows.Forms.Button btnTeacherEditConfirm;
        private System.Windows.Forms.Label lblTeacherPhoneChange;
    }
}