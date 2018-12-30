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
    public partial class MessageToMentor : Form
    {
        public MessageToMentor()
        {
            InitializeComponent();
            ShowMentorEmail();
        }

        //Shows and sets  mentor email
        private void ShowMentorEmail()
        {
            lblMentorEmail.Text = StudentForm.lblStudentCurrentMentorEmail.Text;
        }

        //Sends message to the mentor
        private void btnSendToMentor_Click(object sender, EventArgs e)
        {
            if (tbxMessageBoxMentor.Text == "" || tbxStudentToMentorTitle.Text == "" )
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                Extensions.SendMessage(lblMentorEmail.Text, tbxStudentToMentorTitle.Text, tbxMessageBoxMentor.Text);
                tbxMessageBoxMentor.Text = null;
                tbxStudentToMentorTitle.Text = null;
            }
        }

        //Enables button  write to  mentor after closing the form
        private void MessageToMentor_FormClosed(object sender, FormClosedEventArgs e)
        {
            StudentForm.btnStudentWriteMessageMentor.Enabled = true;
        }
    }
}
