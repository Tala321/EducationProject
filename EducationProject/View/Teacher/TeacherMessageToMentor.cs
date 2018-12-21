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
        public TeacherMessageToMentor()
        {
            InitializeComponent();
        }

        //Enables  write to  mentor btn
        private void TeacherMessageToMentor_FormClosed(object sender, FormClosedEventArgs e)
        {
            TeacherForm.btnTeacherWriteMessageMentor.Enabled = true;
        }
    }
}
