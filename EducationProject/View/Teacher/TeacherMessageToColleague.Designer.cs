namespace EducationProject.View.Teacher
{
    partial class TeacherMessageToColleague
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
            this.cbxTeacherMessageToCollegue = new System.Windows.Forms.ComboBox();
            this.lblTeacherMessageToCollegue = new System.Windows.Forms.Label();
            this.tbxTeacherMessageBoxCollegue = new System.Windows.Forms.TextBox();
            this.btnTeacherSendToCoolegue = new System.Windows.Forms.Button();
            this.lblTeacherToCollegue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxTeacherMessageToCollegue
            // 
            this.cbxTeacherMessageToCollegue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTeacherMessageToCollegue.FormattingEnabled = true;
            this.cbxTeacherMessageToCollegue.Location = new System.Drawing.Point(91, 65);
            this.cbxTeacherMessageToCollegue.Name = "cbxTeacherMessageToCollegue";
            this.cbxTeacherMessageToCollegue.Size = new System.Drawing.Size(121, 24);
            this.cbxTeacherMessageToCollegue.TabIndex = 25;
            // 
            // lblTeacherMessageToCollegue
            // 
            this.lblTeacherMessageToCollegue.AutoSize = true;
            this.lblTeacherMessageToCollegue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherMessageToCollegue.Location = new System.Drawing.Point(20, 109);
            this.lblTeacherMessageToCollegue.Name = "lblTeacherMessageToCollegue";
            this.lblTeacherMessageToCollegue.Size = new System.Drawing.Size(69, 17);
            this.lblTeacherMessageToCollegue.TabIndex = 22;
            this.lblTeacherMessageToCollegue.Text = "Message:";
            // 
            // tbxTeacherMessageBoxCollegue
            // 
            this.tbxTeacherMessageBoxCollegue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTeacherMessageBoxCollegue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxTeacherMessageBoxCollegue.Location = new System.Drawing.Point(91, 107);
            this.tbxTeacherMessageBoxCollegue.Multiline = true;
            this.tbxTeacherMessageBoxCollegue.Name = "tbxTeacherMessageBoxCollegue";
            this.tbxTeacherMessageBoxCollegue.Size = new System.Drawing.Size(381, 171);
            this.tbxTeacherMessageBoxCollegue.TabIndex = 21;
            // 
            // btnTeacherSendToCoolegue
            // 
            this.btnTeacherSendToCoolegue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherSendToCoolegue.Location = new System.Drawing.Point(392, 294);
            this.btnTeacherSendToCoolegue.Name = "btnTeacherSendToCoolegue";
            this.btnTeacherSendToCoolegue.Size = new System.Drawing.Size(80, 25);
            this.btnTeacherSendToCoolegue.TabIndex = 24;
            this.btnTeacherSendToCoolegue.Text = "Send";
            this.btnTeacherSendToCoolegue.UseVisualStyleBackColor = true;
            // 
            // lblTeacherToCollegue
            // 
            this.lblTeacherToCollegue.AutoSize = true;
            this.lblTeacherToCollegue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherToCollegue.Location = new System.Drawing.Point(20, 66);
            this.lblTeacherToCollegue.Name = "lblTeacherToCollegue";
            this.lblTeacherToCollegue.Size = new System.Drawing.Size(29, 17);
            this.lblTeacherToCollegue.TabIndex = 23;
            this.lblTeacherToCollegue.Text = "To:";
            // 
            // TeacherMessageToCollegue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.Controls.Add(this.cbxTeacherMessageToCollegue);
            this.Controls.Add(this.lblTeacherMessageToCollegue);
            this.Controls.Add(this.tbxTeacherMessageBoxCollegue);
            this.Controls.Add(this.btnTeacherSendToCoolegue);
            this.Controls.Add(this.lblTeacherToCollegue);
            this.Name = "TeacherMessageToCollegue";
            this.Text = "New Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTeacherMessageToCollegue;
        private System.Windows.Forms.Label lblTeacherMessageToCollegue;
        private System.Windows.Forms.TextBox tbxTeacherMessageBoxCollegue;
        private System.Windows.Forms.Button btnTeacherSendToCoolegue;
        private System.Windows.Forms.Label lblTeacherToCollegue;
    }
}