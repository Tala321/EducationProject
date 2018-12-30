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

namespace EducationProject.View.Teacher
{
    public partial class TeacherStudentInfo : Form
    {

        EducationProjectEntities db = new EducationProjectEntities();

        //Declares to hold group name
        string GroupName;

        public TeacherStudentInfo()
        {
            InitializeComponent();
        }

        //Shows  student info
        public void ShowClickedStudentInfo(int _Id, int _GroupId, string _name, string _Surname, string _BirthDate, string _Email, string _Phone, string _RegDate, string _Photo, string _Bio)
        {
            //Gets all paths
            string rootPath = Directory.GetCurrentDirectory();
            string PhotoLocation = Path.Combine("StudentsPhotos", _Photo);
            string FullPath = Path.Combine(rootPath, PhotoLocation);

            //Gets the Group name 
            foreach (var item in db.Groups.ToList())
            {
                if (item.GroupId == _GroupId)
                {
                    GroupName = item.GroupName;
                }
            }

            //Sets the rest info about Student
            lblTeacherCurrentStudentId.Text = _Id.ToString();
            lblTeacherCurrentStudentGroupId.Text = GroupName.ToString();
            lblTeacherCurrentStudentName.Text = _name;
            lblTeacherCurrentStudentSurname.Text = _Surname;
            lblTeacherCurrentStudentBithDate.Text = _BirthDate.ToString();
            lblTeacherCurrentStudentEmail.Text = _Email;
            lblTeacherCurrentStudentPhone.Text = _Phone;
            lblTeacherCurrentStudentRegDate.Text = _RegDate;
            rchbxCurrentStudentBio.Text = _Bio;
            pbxCurrentStudentPhoto.Image = Image.FromFile(FullPath);
        }

        //Enables button after closing
        private void TeacherStudentInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            TeacherForm.dgwTeacherGroups.Enabled = true;
        }
    }
}
