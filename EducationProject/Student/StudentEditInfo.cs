using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationProject.View.Student
{
    public partial class StudentEditInfo : Form
    {
        //Database
        EducationProjectEntities db = new EducationProjectEntities();

        StudentForm student = new StudentForm();

        public StudentEditInfo()
        {
            InitializeComponent();
        }

        //Edits Teacher Phone
        private void btnStudentEditConfirm_Click(object sender, EventArgs e)
        {
            foreach (var item in db.Students.ToList().Where(t => t.StudentEmail == WelcomeScreen.UserEmail))
            {
                if (tbxStudentPhoneChange.Text.Length < 10)
                {
                    if (tbxStudentPhoneChange.Text.All(Char.IsDigit))
                    {
                        item.StudentPhone = tbxStudentPhoneChange.Text;
                        db.SaveChanges();
                        tbxStudentPhoneChange.Text = "";
                        MessageBox.Show("Successfully saved to the database");
                        MessageBox.Show("The changes will be applied after reopening the app");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number");
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("The limit of number leght has been reached");
                }
            }
        }

        //Enables btn after closing
        private void StudentEditInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            StudentForm.btnStudentInfoEdit.Enabled = true;
        }
    }
}
