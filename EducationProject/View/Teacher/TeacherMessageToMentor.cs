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

        //Auto selected Mentor email
        Label lblTeacherMessageToMentorEmail = new Label();
       
        public TeacherMessageToMentor()
        {
            InitializeComponent();
            AutoSelectEmail();
        }

        //Selects mentor email according to from which option you write a message(Mentor info ,My Messages)
        private void AutoSelectEmail()
        {
            if (TeacherForm.cbxTeacherGroupMentor.Text == "")
            {
                this.Controls.Remove(lblTeacherMessageToMentorEmail);
                cbxTeacherMessageToMentor.Show();
                Extensions.FillCbxMentor(cbxTeacherMessageToMentor);
            }
            else
            {
                lblTeacherMessageToMentorEmail.Top = 44;
                lblTeacherMessageToMentorEmail.Left = 88;
                lblTeacherMessageToMentorEmail.AutoSize = true;
                lblTeacherMessageToMentorEmail.Font = new Font(this.Font.FontFamily, 10);
                lblTeacherMessageToMentorEmail.Text = TeacherForm.lblTeacherCurrentMentorEmail.Text;
                cbxTeacherMessageToMentor.Hide();
                this.Controls.Add(lblTeacherMessageToMentorEmail);
            }   
        }

        //Enables button  write to  mentor after closing the form
        private void TeacherMessageToMentor_FormClosed(object sender, FormClosedEventArgs e)
        {
            TeacherForm.btnTeacherWriteMessageMentor.Enabled = true;
        }

        //Sends message to the mentor
        private void btnTeacherSendToMentor_Click(object sender, EventArgs e)
        {
            if (CheckFields(tbxTeacherToMentorTitle, tbxTeacherMessageBoxMentor, cbxTeacherMessageToMentor))
            {

                if (cbxTeacherMessageToMentor.Visible == true)
                {
                    Extensions.SendMessage(cbxTeacherMessageToMentor.Text, tbxTeacherToMentorTitle.Text, tbxTeacherMessageBoxMentor.Text);
                }
                else
                {
                    Extensions.SendMessage(TeacherForm.lblTeacherCurrentMentorEmail.Text, tbxTeacherToMentorTitle.Text, tbxTeacherMessageBoxMentor.Text);

                }

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
        public bool CheckFields(TextBox _title, TextBox _body, ComboBox _cbx)
        {
          
            if (TeacherForm.cbxTeacherGroupMentor.Text == "")
            {
                if (_title.Text == "" || _body.Text == "" || _cbx.Text == "")
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
                if (_title.Text == "" || _body.Text == "")
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
