namespace EducationProject.View.Student
{
    partial class StudentMessageToGroupmate
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
            this.lblMessageToGroupmate = new System.Windows.Forms.Label();
            this.tbxMessageBoxGroupmate = new System.Windows.Forms.TextBox();
            this.btnSendToGroupmate = new System.Windows.Forms.Button();
            this.lblToGroupmate = new System.Windows.Forms.Label();
            this.cbxStudentMessageToGroupmate = new System.Windows.Forms.ComboBox();
            this.tbxStudentToGroupmateTitle = new System.Windows.Forms.TextBox();
            this.lblStudentToGroupmateTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMessageToGroupmate
            // 
            this.lblMessageToGroupmate.AutoSize = true;
            this.lblMessageToGroupmate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageToGroupmate.Location = new System.Drawing.Point(20, 109);
            this.lblMessageToGroupmate.Name = "lblMessageToGroupmate";
            this.lblMessageToGroupmate.Size = new System.Drawing.Size(69, 17);
            this.lblMessageToGroupmate.TabIndex = 11;
            this.lblMessageToGroupmate.Text = "Message:";
            // 
            // tbxMessageBoxGroupmate
            // 
            this.tbxMessageBoxGroupmate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMessageBoxGroupmate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxMessageBoxGroupmate.Location = new System.Drawing.Point(91, 107);
            this.tbxMessageBoxGroupmate.Multiline = true;
            this.tbxMessageBoxGroupmate.Name = "tbxMessageBoxGroupmate";
            this.tbxMessageBoxGroupmate.Size = new System.Drawing.Size(381, 171);
            this.tbxMessageBoxGroupmate.TabIndex = 10;
            // 
            // btnSendToGroupmate
            // 
            this.btnSendToGroupmate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendToGroupmate.Location = new System.Drawing.Point(392, 294);
            this.btnSendToGroupmate.Name = "btnSendToGroupmate";
            this.btnSendToGroupmate.Size = new System.Drawing.Size(80, 25);
            this.btnSendToGroupmate.TabIndex = 14;
            this.btnSendToGroupmate.Text = "Send";
            this.btnSendToGroupmate.UseVisualStyleBackColor = true;
            this.btnSendToGroupmate.Click += new System.EventHandler(this.btnSendToGroupmate_Click);
            // 
            // lblToGroupmate
            // 
            this.lblToGroupmate.AutoSize = true;
            this.lblToGroupmate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToGroupmate.Location = new System.Drawing.Point(20, 44);
            this.lblToGroupmate.Name = "lblToGroupmate";
            this.lblToGroupmate.Size = new System.Drawing.Size(29, 17);
            this.lblToGroupmate.TabIndex = 12;
            this.lblToGroupmate.Text = "To:";
            // 
            // cbxStudentMessageToGroupmate
            // 
            this.cbxStudentMessageToGroupmate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStudentMessageToGroupmate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStudentMessageToGroupmate.FormattingEnabled = true;
            this.cbxStudentMessageToGroupmate.Location = new System.Drawing.Point(91, 43);
            this.cbxStudentMessageToGroupmate.Name = "cbxStudentMessageToGroupmate";
            this.cbxStudentMessageToGroupmate.Size = new System.Drawing.Size(121, 24);
            this.cbxStudentMessageToGroupmate.TabIndex = 15;
            // 
            // tbxStudentToGroupmateTitle
            // 
            this.tbxStudentToGroupmateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStudentToGroupmateTitle.Location = new System.Drawing.Point(91, 76);
            this.tbxStudentToGroupmateTitle.Name = "tbxStudentToGroupmateTitle";
            this.tbxStudentToGroupmateTitle.Size = new System.Drawing.Size(100, 23);
            this.tbxStudentToGroupmateTitle.TabIndex = 34;
            // 
            // lblStudentToGroupmateTitle
            // 
            this.lblStudentToGroupmateTitle.AutoSize = true;
            this.lblStudentToGroupmateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentToGroupmateTitle.Location = new System.Drawing.Point(20, 77);
            this.lblStudentToGroupmateTitle.Name = "lblStudentToGroupmateTitle";
            this.lblStudentToGroupmateTitle.Size = new System.Drawing.Size(39, 17);
            this.lblStudentToGroupmateTitle.TabIndex = 33;
            this.lblStudentToGroupmateTitle.Text = "Title:";
            // 
            // StudentMessageToGroupmate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.Controls.Add(this.tbxStudentToGroupmateTitle);
            this.Controls.Add(this.lblStudentToGroupmateTitle);
            this.Controls.Add(this.cbxStudentMessageToGroupmate);
            this.Controls.Add(this.lblMessageToGroupmate);
            this.Controls.Add(this.tbxMessageBoxGroupmate);
            this.Controls.Add(this.btnSendToGroupmate);
            this.Controls.Add(this.lblToGroupmate);
            this.Name = "StudentMessageToGroupmate";
            this.Text = "New Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessageToGroupmate;
        private System.Windows.Forms.TextBox tbxMessageBoxGroupmate;
        private System.Windows.Forms.Button btnSendToGroupmate;
        private System.Windows.Forms.Label lblToGroupmate;
        private System.Windows.Forms.ComboBox cbxStudentMessageToGroupmate;
        private System.Windows.Forms.TextBox tbxStudentToGroupmateTitle;
        private System.Windows.Forms.Label lblStudentToGroupmateTitle;
    }
}