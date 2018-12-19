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
    public partial class TeacherEditInfo : Form
    {
        //Database
        EducationProjectEntities db = new EducationProjectEntities();

        public TeacherEditInfo()
        {
            InitializeComponent();
        }

        //Edits Teacher Phone
        private void btnTeacherEditConfirm_Click(object sender, EventArgs e)
        {
            foreach (var item in db.Teachers.ToList().Where(t => t.TeacherEmail == WelcomeScreen.UserEmail))
            {
                if (tbxTeacherPhoneChange.Text.All(Char.IsDigit))
                {
                    TeacherForm teacher = new TeacherForm();
                    item.TeacherPhone = tbxTeacherPhoneChange.Text;
                    db.SaveChanges();
                    tbxTeacherPhoneChange.Text = "";
                    break;
                }
                else
                {
                    MessageBox.Show("Please enter a valid number");
                    break;
                }
            }
        }
    }
}
