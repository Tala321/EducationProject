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
    public partial class TeacherMessageToColleague : Form
    {
        public TeacherMessageToColleague()
        {
            InitializeComponent();
            Extensions.FillWithColleaguesEmails(cbxTeacherMessageToCollegue);
        }

        //Sends message to the Colleague
        private void btnTeacherSendToCoolegue_Click(object sender, EventArgs e)
        {
            if (Extensions.CheckFields(tbxTeacherMessageBoxCollegue, tbxTeacherToMentorTitle, cbxTeacherMessageToCollegue))
            {
                Extensions.SendMessage(cbxTeacherMessageToCollegue.Text, tbxTeacherToMentorTitle.Text, tbxTeacherMessageBoxCollegue.Text);
                Extensions.ClearFields(tbxTeacherMessageBoxCollegue, tbxTeacherToMentorTitle, cbxTeacherMessageToCollegue);
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }           
        }
    }
}
