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
    public partial class TeacherMessageToMentor : Form
    {
        EducationProjectEntities db = new EducationProjectEntities();

        public TeacherMessageToMentor()
        {
            InitializeComponent();
            //show selected mentor email
            lblTeacherMessageToMentor.Text = TeacherForm.lblTeacherCurrentMentorEmail.Text;
        }

        //Enables  write to  mentor btn
        private void TeacherMessageToMentor_FormClosed(object sender, FormClosedEventArgs e)
        {
            TeacherForm.btnTeacherWriteMessageMentor.Enabled = true;
        }

        //Sends message to the mentor
        private void btnTeacherSendToMentor_Click(object sender, EventArgs e)
        {
            if (CheckFields(tbxTeacherToMentorTitle, tbxTeacherMessageBoxMentor, lblTeacherMessageToMentor))
            {
                
                Extensions.SendMessage(TeacherForm.lblTeacherCurrentMentorEmail.Text, tbxTeacherToMentorTitle.Text, tbxTeacherMessageBoxMentor.Text);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        //Clears fields after sending a message
        private void ClearFields()
        {
            tbxTeacherMessageBoxMentor.Text = null;
            tbxTeacherToMentorTitle.Text = null;
        }

        //Cheks if all fields filled in
        public static bool CheckFields(TextBox _title, TextBox _body, Label _lbl)
        {
            if (_title.Text == "" || _body.Text == "" || _lbl.Text == "Email")
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
