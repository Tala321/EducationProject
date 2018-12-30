using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationProject.View.Mentor
{
    public partial class MentorEditInfo : Form
    {
        //Database
        EducationProjectEntities db = new EducationProjectEntities();

        MentorForm mentor = new MentorForm();

        public MentorEditInfo()
        {
            InitializeComponent();
        }

        //Edits Mentor Phone
        private void btnMentorEditConfirm_Click(object sender, EventArgs e)
        {
            foreach (var item in db.Mentors.ToList().Where(t => t.MentorEmail == WelcomeScreen.UserEmail))
            {
                if (tbxMentorPhoneChange.Text.Length < 10)
                {
                    if (tbxMentorPhoneChange.Text.All(Char.IsDigit))
                    {
                        item.MentorPhone = tbxMentorPhoneChange.Text;
                        db.SaveChanges();
                        tbxMentorPhoneChange.Text = "";
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
        private void MentorEditInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            MentorForm.btnMentorInfoEdit.Enabled = true;
        }
    }
}
