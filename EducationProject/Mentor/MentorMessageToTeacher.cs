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
    public partial class MentorMessageToTeacher : Form
    {
        public MentorMessageToTeacher()
        {
            InitializeComponent();
            Extensions.FillWithTeachersEmails(cbxMentorMessageToTeacher);
        }

        //Sends message to the Group
        private void btnMentorSendToTeacher_Click(object sender, EventArgs e)
        {
            if (Extensions.CheckFields(tbxMentorMessageBoxTeacher, tbxMentorToTeacherTitle, cbxMentorMessageToTeacher))
            {
                Extensions.SendMessage(cbxMentorMessageToTeacher.Text, tbxMentorToTeacherTitle.Text, tbxMentorMessageBoxTeacher.Text);
                Extensions.ClearFields(tbxMentorMessageBoxTeacher, tbxMentorToTeacherTitle, cbxMentorMessageToTeacher);
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }
    }
}
