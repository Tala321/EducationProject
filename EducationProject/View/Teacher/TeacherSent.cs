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
    public partial class TeacherSent : Form
    {
        EducationProjectEntities db = new EducationProjectEntities();

        public TeacherSent()
        {
            InitializeComponent();

            //Shows sent messages
            dgwTeacherSentMessages.DataSource = db.Messages.Where(e => e.MessageFrom == WelcomeScreen.UserEmail).ToList();

        }

        //Show clicked inbox/sent message
        private void dgwTeacherSentMessages_DoubleClick(object sender, EventArgs e)
        {
            Extensions.ShowMessageInfo(dgwTeacherSentMessages);
        }
    }
}
