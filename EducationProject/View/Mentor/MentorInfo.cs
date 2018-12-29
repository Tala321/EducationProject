using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationProject.View.Mentor
{
    public partial class MentorInfo : Form
    {
        EducationProjectEntities db = new EducationProjectEntities();

        //Declares to hold Package name
        string PackageName;

        public MentorInfo()
        {
            InitializeComponent();
        }

        //Shows clicked Colleague info
        public void ShowClickedMentorInfo(int _Id, int _PackageId, string _name, string _Surname, string _Email, string _Phone, string _Bio, string _Photo)
        {
            //Gets all paths
            string rootPath = Directory.GetCurrentDirectory();
            string PhotoLocation = Path.Combine("MentorsPhotos", _Photo);
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
            lblCurrentMentorColId.Text = _Id.ToString();
            lblMentorColPackage.Text = PackageName;
            lblCurrentMentorColName.Text = _name;
            lblCurrentMentorColSurname.Text = _Surname;
            lblCurrentMentorColEmail.Text = _Email;
            lblCurrentMentorColPhone.Text = _Phone;
            rchbxCurrentMentorColBio.Text = _Bio;

            pbxCurrentMentorColPhoto.Image = Image.FromFile(FullPath);
        }

        //Enables button after closing the form
        private void MentorInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            MentorForm.dgwMentorsList.Enabled = true;
        }
    }
}
