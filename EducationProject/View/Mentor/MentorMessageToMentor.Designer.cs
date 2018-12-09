namespace EducationProject.View.Mentor
{
    partial class MentorMessageToMentor
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
            this.cbxMentorMessageToColleague = new System.Windows.Forms.ComboBox();
            this.lblMentorMessageToColleague = new System.Windows.Forms.Label();
            this.tbxMentorMessageBoxColleague = new System.Windows.Forms.TextBox();
            this.btnMentorSendToColleague = new System.Windows.Forms.Button();
            this.lblMentorToColleague = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxMentorMessageToColleague
            // 
            this.cbxMentorMessageToColleague.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMentorMessageToColleague.FormattingEnabled = true;
            this.cbxMentorMessageToColleague.Location = new System.Drawing.Point(91, 65);
            this.cbxMentorMessageToColleague.Name = "cbxMentorMessageToColleague";
            this.cbxMentorMessageToColleague.Size = new System.Drawing.Size(121, 24);
            this.cbxMentorMessageToColleague.TabIndex = 35;
            // 
            // lblMentorMessageToColleague
            // 
            this.lblMentorMessageToColleague.AutoSize = true;
            this.lblMentorMessageToColleague.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMentorMessageToColleague.Location = new System.Drawing.Point(20, 109);
            this.lblMentorMessageToColleague.Name = "lblMentorMessageToColleague";
            this.lblMentorMessageToColleague.Size = new System.Drawing.Size(69, 17);
            this.lblMentorMessageToColleague.TabIndex = 32;
            this.lblMentorMessageToColleague.Text = "Message:";
            // 
            // tbxMentorMessageBoxColleague
            // 
            this.tbxMentorMessageBoxColleague.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMentorMessageBoxColleague.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxMentorMessageBoxColleague.Location = new System.Drawing.Point(91, 107);
            this.tbxMentorMessageBoxColleague.Multiline = true;
            this.tbxMentorMessageBoxColleague.Name = "tbxMentorMessageBoxColleague";
            this.tbxMentorMessageBoxColleague.Size = new System.Drawing.Size(381, 171);
            this.tbxMentorMessageBoxColleague.TabIndex = 31;
            // 
            // btnMentorSendToColleague
            // 
            this.btnMentorSendToColleague.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMentorSendToColleague.Location = new System.Drawing.Point(392, 294);
            this.btnMentorSendToColleague.Name = "btnMentorSendToColleague";
            this.btnMentorSendToColleague.Size = new System.Drawing.Size(80, 25);
            this.btnMentorSendToColleague.TabIndex = 34;
            this.btnMentorSendToColleague.Text = "Send";
            this.btnMentorSendToColleague.UseVisualStyleBackColor = true;
            // 
            // lblMentorToColleague
            // 
            this.lblMentorToColleague.AutoSize = true;
            this.lblMentorToColleague.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMentorToColleague.Location = new System.Drawing.Point(20, 66);
            this.lblMentorToColleague.Name = "lblMentorToColleague";
            this.lblMentorToColleague.Size = new System.Drawing.Size(29, 17);
            this.lblMentorToColleague.TabIndex = 33;
            this.lblMentorToColleague.Text = "To:";
            // 
            // MentorMessageToColleague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.Controls.Add(this.cbxMentorMessageToColleague);
            this.Controls.Add(this.lblMentorMessageToColleague);
            this.Controls.Add(this.tbxMentorMessageBoxColleague);
            this.Controls.Add(this.btnMentorSendToColleague);
            this.Controls.Add(this.lblMentorToColleague);
            this.Name = "MentorMessageToColleague";
            this.Text = "New Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxMentorMessageToColleague;
        private System.Windows.Forms.Label lblMentorMessageToColleague;
        private System.Windows.Forms.TextBox tbxMentorMessageBoxColleague;
        private System.Windows.Forms.Button btnMentorSendToColleague;
        private System.Windows.Forms.Label lblMentorToColleague;
    }
}