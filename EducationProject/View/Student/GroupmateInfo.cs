using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EducationProject.View.Student
{
    public partial class GroupmateInfo : Form
    {
        EducationProjectEntities db = new EducationProjectEntities();

        //Declares to hold Group name
        string GroupName;

        public GroupmateInfo()
        {
            InitializeComponent();
        }

        //Shows clicked Groupmate info
        public void ShowClickedGroupmateInfo(int _Id, int _GroupId, string _name, string _Surname, string _birtdate, string _Email, string _Phone, string _Reg, string _Photo , string _Bio)
        {
            //Gets all paths
            string rootPath = Directory.GetCurrentDirectory();
            string PhotoLocation = Path.Combine("StudentsPhotos", _Photo);
            string FullPath = Path.Combine(rootPath, PhotoLocation);

            //Gets the package 
            foreach (var item in db.Groups.ToList())
            {
                if (item.GroupId == _GroupId)
                {
                    GroupName = item.GroupName;
                }
            }

            //Sets the rest info about Groupmate
            lblCurrentGroupmateId.Text = _Id.ToString();
            lblCurrentGroupmateGroup.Text = GroupName;
            lblCurrentGroupmateName.Text = _name;
            lblCurrenGroupmateSurname.Text = _Surname;
            lblCurrentGroupmateBirthdate.Text = _birtdate;
            lblCurrentGroupmateEmail.Text = _Email;
            lblCurrentGroupmatePhone.Text = _Phone;
            lblCurrentGroupmateRegistration.Text = _Reg;
            pbxCurrentGroupmatePhoto.Text = _Photo;
            rchbxCurrentGroupmateBio.Text = _Bio;

            pbxCurrentGroupmatePhoto.Image = Image.FromFile(FullPath);
        }

        //Enables click event  in dgw-groupmatesList after closing this form
        private void GroupmateInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            StudentForm.dgwStudentAllGroupmates.Enabled = true;
        }
    }
}
