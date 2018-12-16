namespace EducationProject.View.Teacher
{
    partial class TeacherAssignTask
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
            this.chbxTeacherAssignStudetnList = new System.Windows.Forms.CheckedListBox();
            this.btnAssignTaskStudent = new System.Windows.Forms.Button();
            this.cbxTeacherAssignGroup = new System.Windows.Forms.ComboBox();
            this.cbxTeacherAssignTask = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbTeacherAssignTaskStudent = new System.Windows.Forms.GroupBox();
            this.lblTeacherAssignTask = new System.Windows.Forms.Label();
            this.lblTeacherAssignGroup = new System.Windows.Forms.Label();
            this.chbxTeacherAssignToAll = new System.Windows.Forms.CheckBox();
            this.gbTeacherAssignTaskStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbxTeacherAssignStudetnList
            // 
            this.chbxTeacherAssignStudetnList.FormattingEnabled = true;
            this.chbxTeacherAssignStudetnList.Location = new System.Drawing.Point(16, 44);
            this.chbxTeacherAssignStudetnList.Margin = new System.Windows.Forms.Padding(4);
            this.chbxTeacherAssignStudetnList.Name = "chbxTeacherAssignStudetnList";
            this.chbxTeacherAssignStudetnList.Size = new System.Drawing.Size(239, 238);
            this.chbxTeacherAssignStudetnList.TabIndex = 0;
            // 
            // btnAssignTaskStudent
            // 
            this.btnAssignTaskStudent.Location = new System.Drawing.Point(172, 96);
            this.btnAssignTaskStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssignTaskStudent.Name = "btnAssignTaskStudent";
            this.btnAssignTaskStudent.Size = new System.Drawing.Size(100, 28);
            this.btnAssignTaskStudent.TabIndex = 1;
            this.btnAssignTaskStudent.Text = "Assign Task";
            this.btnAssignTaskStudent.UseVisualStyleBackColor = true;
            this.btnAssignTaskStudent.Click += new System.EventHandler(this.btnAssignTaskStudent_Click);
            // 
            // cbxTeacherAssignGroup
            // 
            this.cbxTeacherAssignGroup.FormattingEnabled = true;
            this.cbxTeacherAssignGroup.Location = new System.Drawing.Point(172, 36);
            this.cbxTeacherAssignGroup.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTeacherAssignGroup.Name = "cbxTeacherAssignGroup";
            this.cbxTeacherAssignGroup.Size = new System.Drawing.Size(97, 24);
            this.cbxTeacherAssignGroup.TabIndex = 2;
            this.cbxTeacherAssignGroup.SelectedIndexChanged += new System.EventHandler(this.cbxTeacherAssignGroup_SelectedIndexChanged);
            // 
            // cbxTeacherAssignTask
            // 
            this.cbxTeacherAssignTask.FormattingEnabled = true;
            this.cbxTeacherAssignTask.Location = new System.Drawing.Point(109, 64);
            this.cbxTeacherAssignTask.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTeacherAssignTask.Name = "cbxTeacherAssignTask";
            this.cbxTeacherAssignTask.Size = new System.Drawing.Size(160, 24);
            this.cbxTeacherAssignTask.TabIndex = 3;
            // 
            // gbTeacherAssignTaskStudent
            // 
            this.gbTeacherAssignTaskStudent.Controls.Add(this.lblTeacherAssignTask);
            this.gbTeacherAssignTaskStudent.Controls.Add(this.lblTeacherAssignGroup);
            this.gbTeacherAssignTaskStudent.Controls.Add(this.btnAssignTaskStudent);
            this.gbTeacherAssignTaskStudent.Controls.Add(this.cbxTeacherAssignTask);
            this.gbTeacherAssignTaskStudent.Controls.Add(this.cbxTeacherAssignGroup);
            this.gbTeacherAssignTaskStudent.Location = new System.Drawing.Point(276, 133);
            this.gbTeacherAssignTaskStudent.Margin = new System.Windows.Forms.Padding(4);
            this.gbTeacherAssignTaskStudent.Name = "gbTeacherAssignTaskStudent";
            this.gbTeacherAssignTaskStudent.Padding = new System.Windows.Forms.Padding(4);
            this.gbTeacherAssignTaskStudent.Size = new System.Drawing.Size(280, 149);
            this.gbTeacherAssignTaskStudent.TabIndex = 4;
            this.gbTeacherAssignTaskStudent.TabStop = false;
            this.gbTeacherAssignTaskStudent.Text = "Assign Task";
            // 
            // lblTeacherAssignTask
            // 
            this.lblTeacherAssignTask.AutoSize = true;
            this.lblTeacherAssignTask.Location = new System.Drawing.Point(7, 68);
            this.lblTeacherAssignTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeacherAssignTask.Name = "lblTeacherAssignTask";
            this.lblTeacherAssignTask.Size = new System.Drawing.Size(90, 17);
            this.lblTeacherAssignTask.TabIndex = 5;
            this.lblTeacherAssignTask.Text = "Choose task:";
            // 
            // lblTeacherAssignGroup
            // 
            this.lblTeacherAssignGroup.AutoSize = true;
            this.lblTeacherAssignGroup.Location = new System.Drawing.Point(7, 39);
            this.lblTeacherAssignGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeacherAssignGroup.Name = "lblTeacherAssignGroup";
            this.lblTeacherAssignGroup.Size = new System.Drawing.Size(101, 17);
            this.lblTeacherAssignGroup.TabIndex = 4;
            this.lblTeacherAssignGroup.Text = "Choose group:";
            // 
            // chbxTeacherAssignToAll
            // 
            this.chbxTeacherAssignToAll.AutoSize = true;
            this.chbxTeacherAssignToAll.Location = new System.Drawing.Point(19, 16);
            this.chbxTeacherAssignToAll.Name = "chbxTeacherAssignToAll";
            this.chbxTeacherAssignToAll.Size = new System.Drawing.Size(85, 21);
            this.chbxTeacherAssignToAll.TabIndex = 5;
            this.chbxTeacherAssignToAll.Text = "Select All";
            this.chbxTeacherAssignToAll.UseVisualStyleBackColor = true;
            this.chbxTeacherAssignToAll.Click += new System.EventHandler(this.chbxTeacherAssignToAll_Click);
            // 
            // TeacherAssignTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 303);
            this.Controls.Add(this.chbxTeacherAssignToAll);
            this.Controls.Add(this.gbTeacherAssignTaskStudent);
            this.Controls.Add(this.chbxTeacherAssignStudetnList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeacherAssignTask";
            this.Text = "Assign Task";
            this.gbTeacherAssignTaskStudent.ResumeLayout(false);
            this.gbTeacherAssignTaskStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chbxTeacherAssignStudetnList;
        private System.Windows.Forms.Button btnAssignTaskStudent;
        private System.Windows.Forms.ComboBox cbxTeacherAssignGroup;
        private System.Windows.Forms.ComboBox cbxTeacherAssignTask;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbTeacherAssignTaskStudent;
        private System.Windows.Forms.Label lblTeacherAssignGroup;
        private System.Windows.Forms.Label lblTeacherAssignTask;
        private System.Windows.Forms.CheckBox chbxTeacherAssignToAll;
    }
}