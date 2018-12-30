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
    public partial class TeacherMessageToGroup : Form
    {
        EducationProjectEntities db = new EducationProjectEntities();

        int GroupId;
        string GroupEmail;

        public TeacherMessageToGroup()
        {
            InitializeComponent();
            Extensions.FillCbxGroups(cbxTeacherMessageToGroup);
        }

        //Gets selected group Id
        private void GetSelectedGroupId()
        {
            foreach (var item in db.Groups.ToList())
            {           
                if(cbxTeacherMessageToGroup.Text== item.GroupName)
                {
                    GroupId = item.GroupId;
                    GroupEmail = item.GroupEmail;
                }
            }
        }

        //Gets all students from Selected group 
        private void GetAllStudents()
        {
            foreach (var item in db.Students.Where(x=>x.GroupId==GroupId).ToList())
            {
                Extensions.SendMessage(GroupEmail, tbxTeacherToMentorTitle.Text, tbxTeacherMessageBoxGroup.Text);
            }
        }

        //Sends a message
        private void btnTeacherSendToGroup_Click(object sender, EventArgs e)
        {
            if(Extensions.CheckFields(tbxTeacherToMentorTitle, tbxTeacherMessageBoxGroup, cbxTeacherMessageToGroup))
            {
                GetSelectedGroupId();
                GetAllStudents();
                Extensions.ClearFields(tbxTeacherToMentorTitle, tbxTeacherMessageBoxGroup, cbxTeacherMessageToGroup);
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }

        }
    }
}
