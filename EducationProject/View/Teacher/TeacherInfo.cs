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
    public partial class TeacherInfo : Form
    {
        EducationProjectEntities db = new EducationProjectEntities();

        //Declares to hold Package name
        string PackageName;

        public TeacherInfo()
        {
            InitializeComponent();

        }

        //Shows clicked Colleague info
        public void ShowClickedColleagueInfo(int _Id, int _PackageId, string _name, string _Surname, string _Email, string _Phone, string _Bio, string _Photo)
        {
            //Gets all paths
            string rootPath = Directory.GetCurrentDirectory();
            string PhotoLocation = Path.Combine("TeacherPhotos", _Photo);
            string FullPath = Path.Combine(rootPath, PhotoLocation);

            //Gets the package 
            foreach (var item in db.Packages.ToList())
            {
                if (item.PackageId == _PackageId)
                {
                    PackageName = item.PackageName;
                }
            }

            //Sets the rest info about teacher
            lblCurrentColleagueId.Text = _Id.ToString();
            lblCurrentColleaguePackage.Text = PackageName;
            lblCurrentColleagueName.Text = _name;
            lblCurrentColleagueSurname.Text = _Surname;
            lblCurrentColleagueEmail.Text = _Email;
            lblCurrentColleaguePhone.Text = _Phone;
            rchbxCurrentColleagueBio.Text = _Bio;

            pbxCurrentColleaguePhoto.Image = Image.FromFile(FullPath);
        }
    }
}
