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
    public partial class StudentInbox : Form
    {
        EducationProjectEntities db = new EducationProjectEntities();

        public StudentInbox()
        {
            InitializeComponent();
            //Shows inbox messages
            dgwStudentInboxMessages.DataSource = db.Messages.Where(e => e.MessageTo == WelcomeScreen.UserEmail).ToList();
        }

        //Show clicked inbox message
        private void dgwStudentInboxMessages_DoubleClick(object sender, EventArgs e)
        {
            Extensions.ShowMessageInfo(dgwStudentInboxMessages);
        }
    }
}
