using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace EducationProject.View.Teacher
{
    public partial class TeacherAddToLibrary : Form
    {
        //DateBase
        EducationProjectEntities db = new EducationProjectEntities();

        //holds info when adding to Library table
        string sourceName;
        bool BitType;

        public TeacherAddToLibrary()
        {
            InitializeComponent();
            ChoosePdfFromSource();
        }

        //Show our pdf sources in a combo box(aim:refresh)
        private void ChoosePdfFromSource()
        {
            foreach (var item in db.PdfSources.ToList())
            {
                cbxTeacherAddSourcePdf.Items.Add(item.PdfSourceName);
            }
        }

        private void TeacherAddToLibrary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'educationProjectDataSet2.Library' table. You can move, or remove it, as needed.
            this.libraryTableAdapter1.Fill(this.educationProjectDataSet2.Library);
            // TODO: This line of code loads data into the 'educationProjectDataSet1.PdfSources' table. You can move, or remove it, as needed.
            this.pdfSourcesTableAdapter.Fill(this.educationProjectDataSet1.PdfSources);

        }

        //add info to dataBase
        private void btnTeacherAddSource_Click(object sender, EventArgs e)
        {
            if (db.Libraries.All(t => t.LibraryItemSource != cbxTeacherAddSourcePdf.Text))
            {
                //check which kind of the resource we chosed
                if (chbxTeacherLibraryAddPdf.Checked)
                {
                    sourceName = cbxTeacherAddSourcePdf.Text;
                    BitType = true;
                }
                else
                {
                    sourceName = tbxTeacherAddSourceUrl.Text;
                    BitType = false;
                }

                //set and add to dataBase
                Library source = new Library()
                {
                    LibraryItemName = tbxTeacherAddSourceName.Text,
                    LibraryItemSource = sourceName,
                    LibraryItemType = BitType
                };

                db.Libraries.Add(source);
                db.SaveChanges();
                dgwAddLibrarySourceList.DataSource = db.Libraries.ToList();
                SetDefaultFields();
            }
            else
            {
                MessageBox.Show("This name exist in the database");
            }
        }

        //select  type of adding resource to the dataBase (pdf or url) with checkBoxes
        private void ChooseSourceType(object sender, EventArgs e)
        {
            if (chbxTeacherLibraryAddPdf.Checked)
            {
                tbxTeacherAddSourceUrl.Enabled = false;
                cbxTeacherAddSourcePdf.Enabled = true;
                btnTeacherAddPdf.Enabled = true;
            }
            else
            {
                tbxTeacherAddSourceUrl.Enabled = true;
                cbxTeacherAddSourcePdf.Enabled = false;
                btnTeacherAddPdf.Enabled = false;
            }
        }

        //download a new pdf file to database for future using
        private void btnTeacherAddPdf_Click(object sender, EventArgs e)
        {
            Extensions.AddPdfFile();

            //refresh info on the form
            cbxTeacherAddSourcePdf.Items.Clear();
            ChoosePdfFromSource();
        }

        //to set default fields values after adding a source
        private void SetDefaultFields()
        {
            tbxTeacherAddSourceName.Text = "";
            tbxTeacherAddSourceUrl.Text = "";
            tbxTeacherAddSourceUrl.Enabled = true;
            chbxTeacherLibraryAddPdf.CheckState = CheckState.Unchecked;
            cbxTeacherAddSourcePdf.Enabled = false;
            btnTeacherAddPdf.Enabled = false;
        }
    }
}
