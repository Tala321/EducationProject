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
    public partial class MentorSent : Form
    {
        EducationProjectEntities db = new EducationProjectEntities();

        public MentorSent()
        {
            InitializeComponent();
            //Shows inbox messages
            dgwMentorSentMessages.DataSource = db.Messages.Where(e => e.MessageFrom == WelcomeScreen.UserEmail).ToList();
        }

        //Show clicked inbox/sent message
        private void dgwMentorSentMessages_Click(object sender, EventArgs e)
        {
           Extensions.ShowMessageInfo(dgwMentorSentMessages);
        }
    }
}
