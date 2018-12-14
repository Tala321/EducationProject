namespace EducationProject.View.Teacher
{
    partial class TeacherAddToLibrary
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
            this.gbTeacherAddSource = new System.Windows.Forms.GroupBox();
            this.chbxTeacherLibraryAddPdf = new System.Windows.Forms.CheckBox();
            this.btnTeacherAddPdf = new System.Windows.Forms.Button();
            this.lblTeacherAddSourcePdf = new System.Windows.Forms.Label();
            this.btnTeacherAddSource = new System.Windows.Forms.Button();
            this.cbxTeacherAddSourcePdf = new System.Windows.Forms.ComboBox();
            this.tbxTeacherAddSourceUrl = new System.Windows.Forms.TextBox();
            this.lblTeacherAddSourceUrl = new System.Windows.Forms.Label();
            this.tbxTeacherAddSourceName = new System.Windows.Forms.TextBox();
            this.lblTeacherAddSourceName = new System.Windows.Forms.Label();
            this.pdfSourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationProjectDataSet1 = new EducationProject.EducationProjectDataSet1();
            this.pdfSourcesTableAdapter = new EducationProject.EducationProjectDataSet1TableAdapters.PdfSourcesTableAdapter();
            this.libraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationProjectDataSet = new EducationProject.EducationProjectDataSet();
            this.libraryTableAdapter = new EducationProject.EducationProjectDataSetTableAdapters.LibraryTableAdapter();
            this.dgwAddLibrarySourceList = new System.Windows.Forms.DataGridView();
            this.libraryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryItemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryItemSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryItemTypeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.educationProjectDataSet2 = new EducationProject.EducationProjectDataSet2();
            this.libraryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryTableAdapter1 = new EducationProject.EducationProjectDataSet2TableAdapters.LibraryTableAdapter();
            this.gbTeacherAddSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdfSourcesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAddLibrarySourceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTeacherAddSource
            // 
            this.gbTeacherAddSource.Controls.Add(this.chbxTeacherLibraryAddPdf);
            this.gbTeacherAddSource.Controls.Add(this.btnTeacherAddPdf);
            this.gbTeacherAddSource.Controls.Add(this.lblTeacherAddSourcePdf);
            this.gbTeacherAddSource.Controls.Add(this.btnTeacherAddSource);
            this.gbTeacherAddSource.Controls.Add(this.cbxTeacherAddSourcePdf);
            this.gbTeacherAddSource.Controls.Add(this.tbxTeacherAddSourceUrl);
            this.gbTeacherAddSource.Controls.Add(this.lblTeacherAddSourceUrl);
            this.gbTeacherAddSource.Controls.Add(this.tbxTeacherAddSourceName);
            this.gbTeacherAddSource.Controls.Add(this.lblTeacherAddSourceName);
            this.gbTeacherAddSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTeacherAddSource.Location = new System.Drawing.Point(12, 190);
            this.gbTeacherAddSource.Name = "gbTeacherAddSource";
            this.gbTeacherAddSource.Size = new System.Drawing.Size(339, 165);
            this.gbTeacherAddSource.TabIndex = 3;
            this.gbTeacherAddSource.TabStop = false;
            this.gbTeacherAddSource.Text = "Add Source";
            // 
            // chbxTeacherLibraryAddPdf
            // 
            this.chbxTeacherLibraryAddPdf.AutoSize = true;
            this.chbxTeacherLibraryAddPdf.Location = new System.Drawing.Point(18, 88);
            this.chbxTeacherLibraryAddPdf.Name = "chbxTeacherLibraryAddPdf";
            this.chbxTeacherLibraryAddPdf.Size = new System.Drawing.Size(15, 14);
            this.chbxTeacherLibraryAddPdf.TabIndex = 19;
            this.chbxTeacherLibraryAddPdf.UseVisualStyleBackColor = true;
            this.chbxTeacherLibraryAddPdf.Click += new System.EventHandler(this.ChooseSourceType);
            // 
            // btnTeacherAddPdf
            // 
            this.btnTeacherAddPdf.Enabled = false;
            this.btnTeacherAddPdf.Location = new System.Drawing.Point(232, 83);
            this.btnTeacherAddPdf.Name = "btnTeacherAddPdf";
            this.btnTeacherAddPdf.Size = new System.Drawing.Size(80, 25);
            this.btnTeacherAddPdf.TabIndex = 17;
            this.btnTeacherAddPdf.Text = "Add Pdf";
            this.btnTeacherAddPdf.UseVisualStyleBackColor = true;
            this.btnTeacherAddPdf.Click += new System.EventHandler(this.btnTeacherAddPdf_Click);
            // 
            // lblTeacherAddSourcePdf
            // 
            this.lblTeacherAddSourcePdf.AutoSize = true;
            this.lblTeacherAddSourcePdf.Location = new System.Drawing.Point(36, 86);
            this.lblTeacherAddSourcePdf.Name = "lblTeacherAddSourcePdf";
            this.lblTeacherAddSourcePdf.Size = new System.Drawing.Size(33, 17);
            this.lblTeacherAddSourcePdf.TabIndex = 16;
            this.lblTeacherAddSourcePdf.Text = "Pdf:";
            // 
            // btnTeacherAddSource
            // 
            this.btnTeacherAddSource.Location = new System.Drawing.Point(94, 118);
            this.btnTeacherAddSource.Name = "btnTeacherAddSource";
            this.btnTeacherAddSource.Size = new System.Drawing.Size(100, 25);
            this.btnTeacherAddSource.TabIndex = 14;
            this.btnTeacherAddSource.Text = "Add Source";
            this.btnTeacherAddSource.UseVisualStyleBackColor = true;
            this.btnTeacherAddSource.Click += new System.EventHandler(this.btnTeacherAddSource_Click);
            // 
            // cbxTeacherAddSourcePdf
            // 
            this.cbxTeacherAddSourcePdf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTeacherAddSourcePdf.Enabled = false;
            this.cbxTeacherAddSourcePdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxTeacherAddSourcePdf.FormattingEnabled = true;
            this.cbxTeacherAddSourcePdf.Location = new System.Drawing.Point(94, 83);
            this.cbxTeacherAddSourcePdf.Name = "cbxTeacherAddSourcePdf";
            this.cbxTeacherAddSourcePdf.Size = new System.Drawing.Size(132, 24);
            this.cbxTeacherAddSourcePdf.TabIndex = 15;
            // 
            // tbxTeacherAddSourceUrl
            // 
            this.tbxTeacherAddSourceUrl.Location = new System.Drawing.Point(94, 55);
            this.tbxTeacherAddSourceUrl.Name = "tbxTeacherAddSourceUrl";
            this.tbxTeacherAddSourceUrl.Size = new System.Drawing.Size(100, 23);
            this.tbxTeacherAddSourceUrl.TabIndex = 3;
            // 
            // lblTeacherAddSourceUrl
            // 
            this.lblTeacherAddSourceUrl.AutoSize = true;
            this.lblTeacherAddSourceUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherAddSourceUrl.Location = new System.Drawing.Point(39, 57);
            this.lblTeacherAddSourceUrl.Name = "lblTeacherAddSourceUrl";
            this.lblTeacherAddSourceUrl.Size = new System.Drawing.Size(30, 17);
            this.lblTeacherAddSourceUrl.TabIndex = 2;
            this.lblTeacherAddSourceUrl.Text = "Url:";
            // 
            // tbxTeacherAddSourceName
            // 
            this.tbxTeacherAddSourceName.Location = new System.Drawing.Point(94, 28);
            this.tbxTeacherAddSourceName.Name = "tbxTeacherAddSourceName";
            this.tbxTeacherAddSourceName.Size = new System.Drawing.Size(100, 23);
            this.tbxTeacherAddSourceName.TabIndex = 1;
            // 
            // lblTeacherAddSourceName
            // 
            this.lblTeacherAddSourceName.AutoSize = true;
            this.lblTeacherAddSourceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherAddSourceName.Location = new System.Drawing.Point(20, 31);
            this.lblTeacherAddSourceName.Name = "lblTeacherAddSourceName";
            this.lblTeacherAddSourceName.Size = new System.Drawing.Size(49, 17);
            this.lblTeacherAddSourceName.TabIndex = 0;
            this.lblTeacherAddSourceName.Text = "Name:";
            // 
            // pdfSourcesBindingSource
            // 
            this.pdfSourcesBindingSource.DataMember = "PdfSources";
            this.pdfSourcesBindingSource.DataSource = this.educationProjectDataSet1;
            // 
            // educationProjectDataSet1
            // 
            this.educationProjectDataSet1.DataSetName = "EducationProjectDataSet1";
            this.educationProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pdfSourcesTableAdapter
            // 
            this.pdfSourcesTableAdapter.ClearBeforeFill = true;
            // 
            // libraryBindingSource
            // 
            this.libraryBindingSource.DataMember = "Library";
            this.libraryBindingSource.DataSource = this.educationProjectDataSet;
            // 
            // educationProjectDataSet
            // 
            this.educationProjectDataSet.DataSetName = "EducationProjectDataSet";
            this.educationProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryTableAdapter
            // 
            this.libraryTableAdapter.ClearBeforeFill = true;
            // 
            // dgwAddLibrarySourceList
            // 
            this.dgwAddLibrarySourceList.AllowUserToAddRows = false;
            this.dgwAddLibrarySourceList.AllowUserToDeleteRows = false;
            this.dgwAddLibrarySourceList.AutoGenerateColumns = false;
            this.dgwAddLibrarySourceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwAddLibrarySourceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAddLibrarySourceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.libraryIdDataGridViewTextBoxColumn,
            this.libraryItemNameDataGridViewTextBoxColumn,
            this.libraryItemSourceDataGridViewTextBoxColumn,
            this.libraryItemTypeDataGridViewCheckBoxColumn});
            this.dgwAddLibrarySourceList.DataSource = this.libraryBindingSource1;
            this.dgwAddLibrarySourceList.Location = new System.Drawing.Point(12, 12);
            this.dgwAddLibrarySourceList.Name = "dgwAddLibrarySourceList";
            this.dgwAddLibrarySourceList.ReadOnly = true;
            this.dgwAddLibrarySourceList.Size = new System.Drawing.Size(549, 137);
            this.dgwAddLibrarySourceList.TabIndex = 4;
            // 
            // libraryIdDataGridViewTextBoxColumn
            // 
            this.libraryIdDataGridViewTextBoxColumn.DataPropertyName = "LibraryId";
            this.libraryIdDataGridViewTextBoxColumn.HeaderText = "LibraryId";
            this.libraryIdDataGridViewTextBoxColumn.Name = "libraryIdDataGridViewTextBoxColumn";
            this.libraryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libraryItemNameDataGridViewTextBoxColumn
            // 
            this.libraryItemNameDataGridViewTextBoxColumn.DataPropertyName = "LibraryItemName";
            this.libraryItemNameDataGridViewTextBoxColumn.HeaderText = "LibraryItemName";
            this.libraryItemNameDataGridViewTextBoxColumn.Name = "libraryItemNameDataGridViewTextBoxColumn";
            this.libraryItemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libraryItemSourceDataGridViewTextBoxColumn
            // 
            this.libraryItemSourceDataGridViewTextBoxColumn.DataPropertyName = "LibraryItemSource";
            this.libraryItemSourceDataGridViewTextBoxColumn.HeaderText = "LibraryItemSource";
            this.libraryItemSourceDataGridViewTextBoxColumn.Name = "libraryItemSourceDataGridViewTextBoxColumn";
            this.libraryItemSourceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libraryItemTypeDataGridViewCheckBoxColumn
            // 
            this.libraryItemTypeDataGridViewCheckBoxColumn.DataPropertyName = "LibraryItemType";
            this.libraryItemTypeDataGridViewCheckBoxColumn.HeaderText = "LibraryItemType";
            this.libraryItemTypeDataGridViewCheckBoxColumn.Name = "libraryItemTypeDataGridViewCheckBoxColumn";
            this.libraryItemTypeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // educationProjectDataSet2
            // 
            this.educationProjectDataSet2.DataSetName = "EducationProjectDataSet2";
            this.educationProjectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryBindingSource1
            // 
            this.libraryBindingSource1.DataMember = "Library";
            this.libraryBindingSource1.DataSource = this.educationProjectDataSet2;
            // 
            // libraryTableAdapter1
            // 
            this.libraryTableAdapter1.ClearBeforeFill = true;
            // 
            // TeacherAddToLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 367);
            this.Controls.Add(this.dgwAddLibrarySourceList);
            this.Controls.Add(this.gbTeacherAddSource);
            this.Name = "TeacherAddToLibrary";
            this.Text = "Add Source";
            this.Load += new System.EventHandler(this.TeacherAddToLibrary_Load);
            this.gbTeacherAddSource.ResumeLayout(false);
            this.gbTeacherAddSource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdfSourcesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAddLibrarySourceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationProjectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTeacherAddSource;
        private System.Windows.Forms.Button btnTeacherAddSource;
        private System.Windows.Forms.TextBox tbxTeacherAddSourceUrl;
        private System.Windows.Forms.Label lblTeacherAddSourceUrl;
        private System.Windows.Forms.TextBox tbxTeacherAddSourceName;
        private System.Windows.Forms.Label lblTeacherAddSourceName;
        private EducationProjectDataSet educationProjectDataSet;
        private System.Windows.Forms.BindingSource libraryBindingSource;
        private EducationProjectDataSetTableAdapters.LibraryTableAdapter libraryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn libraryItemUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTeacherAddSourcePdf;
        private System.Windows.Forms.ComboBox cbxTeacherAddSourcePdf;
        private System.Windows.Forms.CheckBox chbxTeacherLibraryAddPdf;
        private System.Windows.Forms.Button btnTeacherAddPdf;
        private EducationProjectDataSet1 educationProjectDataSet1;
        private System.Windows.Forms.BindingSource pdfSourcesBindingSource;
        private EducationProjectDataSet1TableAdapters.PdfSourcesTableAdapter pdfSourcesTableAdapter;
        private System.Windows.Forms.DataGridView dgwAddLibrarySourceList;
        private System.Windows.Forms.DataGridViewTextBoxColumn libraryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libraryItemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libraryItemSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn libraryItemTypeDataGridViewCheckBoxColumn;
        private EducationProjectDataSet2 educationProjectDataSet2;
        private System.Windows.Forms.BindingSource libraryBindingSource1;
        private EducationProjectDataSet2TableAdapters.LibraryTableAdapter libraryTableAdapter1;
    }
}