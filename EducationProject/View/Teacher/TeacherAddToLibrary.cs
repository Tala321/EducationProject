using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EducationProject.View.Mentor;



namespace EducationProject.View.Teacher
{
    public partial class TeacherAddToLibrary : Form
    {
        //DateBase
        EducationProjectEntities db = new EducationProjectEntities();

        //Holds info when adding to the Library table
        string sourceName;
        bool BitType;
        //

        public TeacherAddToLibrary()
        {
            InitializeComponent();
            ChoosePdfFromSource();
        }

        //Shows our pdf sources in a combo box( aim: refresh)
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

        //Adds info to the database
        private void btnTeacherAddSource_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                if (cbxTeacherAddSourcePdf.Enabled == true && db.Libraries.All(t => t.LibraryItemSource != cbxTeacherAddSourcePdf.Text) || cbxTeacherAddSourcePdf.Enabled == false && db.Libraries.All(t => t.LibraryItemSource != tbxTeacherAddSourceUrl.Text))
                {
                    //Checks which kind of the resource we chosed
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

                    //Sets and adds to the dataBase
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
                    MessageBox.Show("This name is exist in the database");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        //Selects a type of added resource to the dataBase (pdf or url) with checkBoxes
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

        //Downloads a new pdf file to the database for the future using
        private void btnTeacherAddPdf_Click(object sender, EventArgs e)
        {
            Extensions.AddPdfFile();

            //Refreshes info on the form
            cbxTeacherAddSourcePdf.Items.Clear();
            ChoosePdfFromSource();
        }

        //Sets default fields' values after adding a source
        private void SetDefaultFields()
        {
            tbxTeacherAddSourceName.Text = "";
            tbxTeacherAddSourceUrl.Text = "";
            tbxTeacherAddSourceUrl.Enabled = true;
            chbxTeacherLibraryAddPdf.CheckState = CheckState.Unchecked;
            cbxTeacherAddSourcePdf.Enabled = false;
            btnTeacherAddPdf.Enabled = false;
        }

        //Enables add button after closing
        private void TeacherAddToLibrary_FormClosed(object sender, FormClosedEventArgs e)
        {
            TeacherForm.btnTeacherLibraryAdd.Enabled = true;
            MentorForm.btnMentorLibraryAdd.Enabled = true;
        }

        //Checks if all fields filled in
        private bool CheckFields()
        {
            if (cbxTeacherAddSourcePdf.Enabled == false)
            {
                if (tbxTeacherAddSourceName.Text == "" || tbxTeacherAddSourceUrl.Text == "")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (tbxTeacherAddSourceName.Text == "" || cbxTeacherAddSourcePdf.Text == "")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
