namespace EducationProject.View.Mentor
{
    partial class MentorMessageToGroup
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
            this.lblMentorMessageToGroup = new System.Windows.Forms.Label();
            this.tbxMentorMessageBoxGroup = new System.Windows.Forms.TextBox();
            this.btnMentorSendToGroup = new System.Windows.Forms.Button();
            this.tbxMentorToGroupTitle = new System.Windows.Forms.TextBox();
            this.lblMentorToGroupTitle = new System.Windows.Forms.Label();
            this.cbxMentorMessageToGroup = new System.Windows.Forms.ComboBox();
            this.lblToGroup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMentorMessageToGroup
            // 
            this.lblMentorMessageToGroup.AutoSize = true;
            this.lblMentorMessageToGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMentorMessageToGroup.Location = new System.Drawing.Point(20, 109);
            this.lblMentorMessageToGroup.Name = "lblMentorMessageToGroup";
            this.lblMentorMessageToGroup.Size = new System.Drawing.Size(69, 17);
            this.lblMentorMessageToGroup.TabIndex = 22;
            this.lblMentorMessageToGroup.Text = "Message:";
            // 
            // tbxMentorMessageBoxGroup
            // 
            this.tbxMentorMessageBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMentorMessageBoxGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxMentorMessageBoxGroup.Location = new System.Drawing.Point(91, 107);
            this.tbxMentorMessageBoxGroup.Multiline = true;
            this.tbxMentorMessageBoxGroup.Name = "tbxMentorMessageBoxGroup";
            this.tbxMentorMessageBoxGroup.Size = new System.Drawing.Size(381, 171);
            this.tbxMentorMessageBoxGroup.TabIndex = 21;
            // 
            // btnMentorSendToGroup
            // 
            this.btnMentorSendToGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMentorSendToGroup.Location = new System.Drawing.Point(392, 294);
            this.btnMentorSendToGroup.Name = "btnMentorSendToGroup";
            this.btnMentorSendToGroup.Size = new System.Drawing.Size(80, 25);
            this.btnMentorSendToGroup.TabIndex = 24;
            this.btnMentorSendToGroup.Text = "Send";
            this.btnMentorSendToGroup.UseVisualStyleBackColor = true;
            this.btnMentorSendToGroup.Click += new System.EventHandler(this.btnMentorSendToGroup_Click);
            // 
            // tbxMentorToGroupTitle
            // 
            this.tbxMentorToGroupTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMentorToGroupTitle.Location = new System.Drawing.Point(91, 73);
            this.tbxMentorToGroupTitle.Name = "tbxMentorToGroupTitle";
            this.tbxMentorToGroupTitle.Size = new System.Drawing.Size(100, 23);
            this.tbxMentorToGroupTitle.TabIndex = 38;
            // 
            // lblMentorToGroupTitle
            // 
            this.lblMentorToGroupTitle.AutoSize = true;
            this.lblMentorToGroupTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMentorToGroupTitle.Location = new System.Drawing.Point(20, 74);
            this.lblMentorToGroupTitle.Name = "lblMentorToGroupTitle";
            this.lblMentorToGroupTitle.Size = new System.Drawing.Size(39, 17);
            this.lblMentorToGroupTitle.TabIndex = 37;
            this.lblMentorToGroupTitle.Text = "Title:";
            // 
            // cbxMentorMessageToGroup
            // 
            this.cbxMentorMessageToGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMentorMessageToGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMentorMessageToGroup.FormattingEnabled = true;
            this.cbxMentorMessageToGroup.Location = new System.Drawing.Point(91, 40);
            this.cbxMentorMessageToGroup.Name = "cbxMentorMessageToGroup";
            this.cbxMentorMessageToGroup.Size = new System.Drawing.Size(121, 24);
            this.cbxMentorMessageToGroup.TabIndex = 36;
            // 
            // lblToGroup
            // 
            this.lblToGroup.AutoSize = true;
            this.lblToGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToGroup.Location = new System.Drawing.Point(20, 41);
            this.lblToGroup.Name = "lblToGroup";
            this.lblToGroup.Size = new System.Drawing.Size(29, 17);
            this.lblToGroup.TabIndex = 35;
            this.lblToGroup.Text = "To:";
            // 
            // MentorMessageToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.Controls.Add(this.tbxMentorToGroupTitle);
            this.Controls.Add(this.lblMentorToGroupTitle);
            this.Controls.Add(this.cbxMentorMessageToGroup);
            this.Controls.Add(this.lblToGroup);
            this.Controls.Add(this.lblMentorMessageToGroup);
            this.Controls.Add(this.tbxMentorMessageBoxGroup);
            this.Controls.Add(this.btnMentorSendToGroup);
            this.Name = "MentorMessageToGroup";
            this.Text = "New Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMentorMessageToGroup;
        private System.Windows.Forms.TextBox tbxMentorMessageBoxGroup;
        private System.Windows.Forms.Button btnMentorSendToGroup;
        private System.Windows.Forms.TextBox tbxMentorToGroupTitle;
        private System.Windows.Forms.Label lblMentorToGroupTitle;
        private System.Windows.Forms.ComboBox cbxMentorMessageToGroup;
        private System.Windows.Forms.Label lblToGroup;
    }
}