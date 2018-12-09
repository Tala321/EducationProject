namespace EducationProject.View.Student
{
    partial class StudentEditInfo
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
            this.btnStudentEditConfirm = new System.Windows.Forms.Button();
            this.lblStudentPhoneChange = new System.Windows.Forms.Label();
            this.tbxStudentPhoneChange = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStudentEditConfirm
            // 
            this.btnStudentEditConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentEditConfirm.Location = new System.Drawing.Point(149, 94);
            this.btnStudentEditConfirm.Name = "btnStudentEditConfirm";
            this.btnStudentEditConfirm.Size = new System.Drawing.Size(68, 25);
            this.btnStudentEditConfirm.TabIndex = 37;
            this.btnStudentEditConfirm.Text = "Confirm";
            this.btnStudentEditConfirm.UseVisualStyleBackColor = true;
            // 
            // lblStudentPhoneChange
            // 
            this.lblStudentPhoneChange.AutoSize = true;
            this.lblStudentPhoneChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentPhoneChange.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStudentPhoneChange.Location = new System.Drawing.Point(51, 58);
            this.lblStudentPhoneChange.Name = "lblStudentPhoneChange";
            this.lblStudentPhoneChange.Size = new System.Drawing.Size(53, 17);
            this.lblStudentPhoneChange.TabIndex = 27;
            this.lblStudentPhoneChange.Text = "Phone:";
            // 
            // tbxStudentPhoneChange
            // 
            this.tbxStudentPhoneChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStudentPhoneChange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxStudentPhoneChange.Location = new System.Drawing.Point(110, 56);
            this.tbxStudentPhoneChange.Name = "tbxStudentPhoneChange";
            this.tbxStudentPhoneChange.Size = new System.Drawing.Size(107, 23);
            this.tbxStudentPhoneChange.TabIndex = 38;
            // 
            // StudentEditInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 158);
            this.Controls.Add(this.tbxStudentPhoneChange);
            this.Controls.Add(this.btnStudentEditConfirm);
            this.Controls.Add(this.lblStudentPhoneChange);
            this.Name = "StudentEditInfo";
            this.Text = "Edit Personal Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStudentEditConfirm;
        private System.Windows.Forms.Label lblStudentPhoneChange;
        private System.Windows.Forms.TextBox tbxStudentPhoneChange;
    }
}