namespace EducationProject.View.Teacher
{
    partial class TeacherMessageToMentor
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
            this.cbxTeacherMessageToMentor = new System.Windows.Forms.ComboBox();
            this.lblTeacherMessageToMentor = new System.Windows.Forms.Label();
            this.tbxTeacherMessageBoxMentor = new System.Windows.Forms.TextBox();
            this.btnTeacherSendToMentor = new System.Windows.Forms.Button();
            this.lblTeacherToMentor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxTeacherMessageToMentor
            // 
            this.cbxTeacherMessageToMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTeacherMessageToMentor.FormattingEnabled = true;
            this.cbxTeacherMessageToMentor.Location = new System.Drawing.Point(91, 65);
            this.cbxTeacherMessageToMentor.Name = "cbxTeacherMessageToMentor";
            this.cbxTeacherMessageToMentor.Size = new System.Drawing.Size(121, 24);
            this.cbxTeacherMessageToMentor.TabIndex = 25;
            // 
            // lblTeacherMessageToMentor
            // 
            this.lblTeacherMessageToMentor.AutoSize = true;
            this.lblTeacherMessageToMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherMessageToMentor.Location = new System.Drawing.Point(20, 109);
            this.lblTeacherMessageToMentor.Name = "lblTeacherMessageToMentor";
            this.lblTeacherMessageToMentor.Size = new System.Drawing.Size(69, 17);
            this.lblTeacherMessageToMentor.TabIndex = 22;
            this.lblTeacherMessageToMentor.Text = "Message:";
            // 
            // tbxTeacherMessageBoxMentor
            // 
            this.tbxTeacherMessageBoxMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTeacherMessageBoxMentor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxTeacherMessageBoxMentor.Location = new System.Drawing.Point(91, 107);
            this.tbxTeacherMessageBoxMentor.Multiline = true;
            this.tbxTeacherMessageBoxMentor.Name = "tbxTeacherMessageBoxMentor";
            this.tbxTeacherMessageBoxMentor.Size = new System.Drawing.Size(381, 171);
            this.tbxTeacherMessageBoxMentor.TabIndex = 21;
            // 
            // btnTeacherSendToMentor
            // 
            this.btnTeacherSendToMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherSendToMentor.Location = new System.Drawing.Point(392, 294);
            this.btnTeacherSendToMentor.Name = "btnTeacherSendToMentor";
            this.btnTeacherSendToMentor.Size = new System.Drawing.Size(80, 25);
            this.btnTeacherSendToMentor.TabIndex = 24;
            this.btnTeacherSendToMentor.Text = "Send";
            this.btnTeacherSendToMentor.UseVisualStyleBackColor = true;
            // 
            // lblTeacherToMentor
            // 
            this.lblTeacherToMentor.AutoSize = true;
            this.lblTeacherToMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherToMentor.Location = new System.Drawing.Point(20, 66);
            this.lblTeacherToMentor.Name = "lblTeacherToMentor";
            this.lblTeacherToMentor.Size = new System.Drawing.Size(29, 17);
            this.lblTeacherToMentor.TabIndex = 23;
            this.lblTeacherToMentor.Text = "To:";
            // 
            // TeacherMessageToMentor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.Controls.Add(this.cbxTeacherMessageToMentor);
            this.Controls.Add(this.lblTeacherMessageToMentor);
            this.Controls.Add(this.tbxTeacherMessageBoxMentor);
            this.Controls.Add(this.btnTeacherSendToMentor);
            this.Controls.Add(this.lblTeacherToMentor);
            this.Name = "TeacherMessageToMentor";
            this.Text = "New Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTeacherMessageToMentor;
        private System.Windows.Forms.Label lblTeacherMessageToMentor;
        private System.Windows.Forms.TextBox tbxTeacherMessageBoxMentor;
        private System.Windows.Forms.Button btnTeacherSendToMentor;
        private System.Windows.Forms.Label lblTeacherToMentor;
    }
}