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
    public partial class MentorInbox : Form
    {
        EducationProjectEntities db = new EducationProjectEntities();

        public MentorInbox()
        {
            InitializeComponent();
            //Shows inbox messages
            dgwMentorInboxMessages.DataSource = db.Messages.Where(e => e.MessageTo == WelcomeScreen.UserEmail).ToList();
        }

        //Show clicked inbox message
        private void dgwMentorInboxMessages_Click(object sender, EventArgs e)
        {
            Extensions.ShowMessageInfo(dgwMentorInboxMessages);
        }
    }
}
