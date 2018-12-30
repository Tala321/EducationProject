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
using EducationProject.View.Student;
using EducationProject.View.Teacher;

namespace EducationProject.View.Mentor
{
    public partial class MentorForm : Form
    {
        EducationProjectEntities db = new EducationProjectEntities();
        ////////  //We will use it in more than one methods//  /////////// 


        // Declares items that we use in this class but  more than in one method
        Label lblCurrentMentorId = new Label();
        Label lblCurrentMentorProgram = new Label();
        Label lblCurrentMentorName = new Label();
        Label lblCurrentMentorSurname = new Label();
        Label lblCurrentMentorEmail = new Label();
        Label lblCurrentMentorPhone = new Label();
        Label lblCurrrentMentorPhoto = new Label();
        RichTextBox bioBx = new RichTextBox();
        PictureBox pbxMentorImage = new PictureBox();   
        DataGridView dgwMentorLibrary = new DataGridView();
        Button btnMentorLibraryDelete = new Button();
        Button btnMentorLibraryDownload = new Button();



        //Declares items that we  use not only in this class
        public static Button btnMentorInfoEdit = new Button();
        public static Button btnMentorLibraryAdd = new Button();
        public static DataGridView dgwMentorTeachersList = new DataGridView();
        public static DataGridView dgwMentorsList = new DataGridView();
        public static DataGridView dgwMentorTasks = new DataGridView();
        public static DataGridView dgwMentorGroup = new DataGridView();


        //Holds info
        public static int GroupId;
        int MentorId;
        int SourceId;

        //Colors
        private new Color ForeColor = Color.FromName("ControlText");
        private Color ForeColorStatic = Color.FromName("ControlDarkDark");

        // Form size types
        int StandartHeight = 342;
        int ShortHeight = 215;

        int panelNormalWidth = 552;
        int formNormalWidth = 593;

        public MentorForm()
        {
            InitializeComponent();
            PanelMentor.Controls.Clear();
            PanelMentor.Font = new Font(PanelMentor.Font.FontFamily, 10);
        }


        ////////  //"Personal Info"-option//  /////////// 

        //Creates all items on the panel
        private void personalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //prevent opening more than one form
            btnMentorInfoEdit.Click -= new EventHandler(this.EditMentorPersonalInfo);
            //
            PanelMentor.Controls.Clear();
            Height = 380;
            Width = formNormalWidth;
            PanelMentor.Width = panelNormalWidth;
            PanelMentor.Height = 300;

            //set Static items

            Label lblMentorId = new Label();
            lblMentorId.Left = 14;
            lblMentorId.Top = 44;
            lblMentorId.ForeColor = ForeColorStatic;
            lblMentorId.Text = "Id:";

            Label lblMentorProgramName = new Label();
            lblMentorProgramName.Left = 14;
            lblMentorProgramName.Top = 67;
            lblMentorProgramName.ForeColor = ForeColorStatic;
            lblMentorProgramName.Text = "Package Id:";

            Label lblMentorName = new Label();
            lblMentorName.Left = 14;
            lblMentorName.Top = 90;
            lblMentorName.ForeColor = ForeColorStatic;
            lblMentorName.Text = "Name:";

            Label lblMentorSurname = new Label();
            lblMentorSurname.Left = 14;
            lblMentorSurname.Top = 113;
            lblMentorSurname.ForeColor = ForeColorStatic;
            lblMentorSurname.Text = "Surname:";

            Label lblMentorEmail = new Label();
            lblMentorEmail.Left = 14;
            lblMentorEmail.Top = 136;
            lblMentorEmail.ForeColor = ForeColorStatic;
            lblMentorEmail.Text = "Email:";

            Label lblMentorPhone = new Label();
            lblMentorPhone.Left = 14;
            lblMentorPhone.Top = 159;
            lblMentorPhone.ForeColor = ForeColorStatic;
            lblMentorPhone.Text = "Phone:";

            Label lblMentorBio = new Label();
            lblMentorBio.Left = 14;
            lblMentorBio.Top = 182;
            lblMentorBio.ForeColor = ForeColorStatic;
            lblMentorBio.Text = "Bio:";

            Label lblMentorPhoto = new Label();
            lblMentorPhoto.Left = 280;
            lblMentorPhoto.Top = 47;
            lblMentorPhoto.ForeColor = ForeColorStatic;
            lblMentorPhoto.Text = "Photo:";
            lblMentorPhoto.AutoSize = true;

            //
            btnMentorInfoEdit.Left = 439;
            btnMentorInfoEdit.Top = 230;
            btnMentorInfoEdit.Text = "Edit";
            btnMentorInfoEdit.Height = 25;
            btnMentorInfoEdit.Width = 80;



            //set dynamic items    

            //
            lblCurrentMentorId.Left = 140;
            lblCurrentMentorId.Top = 44;
            lblCurrentMentorId.ForeColor = ForeColor;
            //
            lblCurrentMentorProgram.Left = 140;
            lblCurrentMentorProgram.Top = 67;
            lblCurrentMentorProgram.ForeColor = ForeColor;
            //
            lblCurrentMentorName.Left = 140;
            lblCurrentMentorName.Top = 90;
            lblCurrentMentorName.ForeColor = ForeColor;
            //
            lblCurrentMentorSurname.Left = 140;
            lblCurrentMentorSurname.Top = 113;
            lblCurrentMentorSurname.ForeColor = ForeColor;
            //
            lblCurrentMentorEmail.Left = 140;
            lblCurrentMentorEmail.Top = 136;
            lblCurrentMentorEmail.ForeColor = ForeColor;
            lblCurrentMentorEmail.AutoSize = true;
            //
            lblCurrentMentorPhone.Left = 140;
            lblCurrentMentorPhone.Top = 159;
            lblCurrentMentorPhone.ForeColor = ForeColor;
            //
            bioBx.Top = 182;
            bioBx.Left = 140;
            bioBx.Width = 175;
            bioBx.Height = 96;
            bioBx.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            bioBx.BorderStyle = BorderStyle.None;
            bioBx.BackColor = Color.FromName("Control");
            bioBx.ReadOnly = true;
            //
            pbxMentorImage.Left = 368;
            pbxMentorImage.Top = 47;
            pbxMentorImage.Width = 149;
            pbxMentorImage.Height = 172;
            pbxMentorImage.SizeMode = PictureBoxSizeMode.StretchImage;



            //add click eventHandler to the btn-"Edit"
            btnMentorInfoEdit.Click += new EventHandler(this.EditMentorPersonalInfo);


            //adding static items

            PanelMentor.Controls.Add(lblMentorId);
            PanelMentor.Controls.Add(lblMentorProgramName);
            PanelMentor.Controls.Add(lblMentorName);
            PanelMentor.Controls.Add(lblMentorSurname);
            PanelMentor.Controls.Add(lblMentorEmail);
            PanelMentor.Controls.Add(lblMentorPhone);
            PanelMentor.Controls.Add(lblMentorBio);
            PanelMentor.Controls.Add(btnMentorInfoEdit);
            PanelMentor.Controls.Add(lblMentorPhoto);


            //adding dynamic items

            PanelMentor.Controls.Add(lblCurrentMentorId);
            PanelMentor.Controls.Add(lblCurrentMentorProgram);
            PanelMentor.Controls.Add(lblCurrentMentorName);
            PanelMentor.Controls.Add(lblCurrentMentorSurname);
            PanelMentor.Controls.Add(lblCurrentMentorEmail);
            PanelMentor.Controls.Add(lblCurrentMentorPhone);
            PanelMentor.Controls.Add(pbxMentorImage);
            PanelMentor.Controls.Add(btnMentorInfoEdit);
            PanelMentor.Controls.Add(bioBx);
        }

        //Fills all info  of current entered student
        public void FillMentorInfo(string _email)
        {
            foreach (var item in db.Mentors.ToList().Where(t => t.MentorEmail == _email))
            {
                //
                MentorId = item.MentorId;
                //
                string rootPath = Directory.GetCurrentDirectory();
                string PhotoLocation = Path.Combine("MentorsPhotos", item.MentorPhoto);
                string FullPath = Path.Combine(rootPath, PhotoLocation);

                foreach (var item1 in db.Groups.ToList())
                {
                    if (item1.MentorId == MentorId)
                    {
                        GroupId = item1.GroupId;
                    }
                }

                lblCurrentMentorId.Text = item.MentorId.ToString();
                lblCurrentMentorName.Text = item.MentorName.ToString();
                lblCurrentMentorProgram.Text = item.PackageId.ToString();
                lblCurrentMentorSurname.Text = item.MentorSurname.ToString();
                lblCurrentMentorEmail.Text = item.MentorEmail.ToString();
                lblCurrentMentorPhone.Text = item.MentorPhone.ToString();
                bioBx.Text = item.MentorBio.ToString();
                pbxMentorImage.Image = Image.FromFile(FullPath);
            }
        }

        //Edit Personal info 
        private void EditMentorPersonalInfo(object sender, EventArgs e)
        {
            MentorEditInfo MentorEditInfo = new MentorEditInfo();
            MentorEditInfo.Show();
            btnMentorInfoEdit.Enabled = false;
        }



        ////////  //"Task"-option//  ///////////  

        //Creates all items on the panel
        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //prevent opening 2 or more forms
            dgwMentorTasks.DoubleClick -= ShowTaskInfo;
            //
            PanelMentor.Controls.Clear();
            Height = StandartHeight;
            Width = formNormalWidth;
            PanelMentor.Width = 847;
            PanelMentor.Height = StandartHeight;

            //set static items
            dgwMentorTasks.Top = 3;
            dgwMentorTasks.Left = 3;
            dgwMentorTasks.Width = 545;
            dgwMentorTasks.Height = 257;
            dgwMentorTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwMentorTasks.ReadOnly = true;
            //
            dgwMentorTasks.DataSource = db.AssignTasks.Where(x => x.GroupId == GroupId).ToList();
            //
            //Events 
            dgwMentorTasks.DoubleClick += ShowTaskInfo;

            //add static data
            PanelMentor.Controls.Add(dgwMentorTasks);
        }

        //Shows clicked task info
        private void ShowTaskInfo(object sender, EventArgs e)
        {
            dgwMentorTasks.Enabled = false;
            Extensions.ShowTaskInfo(Convert.ToInt32(dgwMentorTasks.CurrentRow.Cells[1].Value));

        }


        ////////  //"Group"-option//  ///////////  

        //Creates all items on the panel
        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelMentor.Controls.Clear();

            //prevent opening 2 or more forms
            dgwMentorGroup.Click -= ShowStudentInfo;
            //

            PanelMentor.Width = 855;
            PanelMentor.Height = StandartHeight;
            Width = 895;
            Height = StandartHeight;

            //set static items

            dgwMentorGroup.Top = 3;
            dgwMentorGroup.Left = 3;
            dgwMentorGroup.Width = 855;
            dgwMentorGroup.Height = 257;
            dgwMentorGroup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwMentorGroup.ReadOnly = true;
            //
            dgwMentorGroup.DataSource = db.Students.Where(x => x.GroupId == GroupId).ToList();
            //

            //Events
            dgwMentorGroup.Click += ShowStudentInfo;

            //add static data
            PanelMentor.Controls.Add(dgwMentorGroup);
        }

        //Shows clicked student info
        private void ShowStudentInfo(object sender, EventArgs e)
        {
            GroupmateInfo GroupmateInfo = new GroupmateInfo();
            dgwMentorGroup.Enabled = false;

            var Birthdate = Convert.ToDateTime(dgwMentorGroup.CurrentRow.Cells[4].Value);
            var RegDate = Convert.ToDateTime(dgwMentorGroup.CurrentRow.Cells[7].Value);

            GroupmateInfo.ShowClickedGroupmateInfo(
              Convert.ToInt32(dgwMentorGroup.CurrentRow.Cells[0].Value),
              Convert.ToInt32(dgwMentorGroup.CurrentRow.Cells[1].Value),
              dgwMentorGroup.CurrentRow.Cells[2].Value.ToString(),
              dgwMentorGroup.CurrentRow.Cells[3].Value.ToString(),
              Birthdate.ToShortDateString().ToString(),
              dgwMentorGroup.CurrentRow.Cells[5].Value.ToString(),
              dgwMentorGroup.CurrentRow.Cells[6].Value.ToString(),
              RegDate.ToShortDateString().ToString(),
              dgwMentorGroup.CurrentRow.Cells[8].Value.ToString(),
              dgwMentorGroup.CurrentRow.Cells[9].Value.ToString()
              );

            GroupmateInfo.Show();
        }


        ////////  //"My Messages"-option//  /////////// 

        //Sent messages
        private void sentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MentorSent MentorSent = new MentorSent();
            MentorSent.Show();
        }

        //Inbox messages
        private void inboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MentorInbox MentorInbox = new MentorInbox();
            MentorInbox.Show();
        }

        //Message to Mentor
        private void toMentorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MentorMessageToMentor MessageToMentor = new MentorMessageToMentor();
            MessageToMentor.Show();
        }

        //Message to Teacher
        private void toTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MentorMessageToTeacher MessageToColleague = new MentorMessageToTeacher();
            MessageToColleague.Show();
        }

        //Message to Group
        private void toGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MentorMessageToGroup MessageToGroup = new MentorMessageToGroup();
            MessageToGroup.Show();
        }


        ////////  //"Colleagues"-option//  /////////// 

        //Creates all items on the panel
        private void colleaguesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Prevents oppening second form
            dgwMentorTeachersList.Click -= ShowTeacherInfo;
            dgwMentorsList.Click -= ShowMentorInfo;
            //
            PanelMentor.Controls.Clear();
            //

            PanelMentor.Width = 855;
            PanelMentor.Height = StandartHeight;
            Width = 895;
            Height = StandartHeight;

            //set static items
            dgwMentorTeachersList.Top = 30;
            dgwMentorTeachersList.Left = 0;
            dgwMentorTeachersList.Width = 855;
            dgwMentorTeachersList.Height = 97;
            dgwMentorTeachersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwMentorTeachersList.ReadOnly = true;


            dgwMentorsList.Top = 170;
            dgwMentorsList.Left = 0;
            dgwMentorsList.Width = 855;
            dgwMentorsList.Height = 97;
            dgwMentorsList.ReadOnly = true;
            dgwMentorsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            Label lblMentorTeachersList = new Label();
            lblMentorTeachersList.Left = 3;
            lblMentorTeachersList.Top = 10;
            lblMentorTeachersList.ForeColor = ForeColor;
            lblMentorTeachersList.Text = "Teachers List:";


            Label lblMentorsList = new Label();
            lblMentorsList.Left = 3;
            lblMentorsList.Top = 154;
            lblMentorsList.ForeColor = ForeColor;
            lblMentorsList.Text = "Mentors List:";


            //Shows Mentors
            dgwMentorsList.DataSource = db.Mentors.Where(x=>x.MentorEmail != WelcomeScreen.UserEmail).ToList();
            dgwMentorTeachersList.DataSource = db.Teachers.ToList();

            //Events
            dgwMentorTeachersList.Click += ShowTeacherInfo;
            dgwMentorsList.Click += ShowMentorInfo;

            //add static items
            PanelMentor.Controls.Add(dgwMentorTeachersList);
            PanelMentor.Controls.Add(dgwMentorsList);
            PanelMentor.Controls.Add(lblMentorsList);
            PanelMentor.Controls.Add(lblMentorTeachersList);
        }

        // Shows clicked Teacher info
        private void ShowTeacherInfo(object sender, EventArgs e)
        {
            //
            dgwMentorTeachersList.Enabled = false;
            //
            TeacherInfo ColleagueInfo = new TeacherInfo();
            ColleagueInfo.ShowClickedColleagueInfo(
               Convert.ToInt32(dgwMentorTeachersList.CurrentRow.Cells[0].Value),
              Convert.ToInt32(dgwMentorTeachersList.CurrentRow.Cells[1].Value),
                    dgwMentorTeachersList.CurrentRow.Cells[2].Value.ToString(),
                    dgwMentorTeachersList.CurrentRow.Cells[3].Value.ToString(),
                    dgwMentorTeachersList.CurrentRow.Cells[4].Value.ToString(),
                    dgwMentorTeachersList.CurrentRow.Cells[5].Value.ToString(),
                    dgwMentorTeachersList.CurrentRow.Cells[6].Value.ToString(),
                    dgwMentorTeachersList.CurrentRow.Cells[7].Value.ToString());

            ColleagueInfo.Show();

        }

        // Shows clicked Mentor info
        private void ShowMentorInfo(object sender, EventArgs e)
        {
            //
            dgwMentorsList.Enabled = false;
            //
               MentorInfo MentorInfo = new MentorInfo();
            MentorInfo.ShowClickedMentorInfo(
                Convert.ToInt32(dgwMentorsList.CurrentRow.Cells[0].Value),
              Convert.ToInt32(dgwMentorsList.CurrentRow.Cells[1].Value),
                    dgwMentorsList.CurrentRow.Cells[2].Value.ToString(),
                    dgwMentorsList.CurrentRow.Cells[3].Value.ToString(),
                    dgwMentorsList.CurrentRow.Cells[4].Value.ToString(),
                    dgwMentorsList.CurrentRow.Cells[5].Value.ToString(),
                    dgwMentorsList.CurrentRow.Cells[6].Value.ToString(),
                    dgwMentorsList.CurrentRow.Cells[7].Value.ToString());
            MentorInfo.Show();

        }

        ////////  //"Library"-option//  /////////// 

        //Creates all items on the panel
        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            PanelMentor.Controls.Clear();
            Height = StandartHeight;
            Width = formNormalWidth;
            PanelMentor.Width = 847;
            PanelMentor.Height = StandartHeight;

            //prevets of adding the same function again to theese buttons
            btnMentorLibraryAdd.Click -= AddResource;
            btnMentorLibraryDelete.Click -= DeleteSource;
            dgwMentorLibrary.Click -= GetSourceId;
            btnMentorLibraryDownload.Click -= DownloadPdf;

          

            //set static items

            dgwMentorLibrary.Top = 3;
            dgwMentorLibrary.Left = 3;
            dgwMentorLibrary.Width = 543;
            dgwMentorLibrary.Height = 137;
            dgwMentorLibrary.DataSource = db.Libraries.ToList();
            dgwMentorLibrary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwMentorLibrary.ReadOnly = true;


            btnMentorLibraryAdd.Left = 4;
            btnMentorLibraryAdd.Top = 178;
            btnMentorLibraryAdd.Text = "Add";
            btnMentorLibraryAdd.Height = 25;
            btnMentorLibraryAdd.Width = 80;

 

            btnMentorLibraryDelete.Left = 99;
            btnMentorLibraryDelete.Top = 178;
            btnMentorLibraryDelete.Text = "Delete";
            btnMentorLibraryDelete.Height = 25;
            btnMentorLibraryDelete.Width = 80;

            btnMentorLibraryDownload.Left = 469;
            btnMentorLibraryDownload.Top = 178;
            btnMentorLibraryDownload.Text = "Download";
            btnMentorLibraryDownload.Height = 25;
            btnMentorLibraryDownload.Width = 80;

            //Events
            btnMentorLibraryAdd.Click += AddResource;
            btnMentorLibraryDelete.Click += DeleteSource;
            dgwMentorLibrary.Click += GetSourceId;
            btnMentorLibraryDownload.Click += DownloadPdf;


            //add static items
            PanelMentor.Controls.Add(dgwMentorLibrary);
            PanelMentor.Controls.Add(btnMentorLibraryAdd);
            PanelMentor.Controls.Add(btnMentorLibraryDelete);
            PanelMentor.Controls.Add(btnMentorLibraryDownload);

        }

        //Downloads  a pdf file
        private void DownloadPdf(object sender, EventArgs e)
        {
            foreach (var item in db.Libraries.Where(t => t.LibraryId == SourceId).ToList())
            {
                if (item.LibraryItemType == true)
                {
                    Extensions.DownloadPdf(item.LibraryItemSource);
                }
                else
                {
                    MessageBox.Show("You could download only pdf files");
                }
            }
        }

        //Gets id of a clicked item
        private void GetSourceId(object sender, EventArgs e)
        {
            SourceId = Convert.ToInt32(dgwMentorLibrary.CurrentRow.Cells[0].Value);
        }

        //Deletes a clicked source from the dataBase
        private void DeleteSource(object sender, EventArgs e)
        {
            foreach (var item in db.Libraries.ToList())
            {
                foreach (var item1 in db.PdfSources.ToList())
                {
                    if (item.LibraryId == SourceId)
                    {
                        if (item1.PdfSourceName == item.LibraryItemSource)
                        {
                            db.PdfSources.Remove(item1);
                            db.Libraries.Remove(item);
                            Extensions.DeletePdf(item1.PdfSourceName);
                            db.SaveChanges();
                        }
                    }
                }
            }
            dgwMentorLibrary.DataSource = db.Libraries.ToList();
        }

        //Adds a source to the library
        private void AddResource(object sender, EventArgs e)
        {
            btnMentorLibraryAdd.Enabled = false;
            TeacherAddToLibrary AddSource = new TeacherAddToLibrary();
            AddSource.Show();
            
        }

        //Enables Sign in button
        private void MentorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            WelcomeScreen.btnSignIn.Enabled = true;
        }
    }
}
