using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EducationProject.View.Teacher;
using EducationProject.View.Student;
using EducationProject.View.Mentor;

namespace EducationProject.View
{
    public partial class WelcomeScreen : Form
    {
        //Database
        EducationProjectEntities db = new EducationProjectEntities();

        //Gets user type
        int UserType;
       public static string UserEmail;

        public WelcomeScreen()
        {
            InitializeComponent();
            FillCbxWithUserType();
        }

        //Fill combobox with usertype names
        private void FillCbxWithUserType()
        {
            foreach (var item in db.UserTypes.ToList())
            {
                cbxLoginUserType.Items.Add(item.UserTypeName);
            }
        }

        //Checks user info
        private void CheckUserInfo(object sender, EventArgs e)
        {
            if (cbxLoginUserType.Text == "Teacher")
            {
                UserType = 1;
            }
            else if (cbxLoginUserType.Text == "Student")
            {
                UserType = 2;
            }
            else if (cbxLoginUserType.Text == "Mentor")
            {
                UserType = 3;
            }

            if (db.Logins.ToList().Any(t => t.LoginEmail == tbxLoginEmail.Text && t.LoginPassword == tbxLoginPassword.Text && t.UserTypeId == UserType))
            {
                if (UserType == 1)
                {
                    TeacherForm teacher = new TeacherForm();             
                    teacher.Show();
                    UserEmail = tbxLoginEmail.Text;
                    teacher.FillTeacherInfo(tbxLoginEmail.Text);
                }
                else if (UserType == 2)
                {
                    StudentForm student = new StudentForm();
                    student.Show();
                }
                else if (UserType == 3)
                {
                    MentorForm mentor = new MentorForm();                    
                    mentor.Show();
                }
            }
            else
            {
                MessageBox.Show("Wrong data was provided.");
            }
        }
    }
}
