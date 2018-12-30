namespace EducationProject.View.Teacher
{
    partial class TeacherInbox
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
            this.lblTeacherInboxMessages = new System.Windows.Forms.Label();
            this.dgwTeacherInboxMessages = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeacherInboxMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeacherInboxMessages
            // 
            this.lblTeacherInboxMessages.AutoSize = true;
            this.lblTeacherInboxMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherInboxMessages.Location = new System.Drawing.Point(9, 42);
            this.lblTeacherInboxMessages.Name = "lblTeacherInboxMessages";
            this.lblTeacherInboxMessages.Size = new System.Drawing.Size(113, 17);
            this.lblTeacherInboxMessages.TabIndex = 1;
            this.lblTeacherInboxMessages.Text = "Inbox Messages:";
            // 
            // dgwTeacherInboxMessages
            // 
            this.dgwTeacherInboxMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTeacherInboxMessages.Location = new System.Drawing.Point(12, 66);
            this.dgwTeacherInboxMessages.Name = "dgwTeacherInboxMessages";
            this.dgwTeacherInboxMessages.Size = new System.Drawing.Size(489, 270);
            this.dgwTeacherInboxMessages.TabIndex = 5;
            this.dgwTeacherInboxMessages.DoubleClick += new System.EventHandler(this.dgwTeacherInboxMessages_DoubleClick);
            // 
            // TeacherInbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.Controls.Add(this.dgwTeacherInboxMessages);
            this.Controls.Add(this.lblTeacherInboxMessages);
            this.Name = "TeacherInbox";
            this.Text = "Inbox";
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeacherInboxMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTeacherInboxMessages;
        private System.Windows.Forms.DataGridView dgwTeacherInboxMessages;
    }
}