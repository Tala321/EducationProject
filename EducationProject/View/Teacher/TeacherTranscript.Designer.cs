namespace EducationProject.View.Teacher
{
    partial class TeacherTranscript
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
            this.components = new System.ComponentModel.Container();
            this.dgwTeacherTranscript = new System.Windows.Forms.DataGridView();
            this.assignTaskIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignTasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationProjectDataSet3 = new EducationProject.EducationProjectDataSet3();
            this.transcriptsBindingSource = new System.Windows.Forms.BindingSource(this.components);
           
            this.assignTasksTableAdapter = new EducationProject.EducationProjectDataSet3TableAdapters.AssignTasksTableAdapter();
            this.tbxTeacherTaskPoint = new System.Windows.Forms.TextBox();
            this.gbxTeacherTaskPoint = new System.Windows.Forms.GroupBox();
            this.lblTeacherTaskPointSecond = new System.Windows.Forms.Label();
            this.btnTeacherTaskPointAdd = new System.Windows.Forms.Button();
            this.lblTeacherTaskPointFirst = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeacherTranscript)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignTasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transcriptsBindingSource)).BeginInit();
            this.gbxTeacherTaskPoint.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwTeacherTranscript
            // 
            this.dgwTeacherTranscript.AllowUserToAddRows = false;
            this.dgwTeacherTranscript.AllowUserToDeleteRows = false;
            this.dgwTeacherTranscript.AutoGenerateColumns = false;
            this.dgwTeacherTranscript.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTeacherTranscript.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTeacherTranscript.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assignTaskIdDataGridViewTextBoxColumn,
            this.taskIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn,
            this.taskPointDataGridViewTextBoxColumn});
            this.dgwTeacherTranscript.DataSource = this.assignTasksBindingSource;
            this.dgwTeacherTranscript.Location = new System.Drawing.Point(12, 13);
            this.dgwTeacherTranscript.Name = "dgwTeacherTranscript";
            this.dgwTeacherTranscript.Size = new System.Drawing.Size(549, 137);
            this.dgwTeacherTranscript.TabIndex = 5;
            this.dgwTeacherTranscript.Click += new System.EventHandler(this.dgwTeacherTranscript_Click);
            // 
            // assignTaskIdDataGridViewTextBoxColumn
            // 
            this.assignTaskIdDataGridViewTextBoxColumn.DataPropertyName = "AssignTaskId";
            this.assignTaskIdDataGridViewTextBoxColumn.HeaderText = "AssignTaskId";
            this.assignTaskIdDataGridViewTextBoxColumn.Name = "assignTaskIdDataGridViewTextBoxColumn";
            this.assignTaskIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taskIdDataGridViewTextBoxColumn
            // 
            this.taskIdDataGridViewTextBoxColumn.DataPropertyName = "TaskId";
            this.taskIdDataGridViewTextBoxColumn.HeaderText = "TaskId";
            this.taskIdDataGridViewTextBoxColumn.Name = "taskIdDataGridViewTextBoxColumn";
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            // 
            // taskPointDataGridViewTextBoxColumn
            // 
            this.taskPointDataGridViewTextBoxColumn.DataPropertyName = "TaskPoint";
            this.taskPointDataGridViewTextBoxColumn.HeaderText = "TaskPoint";
            this.taskPointDataGridViewTextBoxColumn.Name = "taskPointDataGridViewTextBoxColumn";
            // 
            // assignTasksBindingSource
            // 
            this.assignTasksBindingSource.DataMember = "AssignTasks";
            this.assignTasksBindingSource.DataSource = this.educationProjectDataSet3;
            // 
            // educationProjectDataSet3
            // 
            this.educationProjectDataSet3.DataSetName = "EducationProjectDataSet3";
            this.educationProjectDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transcriptsBindingSource
            // 
            this.transcriptsBindingSource.DataMember = "Transcripts";
            // 
            // educationProjectDataSet
            // 
         
            // 
            // transcriptsTableAdapter
            // 
            
            // 
            // assignTasksTableAdapter
            // 
            this.assignTasksTableAdapter.ClearBeforeFill = true;
            // 
            // tbxTeacherTaskPoint
            // 
            this.tbxTeacherTaskPoint.Location = new System.Drawing.Point(123, 63);
            this.tbxTeacherTaskPoint.Name = "tbxTeacherTaskPoint";
            this.tbxTeacherTaskPoint.Size = new System.Drawing.Size(100, 23);
            this.tbxTeacherTaskPoint.TabIndex = 6;
            // 
            // gbxTeacherTaskPoint
            // 
            this.gbxTeacherTaskPoint.Controls.Add(this.lblTeacherTaskPointSecond);
            this.gbxTeacherTaskPoint.Controls.Add(this.btnTeacherTaskPointAdd);
            this.gbxTeacherTaskPoint.Controls.Add(this.lblTeacherTaskPointFirst);
            this.gbxTeacherTaskPoint.Controls.Add(this.tbxTeacherTaskPoint);
            this.gbxTeacherTaskPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTeacherTaskPoint.Location = new System.Drawing.Point(12, 172);
            this.gbxTeacherTaskPoint.Name = "gbxTeacherTaskPoint";
            this.gbxTeacherTaskPoint.Size = new System.Drawing.Size(252, 127);
            this.gbxTeacherTaskPoint.TabIndex = 7;
            this.gbxTeacherTaskPoint.TabStop = false;
            this.gbxTeacherTaskPoint.Text = "Task Point";
            // 
            // lblTeacherTaskPointSecond
            // 
            this.lblTeacherTaskPointSecond.AutoSize = true;
            this.lblTeacherTaskPointSecond.Location = new System.Drawing.Point(6, 69);
            this.lblTeacherTaskPointSecond.Name = "lblTeacherTaskPointSecond";
            this.lblTeacherTaskPointSecond.Size = new System.Drawing.Size(97, 17);
            this.lblTeacherTaskPointSecond.TabIndex = 9;
            this.lblTeacherTaskPointSecond.Text = "2. Enter  point";
            // 
            // btnTeacherTaskPointAdd
            // 
            this.btnTeacherTaskPointAdd.Location = new System.Drawing.Point(143, 92);
            this.btnTeacherTaskPointAdd.Name = "btnTeacherTaskPointAdd";
            this.btnTeacherTaskPointAdd.Size = new System.Drawing.Size(80, 25);
            this.btnTeacherTaskPointAdd.TabIndex = 8;
            this.btnTeacherTaskPointAdd.Text = "Add";
            this.btnTeacherTaskPointAdd.UseVisualStyleBackColor = true;
            this.btnTeacherTaskPointAdd.Click += new System.EventHandler(this.btnTeacherTaskPointAdd_Click);
            // 
            // lblTeacherTaskPointFirst
            // 
            this.lblTeacherTaskPointFirst.AutoSize = true;
            this.lblTeacherTaskPointFirst.Location = new System.Drawing.Point(6, 32);
            this.lblTeacherTaskPointFirst.Name = "lblTeacherTaskPointFirst";
            this.lblTeacherTaskPointFirst.Size = new System.Drawing.Size(115, 17);
            this.lblTeacherTaskPointFirst.TabIndex = 7;
            this.lblTeacherTaskPointFirst.Text = "1. Click on a task";
            // 
            // TeacherTranscript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 303);
            this.Controls.Add(this.gbxTeacherTaskPoint);
            this.Controls.Add(this.dgwTeacherTranscript);
            this.Name = "TeacherTranscript";
            this.Text = "Transcript";
            this.Load += new System.EventHandler(this.TeacherAssignedTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeacherTranscript)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignTasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transcriptsBindingSource)).EndInit();
            this.gbxTeacherTaskPoint.ResumeLayout(false);
            this.gbxTeacherTaskPoint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTeacherTranscript;
        private System.Windows.Forms.BindingSource transcriptsBindingSource;
        private EducationProjectDataSet3 educationProjectDataSet3;
        private System.Windows.Forms.BindingSource assignTasksBindingSource;
        private EducationProjectDataSet3TableAdapters.AssignTasksTableAdapter assignTasksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignTaskIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbxTeacherTaskPoint;
        private System.Windows.Forms.GroupBox gbxTeacherTaskPoint;
        private System.Windows.Forms.Button btnTeacherTaskPointAdd;
        private System.Windows.Forms.Label lblTeacherTaskPointSecond;
        private System.Windows.Forms.Label lblTeacherTaskPointFirst;
    }
}