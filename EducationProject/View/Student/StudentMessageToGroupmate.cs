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
    public partial class StudentMessageToGroupmate : Form
    {
        public StudentMessageToGroupmate()
        {
            InitializeComponent();
            Extensions.FillWithGroupmatesEmails(cbxStudentMessageToGroupmate);
        }

        //Sends message to the Colleague
        private void btnSendToGroupmate_Click(object sender, EventArgs e)
        {
            if (Extensions.CheckFields(tbxMessageBoxGroupmate, tbxStudentToGroupmateTitle, cbxStudentMessageToGroupmate))
            {
                Extensions.SendMessage(cbxStudentMessageToGroupmate.Text, tbxStudentToGroupmateTitle.Text, tbxMessageBoxGroupmate.Text);
                Extensions.ClearFields(tbxMessageBoxGroupmate, tbxStudentToGroupmateTitle, cbxStudentMessageToGroupmate);
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }
    }
}
