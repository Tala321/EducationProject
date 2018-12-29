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
    public partial class MentorMessageToMentor : Form
    {
        public MentorMessageToMentor()
        {
            InitializeComponent();
            Extensions.FillWithMentorsEmails(cbxMentorMessageToMentor);
        }

        //Sends message to the Group
        private void btnMentorSendToColleague_Click(object sender, EventArgs e)
        {
            if (Extensions.CheckFields(tbxMentorMessageBoxColleague, tbxMentorToMentorTitle, cbxMentorMessageToMentor))
            {
                Extensions.SendMessage(cbxMentorMessageToMentor.Text, tbxMentorToMentorTitle.Text, tbxMentorMessageBoxColleague.Text);
                Extensions.ClearFields(tbxMentorMessageBoxColleague, tbxMentorToMentorTitle, cbxMentorMessageToMentor);
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }
    }
}
