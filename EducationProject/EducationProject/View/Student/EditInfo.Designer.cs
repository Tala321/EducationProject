namespace EducationProject.View.Student
{
    partial class EditInfo
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
            this.lblStudentId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStudentEditConfirm
            // 
            this.btnStudentEditConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentEditConfirm.Location = new System.Drawing.Point(121, 94);
            this.btnStudentEditConfirm.Name = "btnStudentEditConfirm";
            this.btnStudentEditConfirm.Size = new System.Drawing.Size(68, 25);
            this.btnStudentEditConfirm.TabIndex = 37;
            this.btnStudentEditConfirm.Text = "Confirm";
            this.btnStudentEditConfirm.UseVisualStyleBackColor = true;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStudentId.Location = new System.Drawing.Point(23, 58);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(53, 17);
            this.lblStudentId.TabIndex = 27;
            this.lblStudentId.Text = "Phone:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(82, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 23);
            this.textBox1.TabIndex = 38;
            // 
            // EditInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 158);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStudentEditConfirm);
            this.Controls.Add(this.lblStudentId);
            this.Name = "EditInfo";
            this.Text = "Edit Personal Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStudentEditConfirm;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox textBox1;
    }
}