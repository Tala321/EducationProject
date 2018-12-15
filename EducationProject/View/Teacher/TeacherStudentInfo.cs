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
        string GroupName;

        public TeacherStudentInfo()
        {
            InitializeComponent();
        }

        //SHow student info
        public void ShowClickedStudentInfo(int _Id, int _GroupId, string _name, string _Surname, string _BirthDate, string _Email, string _Phone, string _RegDate, string _Photo, string _Bio)
        {
            //get all paths
            string rootPath = Directory.GetCurrentDirectory();
            string PhotoLocation = Path.Combine("StudentsPhotos", _Photo);
            string FullPath = Path.Combine(rootPath, PhotoLocation);

            // get the GroupName 
            foreach (var item in db.Groups.ToList())
            {
                if (item.GroupId == _GroupId)
                {
                    GroupName = item.GroupName;
                }
            }

            //set the rest info about Student
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
    }
}
