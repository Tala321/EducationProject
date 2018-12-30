namespace EducationProject.View.Mentor
{
    partial class MentorSent
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
            this.lblMentorSentMessages = new System.Windows.Forms.Label();
            this.dgwMentorSentMessages = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMentorSentMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMentorSentMessages
            // 
            this.lblMentorSentMessages.AutoSize = true;
            this.lblMentorSentMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMentorSentMessages.Location = new System.Drawing.Point(9, 46);
            this.lblMentorSentMessages.Name = "lblMentorSentMessages";
            this.lblMentorSentMessages.Size = new System.Drawing.Size(109, 17);
            this.lblMentorSentMessages.TabIndex = 9;
            this.lblMentorSentMessages.Text = "Sent Messages:";
            // 
            // dgwMentorSentMessages
            // 
            this.dgwMentorSentMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMentorSentMessages.Location = new System.Drawing.Point(12, 66);
            this.dgwMentorSentMessages.Name = "dgwMentorSentMessages";
            this.dgwMentorSentMessages.ReadOnly = true;
            this.dgwMentorSentMessages.Size = new System.Drawing.Size(489, 270);
            this.dgwMentorSentMessages.TabIndex = 10;
            this.dgwMentorSentMessages.Click += new System.EventHandler(this.dgwMentorSentMessages_Click);
            // 
            // MentorSent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.Controls.Add(this.dgwMentorSentMessages);
            this.Controls.Add(this.lblMentorSentMessages);
            this.Name = "MentorSent";
            this.Text = "Sent";
            ((System.ComponentModel.ISupportInitialize)(this.dgwMentorSentMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMentorSentMessages;
        private System.Windows.Forms.DataGridView dgwMentorSentMessages;
    }
}