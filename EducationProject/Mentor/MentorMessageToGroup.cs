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
    public partial class MentorMessageToGroup : Form
    {
        public MentorMessageToGroup()
        {
            InitializeComponent();
            Extensions.FillWithStudentsEmails(cbxMentorMessageToGroup);
        }

        //Sends message to the Group
        private void btnMentorSendToGroup_Click(object sender, EventArgs e)
        {
            if (Extensions.CheckFields(tbxMentorMessageBoxGroup, tbxMentorToGroupTitle, cbxMentorMessageToGroup))
            {
                Extensions.SendMessage(cbxMentorMessageToGroup.Text, tbxMentorToGroupTitle.Text, tbxMentorMessageBoxGroup.Text);
                Extensions.ClearFields(tbxMentorMessageBoxGroup, tbxMentorToGroupTitle, cbxMentorMessageToGroup);
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }
    }
}
