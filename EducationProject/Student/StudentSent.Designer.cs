namespace EducationProject.View.Student
{
    partial class StudentSent
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
            this.lblStudentSentMessages = new System.Windows.Forms.Label();
            this.dgwStudentSentMessages = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentSentMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentSentMessages
            // 
            this.lblStudentSentMessages.AutoSize = true;
            this.lblStudentSentMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentSentMessages.Location = new System.Drawing.Point(9, 46);
            this.lblStudentSentMessages.Name = "lblStudentSentMessages";
            this.lblStudentSentMessages.Size = new System.Drawing.Size(109, 17);
            this.lblStudentSentMessages.TabIndex = 5;
            this.lblStudentSentMessages.Text = "Sent Messages:";
            // 
            // dgwStudentSentMessages
            // 
            this.dgwStudentSentMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudentSentMessages.Location = new System.Drawing.Point(12, 66);
            this.dgwStudentSentMessages.Name = "dgwStudentSentMessages";
            this.dgwStudentSentMessages.ReadOnly = true;
            this.dgwStudentSentMessages.Size = new System.Drawing.Size(489, 270);
            this.dgwStudentSentMessages.TabIndex = 7;
            this.dgwStudentSentMessages.DoubleClick += new System.EventHandler(this.dgwStudentSentMessages_DoubleClick);
            // 
            // StudentSent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.Controls.Add(this.dgwStudentSentMessages);
            this.Controls.Add(this.lblStudentSentMessages);
            this.Name = "StudentSent";
            this.Text = "Sent";
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentSentMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentSentMessages;
        private System.Windows.Forms.DataGridView dgwStudentSentMessages;
    }
}