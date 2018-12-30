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
    public partial class StudentSent : Form
    {
        EducationProjectEntities db = new EducationProjectEntities();

        public StudentSent()
        {
            InitializeComponent();
            //Shows inbox messages
            dgwStudentSentMessages.DataSource = db.Messages.Where(e => e.MessageFrom == WelcomeScreen.UserEmail).ToList();
        }

        //Show clicked sent message
        private void dgwStudentSentMessages_DoubleClick(object sender, EventArgs e)
        {          
            Extensions.ShowMessageInfo(dgwStudentSentMessages);
        }
    }
}
