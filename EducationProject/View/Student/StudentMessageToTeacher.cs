using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EducationProject.View.Student;

namespace EducationProject
{
    public partial class MessageToTeacher : Form
    {
        public MessageToTeacher()
        {
            InitializeComponent();
            ShowTeacherEmail();
        }

        //Shows and sets  Teacher email
        private void ShowTeacherEmail()
        {
            lblTeacherEmail.Text = StudentForm.lblStudentCurrentTeacherEmail.Text;
        }

        //Sends message to the mentor
        private void btnSendToTeacher_Click(object sender, EventArgs e)
        {
            if (tbxMessageBoxTeacher.Text == "" || tbxStudentToTeacherTitle.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                Extensions.SendMessage(lblTeacherEmail.Text, tbxStudentToTeacherTitle.Text, tbxMessageBoxTeacher.Text);
                tbxMessageBoxTeacher.Text = null;
                tbxStudentToTeacherTitle.Text = null;
            }
        }

        //Enables button  write to  teacher after closing the form
        private void MessageToTeacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            StudentForm.btnStudentWriteMessageToTeacher.Enabled = true;
        }
    }
}
