namespace EducationProject.View
{
    partial class WelcomeScreen
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
            this.tbxLoginEmail = new System.Windows.Forms.TextBox();
            this.tbxLoginPassword = new System.Windows.Forms.TextBox();
            this.lblLoginEmail = new System.Windows.Forms.Label();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.lblLoginUserType = new System.Windows.Forms.Label();
            this.cbxLoginUserType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbxLoginEmail
            // 
            this.tbxLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLoginEmail.Location = new System.Drawing.Point(222, 73);
            this.tbxLoginEmail.Name = "tbxLoginEmail";
            this.tbxLoginEmail.Size = new System.Drawing.Size(100, 23);
            this.tbxLoginEmail.TabIndex = 0;
            // 
            // tbxLoginPassword
            // 
            this.tbxLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLoginPassword.Location = new System.Drawing.Point(222, 110);
            this.tbxLoginPassword.Name = "tbxLoginPassword";
            this.tbxLoginPassword.Size = new System.Drawing.Size(100, 23);
            this.tbxLoginPassword.TabIndex = 1;
            // 
            // lblLoginEmail
            // 
            this.lblLoginEmail.AutoSize = true;
            this.lblLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginEmail.Location = new System.Drawing.Point(131, 75);
            this.lblLoginEmail.Name = "lblLoginEmail";
            this.lblLoginEmail.Size = new System.Drawing.Size(46, 17);
            this.lblLoginEmail.TabIndex = 3;
            this.lblLoginEmail.Text = "Email:";
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPassword.Location = new System.Drawing.Point(131, 112);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(73, 17);
            this.lblLoginPassword.TabIndex = 4;
            this.lblLoginPassword.Text = "Password:";
            // 
            // lblLoginUserType
            // 
            this.lblLoginUserType.AutoSize = true;
            this.lblLoginUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUserType.Location = new System.Drawing.Point(131, 149);
            this.lblLoginUserType.Name = "lblLoginUserType";
            this.lblLoginUserType.Size = new System.Drawing.Size(73, 17);
            this.lblLoginUserType.TabIndex = 7;
            this.lblLoginUserType.Text = "User type:";
            // 
            // cbxLoginUserType
            // 
            this.cbxLoginUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoginUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLoginUserType.FormattingEnabled = true;
            this.cbxLoginUserType.Location = new System.Drawing.Point(222, 147);
            this.cbxLoginUserType.Name = "cbxLoginUserType";
            this.cbxLoginUserType.Size = new System.Drawing.Size(100, 24);
            this.cbxLoginUserType.TabIndex = 6;
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 249);
            this.Controls.Add(this.lblLoginUserType);
            this.Controls.Add(this.cbxLoginUserType);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.lblLoginEmail);
            this.Controls.Add(this.tbxLoginPassword);
            this.Controls.Add(this.tbxLoginEmail);
            this.Name = "WelcomeScreen";
            this.Text = "Welcome Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLoginEmail;
        private System.Windows.Forms.TextBox tbxLoginPassword;
        private System.Windows.Forms.Label lblLoginEmail;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Label lblLoginUserType;
        private System.Windows.Forms.ComboBox cbxLoginUserType;
    }
}