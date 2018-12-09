namespace EducationProject.View.Teacher
{
    partial class TeacherMessageToGroup
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
            this.cbxTeacherMessageToGroup = new System.Windows.Forms.ComboBox();
            this.lblTeacherMessageToGroup = new System.Windows.Forms.Label();
            this.tbxTeacherMessageBoxGroup = new System.Windows.Forms.TextBox();
            this.btnTeacherSendToGroup = new System.Windows.Forms.Button();
            this.lblTeacherToGroup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxTeacherMessageToGroup
            // 
            this.cbxTeacherMessageToGroup.FormattingEnabled = true;
            this.cbxTeacherMessageToGroup.Location = new System.Drawing.Point(91, 65);
            this.cbxTeacherMessageToGroup.Name = "cbxTeacherMessageToGroup";
            this.cbxTeacherMessageToGroup.Size = new System.Drawing.Size(121, 24);
            this.cbxTeacherMessageToGroup.TabIndex = 20;
            // 
            // lblTeacherMessageToGroup
            // 
            this.lblTeacherMessageToGroup.AutoSize = true;
            this.lblTeacherMessageToGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherMessageToGroup.Location = new System.Drawing.Point(20, 109);
            this.lblTeacherMessageToGroup.Name = "lblTeacherMessageToGroup";
            this.lblTeacherMessageToGroup.Size = new System.Drawing.Size(69, 17);
            this.lblTeacherMessageToGroup.TabIndex = 17;
            this.lblTeacherMessageToGroup.Text = "Message:";
            // 
            // tbxTeacherMessageBoxGroup
            // 
            this.tbxTeacherMessageBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTeacherMessageBoxGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxTeacherMessageBoxGroup.Location = new System.Drawing.Point(91, 107);
            this.tbxTeacherMessageBoxGroup.Multiline = true;
            this.tbxTeacherMessageBoxGroup.Name = "tbxTeacherMessageBoxGroup";
            this.tbxTeacherMessageBoxGroup.Size = new System.Drawing.Size(381, 171);
            this.tbxTeacherMessageBoxGroup.TabIndex = 16;
            // 
            // btnTeacherSendToGroup
            // 
            this.btnTeacherSendToGroup.Location = new System.Drawing.Point(392, 294);
            this.btnTeacherSendToGroup.Name = "btnTeacherSendToGroup";
            this.btnTeacherSendToGroup.Size = new System.Drawing.Size(80, 25);
            this.btnTeacherSendToGroup.TabIndex = 19;
            this.btnTeacherSendToGroup.Text = "Send";
            this.btnTeacherSendToGroup.UseVisualStyleBackColor = true;
            // 
            // lblTeacherToGroup
            // 
            this.lblTeacherToGroup.AutoSize = true;
            this.lblTeacherToGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherToGroup.Location = new System.Drawing.Point(20, 66);
            this.lblTeacherToGroup.Name = "lblTeacherToGroup";
            this.lblTeacherToGroup.Size = new System.Drawing.Size(29, 17);
            this.lblTeacherToGroup.TabIndex = 18;
            this.lblTeacherToGroup.Text = "To:";
            // 
            // TeacherMessageToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.Controls.Add(this.cbxTeacherMessageToGroup);
            this.Controls.Add(this.lblTeacherMessageToGroup);
            this.Controls.Add(this.tbxTeacherMessageBoxGroup);
            this.Controls.Add(this.btnTeacherSendToGroup);
            this.Controls.Add(this.lblTeacherToGroup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TeacherMessageToGroup";
            this.Text = "New Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTeacherMessageToGroup;
        private System.Windows.Forms.Label lblTeacherMessageToGroup;
        private System.Windows.Forms.TextBox tbxTeacherMessageBoxGroup;
        private System.Windows.Forms.Button btnTeacherSendToGroup;
        private System.Windows.Forms.Label lblTeacherToGroup;
    }
}