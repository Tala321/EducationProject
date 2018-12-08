namespace EducationProject.View.Student
{
    partial class MessageToGroupmate
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.btnSendToGroupmate.Location = new System.Drawing.Point(397, 296);
            this.btnSendToGroupmate.Name = "btnSendToGroupmate";
            this.btnSendToGroupmate.Size = new System.Drawing.Size(75, 23);
            this.btnSendToGroupmate.TabIndex = 14;
            this.btnSendToGroupmate.Text = "Send";
            this.btnSendToGroupmate.UseVisualStyleBackColor = true;
            // 
            // lblToGroupmate
            // 
            this.lblToGroupmate.AutoSize = true;
            this.lblToGroupmate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToGroupmate.Location = new System.Drawing.Point(20, 66);
            this.lblToGroupmate.Name = "lblToGroupmate";
            this.lblToGroupmate.Size = new System.Drawing.Size(29, 17);
            this.lblToGroupmate.TabIndex = 12;
            this.lblToGroupmate.Text = "To:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // MessageToGroupmate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblMessageToGroupmate);
            this.Controls.Add(this.tbxMessageBoxGroupmate);
            this.Controls.Add(this.btnSendToGroupmate);
            this.Controls.Add(this.lblToGroupmate);
            this.Name = "MessageToGroupmate";
            this.Text = "New Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessageToGroupmate;
        private System.Windows.Forms.TextBox tbxMessageBoxGroupmate;
        private System.Windows.Forms.Button btnSendToGroupmate;
        private System.Windows.Forms.Label lblToGroupmate;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}