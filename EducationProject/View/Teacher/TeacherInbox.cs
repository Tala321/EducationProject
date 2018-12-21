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
    public partial class TeacherInbox : Form
    {
        EducationProjectEntities db = new EducationProjectEntities();

        public TeacherInbox()
        {
            InitializeComponent();

            //Shows inbox messages
            dgwTeacherInboxMessages.DataSource = db.Messages.Where(e => e.MessageTo == WelcomeScreen.UserEmail).ToList();
        }
        //Show clicked inbox/sent message
        private void dgwTeacherInboxMessages_DoubleClick(object sender, EventArgs e)
        {
            Extensions.ShowMessageInfo(dgwTeacherInboxMessages);
        }
    }
}
