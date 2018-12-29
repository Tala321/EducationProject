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

namespace EducationProject.View.Student
{
    public partial class StudentForm : Form
    {
        //Database
        EducationProjectEntities db = new EducationProjectEntities();


        ////////  //We will use it in more than one methods//  /////////// 


        // Declare dynamic items here , to use when Student enters
        Label lblCurrentStudentId = new Label();
        Label lblCurrentStudentGroup = new Label();
        Label lblCurrentStudentName = new Label();
        Label lblCurrentStudentSurname = new Label();
        Label lblCurrentStudentBirthdate = new Label();
        Label lblCurrentStudentEmail = new Label();
        Label lblCurrentStudentPhone = new Label();
        Label lblCurrentStudentRegistrationDate = new Label();
        Label lblCurrrentStudentPhoto = new Label();
        Label lblStudentCurrentMentorName = new Label();
        Label lblStudentCurrentMentorSurName = new Label();
        Label lblStudentCurrentTeacherName = new Label();
        Label lblStudentCurrentTeacherSurname = new Label();

        //Declares items that we  use not only in this class
        public static Button btnStudentInfoEdit = new Button();
        public static Button btnStudentWriteMessageMentor = new Button();
        public static Button btnStudentWriteMessageToTeacher = new Button();
        public static Label lblStudentCurrentTeacherEmail = new Label();
        public static Label lblStudentCurrentMentorEmail = new Label();
        public static DataGridView dgwStudentAllGroupmates = new DataGridView();
        public static DataGridView dgwStudentAllTasks = new DataGridView();

        // Declares items that we use in this class but  more than in one method
        DataGridView dgwStudentLibrary = new DataGridView();
        RichTextBox bioBx = new RichTextBox();
        PictureBox pbxStudentImage = new PictureBox();

        //Holds info
        public static int GroupId;
        int mentorId;
        int teacherId;
        int SourceId;
        int StudentId;

        //Colors
        private new Color ForeColor = Color.FromName("ControlText");
        private Color ForeColorStatic = Color.FromName("ControlDarkDark");


        // Form size types
        int StandartHeight = 342;
        int ShortHeight = 215;

        int panelNormalWidth = 552;
        int formNormalWidth = 593;

        public StudentForm()
        {
            InitializeComponent();
            PanelStudent.Controls.Clear();
            PanelStudent.Font = new Font(PanelStudent.Font.FontFamily, 10);
        }


        ////////  //"Personal Info"-option//  /////////// 

        //Creates all items on the panel
        private void personalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //prevent opening more than one form
            btnStudentInfoEdit.Click -= new EventHandler(this.EditStudentPersonalInfo);
            //

            PanelStudent.Controls.Clear();
            Height = 400;
            PanelStudent.Width = panelNormalWidth;
            PanelStudent.Height = 330;


            //set Static items

            Label lblStudentId = new Label();
            lblStudentId.Left = 14;
            lblStudentId.Top = 44;
            lblStudentId.ForeColor = ForeColorStatic;
            lblStudentId.Text = "Id:";

            Label lblStudentGroup = new Label();
            lblStudentGroup.Left = 14;
            lblStudentGroup.Top = 67;
            lblStudentGroup.ForeColor = ForeColorStatic;
            lblStudentGroup.Text = "Group:";

            Label lblStudentName = new Label();
            lblStudentName.Left = 14;
            lblStudentName.Top = 90;
            lblStudentName.ForeColor = ForeColorStatic;
            lblStudentName.Text = "Name:";

            Label lblStudentSurname = new Label();
            lblStudentSurname.Left = 14;
            lblStudentSurname.Top = 113;
            lblStudentSurname.ForeColor = ForeColorStatic;
            lblStudentSurname.Text = "Surname:";

            Label lblStudentBirthdate = new Label();
            lblStudentBirthdate.Left = 14;
            lblStudentBirthdate.Top = 136;
            lblStudentBirthdate.ForeColor = ForeColorStatic;
            lblStudentBirthdate.Text = "Birthdate:";

            Label lblStudentEmail = new Label();
            lblStudentEmail.Left = 14;
            lblStudentEmail.Top = 159;
            lblStudentEmail.ForeColor = ForeColorStatic;
            lblStudentEmail.Text = "Email:";

            Label lblStudentPhone = new Label();
            lblStudentPhone.Left = 14;
            lblStudentPhone.Top = 182;
            lblStudentPhone.ForeColor = ForeColorStatic;
            lblStudentPhone.Text = "Phone:";

            Label lblStudentRegistrationDate = new Label();
            lblStudentRegistrationDate.Left = 14;
            lblStudentRegistrationDate.Top = 205;
            lblStudentRegistrationDate.ForeColor = ForeColorStatic;
            lblStudentRegistrationDate.Text = "Registration Date:";

            Label lblStudentBio = new Label();
            lblStudentBio.Left = 14;
            lblStudentBio.Top = 228;
            lblStudentBio.ForeColor = ForeColorStatic;
            lblStudentBio.Text = "Bio:";

            Label lblStudentPhoto = new Label();
            lblStudentPhoto.Left = 280;
            lblStudentPhoto.Top = 47;
            lblStudentPhoto.ForeColor = ForeColorStatic;
            lblStudentPhoto.Text = "Photo:";
            lblStudentPhoto.AutoSize = true;
            //
            btnStudentInfoEdit.Left = 439;
            btnStudentInfoEdit.Top = 230;
            btnStudentInfoEdit.Text = "Edit";
            btnStudentInfoEdit.Height = 25;
            btnStudentInfoEdit.Width = 80;


            //set dynamic items          

            lblCurrentStudentId.Left = 140;
            lblCurrentStudentId.Top = 44;
            lblCurrentStudentId.ForeColor = ForeColor;
            //
            lblCurrentStudentGroup.Left = 140;
            lblCurrentStudentGroup.Top = 67;
            lblCurrentStudentGroup.ForeColor = ForeColor;
            //
            lblCurrentStudentName.Left = 140;
            lblCurrentStudentName.Top = 90;
            lblCurrentStudentName.ForeColor = ForeColor;
            lblCurrentStudentName.AutoSize = true;
            //
            lblCurrentStudentSurname.Left = 140;
            lblCurrentStudentSurname.Top = 113;
            lblCurrentStudentSurname.ForeColor = ForeColor;
            //
            lblCurrentStudentBirthdate.Left = 140;
            lblCurrentStudentBirthdate.Top = 136;
            lblCurrentStudentBirthdate.ForeColor = ForeColor;
            //
            lblCurrentStudentEmail.Left = 140;
            lblCurrentStudentEmail.Top = 159;
            lblCurrentStudentEmail.ForeColor = ForeColor;
            lblCurrentStudentEmail.AutoSize = true;
            //
            lblCurrentStudentPhone.Left = 140;
            lblCurrentStudentPhone.Top = 182;
            lblCurrentStudentPhone.ForeColor = ForeColor;
            //
            lblCurrentStudentRegistrationDate.Left = 140;
            lblCurrentStudentRegistrationDate.Top = 205;
            lblCurrentStudentRegistrationDate.ForeColor = ForeColor;
            //
            bioBx.Top = 232;
            bioBx.Left = 140;
            bioBx.Width = 175;
            bioBx.Height = 96;
            bioBx.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            bioBx.BorderStyle = BorderStyle.None;
            bioBx.BackColor = Color.FromName("Control");
            bioBx.ReadOnly = true;
            //
            pbxStudentImage.Left = 368;
            pbxStudentImage.Top = 47;
            pbxStudentImage.Width = 149;
            pbxStudentImage.Height = 172;
            pbxStudentImage.SizeMode = PictureBoxSizeMode.StretchImage;


            //add click eventHandler to the btn-"Edit"
            btnStudentInfoEdit.Click += new EventHandler(this.EditStudentPersonalInfo);

            //adding static items

            PanelStudent.Controls.Add(lblStudentId);
            PanelStudent.Controls.Add(lblStudentGroup);
            PanelStudent.Controls.Add(lblStudentName);
            PanelStudent.Controls.Add(lblStudentSurname);
            PanelStudent.Controls.Add(lblStudentBirthdate);
            PanelStudent.Controls.Add(lblStudentEmail);
            PanelStudent.Controls.Add(lblStudentPhone);
            PanelStudent.Controls.Add(lblStudentRegistrationDate);
            PanelStudent.Controls.Add(lblStudentBio);
            PanelStudent.Controls.Add(btnStudentInfoEdit);
            PanelStudent.Controls.Add(lblStudentPhoto);

            //dynamic items
            PanelStudent.Controls.Add(lblCurrentStudentId);
            PanelStudent.Controls.Add(lblCurrentStudentGroup);
            PanelStudent.Controls.Add(lblCurrentStudentName);
            PanelStudent.Controls.Add(lblCurrentStudentSurname);
            PanelStudent.Controls.Add(lblCurrentStudentBirthdate);
            PanelStudent.Controls.Add(lblCurrentStudentEmail);
            PanelStudent.Controls.Add(lblCurrentStudentPhone);
            PanelStudent.Controls.Add(lblCurrentStudentRegistrationDate);
            PanelStudent.Controls.Add(bioBx);
            PanelStudent.Controls.Add(pbxStudentImage);
            PanelStudent.Controls.Add(btnStudentInfoEdit);


        }

        //Fills all info  of current entered student
        public void FillStudentInfo(string _email)
        {
            foreach (var item in db.Students.ToList().Where(t => t.StudentEmail == _email))
            {
                //We use it to show student task
                StudentId = item.StudentId;
                //
                string rootPath = Directory.GetCurrentDirectory();
                string PhotoLocation = Path.Combine("StudentsPhotos", item.StudentPhoto);
                string FullPath = Path.Combine(rootPath, PhotoLocation);

                foreach (var item1 in db.Groups.ToList())
                {
                    if (item1.GroupId == item.GroupId)
                    {
                        GroupId = item.GroupId;
                        lblCurrentStudentGroup.Text = item1.GroupName.ToString();
                    }
                }

                lblCurrentStudentId.Text = item.StudentId.ToString();
                lblCurrentStudentName.Text = item.StudentName.ToString();
                lblCurrentStudentSurname.Text = item.StudentSurname.ToString();
                lblCurrentStudentBirthdate.Text = item.StudentBirthDate.ToString();
                lblCurrentStudentEmail.Text = item.StudentEmail.ToString();
                lblCurrentStudentPhone.Text = item.StudentPhone.ToString();
                lblCurrentStudentRegistrationDate.Text = item.StudentRegistrationDate.ToString();
                bioBx.Text = item.StudentBio.ToString();
                pbxStudentImage.Image = Image.FromFile(FullPath);
            }
        }

        //Edit personal info
        private void EditStudentPersonalInfo(object sender, EventArgs e)
        {
            StudentEditInfo EditStudentInfo = new StudentEditInfo();
            EditStudentInfo.Show();
            btnStudentInfoEdit.Enabled = false;
        }


        ////////  //"Show Task"-option//  ///////////  

        //Creates all items on the panel
        private void showTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Prevents opening more than 1 form
            dgwStudentAllTasks.DoubleClick -= ShowTaskInfo;
            //
            PanelStudent.Controls.Clear();
            Height = StandartHeight;
            Width = formNormalWidth;

            //set items 

            dgwStudentAllTasks.Top = 3;
            dgwStudentAllTasks.Left = 3;
            dgwStudentAllTasks.Width = 543;
            dgwStudentAllTasks.Height = 137;
            dgwStudentAllTasks.DataSource = db.AssignTasks.Where(x => x.StudentId == StudentId).ToList();
            dgwStudentAllTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwStudentAllTasks.ReadOnly = true;

            Button btnStudentTaskExport = new Button();
            btnStudentTaskExport.Top = 183;
            btnStudentTaskExport.Left = 426;
            btnStudentTaskExport.Height = 25;
            btnStudentTaskExport.Text = "Export Transcipt";
            btnStudentTaskExport.Width = 120;

            //Events 
            dgwStudentAllTasks.DoubleClick += ShowTaskInfo;

            //add items
            PanelStudent.Controls.Add(dgwStudentAllTasks);
            PanelStudent.Controls.Add(btnStudentTaskExport);
        }

        //Shows clicked task info
        private void ShowTaskInfo(object sender, EventArgs e)
        {
            dgwStudentAllTasks.Enabled = false;
            Extensions.ShowTaskInfo(Convert.ToInt32(dgwStudentAllTasks.CurrentRow.Cells[1].Value));
        }



        ////////  //"Teacher Info"-option//  ///////////  

        //Creates all items on the panel
        private void teacherInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //prevents opening more than one form
            btnStudentWriteMessageToTeacher.Click -= new EventHandler(this.WritePrivateMessageToTeacher);
            //

            PanelStudent.Controls.Clear();
            Height = ShortHeight;
            Width = formNormalWidth;

            //set static items

            Label lblStudentTeacherName = new Label();
            lblStudentTeacherName.Left = 14;
            lblStudentTeacherName.Top = 44;
            lblStudentTeacherName.ForeColor = ForeColorStatic;
            lblStudentTeacherName.Text = "Name:";

            Label lblStudentTeacherSurname = new Label();
            lblStudentTeacherSurname.Left = 14;
            lblStudentTeacherSurname.Top = 67;
            lblStudentTeacherSurname.ForeColor = ForeColorStatic;
            lblStudentTeacherSurname.Text = "Surname:";

            Label lblStudentTeacherEmail = new Label();
            lblStudentTeacherEmail.Left = 14;
            lblStudentTeacherEmail.Top = 90;
            lblStudentTeacherEmail.ForeColor = ForeColorStatic;
            lblStudentTeacherEmail.Text = "Email:";

            btnStudentWriteMessageToTeacher.Left = 459;
            btnStudentWriteMessageToTeacher.Top = 84;
            btnStudentWriteMessageToTeacher.Height = 25;
            btnStudentWriteMessageToTeacher.Text = "Message";

            //add click eventHandler to the btn-"Message" to write to the Teacher
            btnStudentWriteMessageToTeacher.Click += new EventHandler(this.WritePrivateMessageToTeacher);
            ShowsTeacherInfo();


            //set dynamic items


            lblStudentCurrentTeacherName.Left = 110;
            lblStudentCurrentTeacherName.Top = 44;
            lblStudentCurrentTeacherName.ForeColor = ForeColor;

            lblStudentCurrentTeacherSurname.Left = 110;
            lblStudentCurrentTeacherSurname.Top = 67;
            lblStudentCurrentTeacherSurname.ForeColor = ForeColor;

            lblStudentCurrentTeacherEmail.Left = 110;
            lblStudentCurrentTeacherEmail.Top = 90;
            lblStudentCurrentTeacherEmail.AutoSize = true;

            lblStudentCurrentTeacherEmail.ForeColor = ForeColor;

            //adding static items
            PanelStudent.Controls.Add(lblStudentTeacherName);
            PanelStudent.Controls.Add(lblStudentTeacherSurname);
            PanelStudent.Controls.Add(lblStudentTeacherEmail);
            PanelStudent.Controls.Add(btnStudentWriteMessageToTeacher);

            //adding dynamic items
            PanelStudent.Controls.Add(lblStudentCurrentTeacherName);
            PanelStudent.Controls.Add(lblStudentCurrentTeacherSurname);
            PanelStudent.Controls.Add(lblStudentCurrentTeacherEmail);
        }

        //Shows Teacher Info
        private void ShowsTeacherInfo()
        {
            foreach (var item in db.Groups.ToList())
            {
                if (item.GroupName == lblCurrentStudentGroup.Text)
                {
                    teacherId = item.TeacherId;
                    foreach (var item1 in db.Teachers.ToList())
                    {
                        if (item1.TeacherId == teacherId)
                        {
                            lblStudentCurrentTeacherName.Text = item1.TeacherName;
                            lblStudentCurrentTeacherSurname.Text = item1.TeacherSurname;
                            lblStudentCurrentTeacherEmail.Text = item1.TeacherEmail;
                        }
                    }
                }
            }
        }

        //shows new Form to write to the Teacher
        private void WritePrivateMessageToTeacher(object sender, EventArgs e)
        {
            ShowsTeacherInfo();
            MessageToTeacher messageToTeacher = new MessageToTeacher();
            messageToTeacher.Show();
            StudentForm.btnStudentWriteMessageToTeacher.Enabled = false;
        }



        ////////  //"Mentor Info"-option//  ///////////  

        // Creates all items on the panel
        private void mentorInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //prevents opening more than one form
            btnStudentWriteMessageMentor.Click -= new EventHandler(this.WritePrivateMessageToMentor);
            //
            PanelStudent.Controls.Clear();
            Height = ShortHeight;
            Width = formNormalWidth;

            //set static data

            Label lblStudentMentorName = new Label();
            lblStudentMentorName.Left = 14;
            lblStudentMentorName.Top = 44;
            lblStudentMentorName.ForeColor = ForeColorStatic;
            lblStudentMentorName.Text = "Name:";

            Label lblStudentMentorSurname = new Label();
            lblStudentMentorSurname.Left = 14;
            lblStudentMentorSurname.Top = 67;
            lblStudentMentorSurname.ForeColor = ForeColorStatic;
            lblStudentMentorSurname.Text = "Surname:";

            Label lblStudentMentorEmail = new Label();
            lblStudentMentorEmail.Left = 14;
            lblStudentMentorEmail.Top = 90;
            lblStudentMentorEmail.ForeColor = ForeColorStatic;
            lblStudentMentorEmail.Text = "Email:";

            btnStudentWriteMessageMentor.Left = 459;
            btnStudentWriteMessageMentor.Top = 84;
            btnStudentWriteMessageMentor.Height = 25;
            btnStudentWriteMessageMentor.Text = "Message";

            //Events
            btnStudentWriteMessageMentor.Click += new EventHandler(this.WritePrivateMessageToMentor);
            ShowMentorInfo();

            //set dynamic data

            lblStudentCurrentMentorName.Left = 110;
            lblStudentCurrentMentorName.Top = 44;
            lblStudentCurrentMentorName.ForeColor = ForeColor;

            lblStudentCurrentMentorSurName.Left = 110;
            lblStudentCurrentMentorSurName.Top = 67;
            lblStudentCurrentMentorSurName.ForeColor = ForeColor;

            lblStudentCurrentMentorEmail.Left = 110;
            lblStudentCurrentMentorEmail.Top = 90;

            lblStudentCurrentMentorEmail.ForeColor = ForeColor;
            lblStudentCurrentMentorEmail.AutoSize = true;

            //adding static data
            PanelStudent.Controls.Add(lblStudentMentorName);
            PanelStudent.Controls.Add(lblStudentMentorSurname);
            PanelStudent.Controls.Add(lblStudentMentorEmail);
            PanelStudent.Controls.Add(btnStudentWriteMessageMentor);

            //adding dynamic data
            PanelStudent.Controls.Add(lblStudentCurrentMentorName);
            PanelStudent.Controls.Add(lblStudentCurrentMentorSurName);
            PanelStudent.Controls.Add(lblStudentCurrentMentorEmail);
        }

        //Shows mentor info
        private void ShowMentorInfo()
        {
            foreach (var item in db.Groups.ToList())
            {
                if (item.GroupName == lblCurrentStudentGroup.Text)
                {
                    mentorId = item.MentorId;
                    foreach (var item1 in db.Mentors.ToList())
                    {
                        if (item1.MentorId == mentorId)
                        {
                            lblStudentCurrentMentorName.Text = item1.MentorName;
                            lblStudentCurrentMentorSurName.Text = item1.MentorSurname;
                            lblStudentCurrentMentorEmail.Text = item1.MentorEmail;
                        }
                    }
                }
            }
        }

        //shows new Form to write to the Mentor
        private void WritePrivateMessageToMentor(object sender, EventArgs e)
        {
            ShowMentorInfo();
            MessageToMentor messageToMentor = new MessageToMentor();
            messageToMentor.Show();
            StudentForm.btnStudentWriteMessageMentor.Enabled = false;
        }

        //shows new Form to write to a Groupmate
        private void toGroupmateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentMessageToGroupmate messageToGroupmate = new StudentMessageToGroupmate();
            messageToGroupmate.Show();
        }


        ////////  //"Groupmates"-option//  ///////////  


        // Creates all items on the panel
        private void groupmatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //prevent opening 2 or more forms
            dgwStudentAllGroupmates.Click -= ShowGroupmateInfo;
            //

            PanelStudent.Controls.Clear();
            PanelStudent.Width = 847;
            Width = 889;
            Height = StandartHeight;

            //set items
            dgwStudentAllGroupmates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwStudentAllGroupmates.Top = 3;
            dgwStudentAllGroupmates.Left = 4;
            dgwStudentAllGroupmates.Width = 842;
            dgwStudentAllGroupmates.Height = 257;
            dgwStudentAllGroupmates.DataSource = db.Students.Where(x => x.GroupId == GroupId && x.StudentEmail != WelcomeScreen.UserEmail).ToList();

            //Events
            dgwStudentAllGroupmates.Click += ShowGroupmateInfo;

            //add items
            PanelStudent.Controls.Add(dgwStudentAllGroupmates);
        }


        // Shows clicked Groupmate info
        private void ShowGroupmateInfo(object sender, EventArgs e)
        {
            dgwStudentAllGroupmates.Enabled = false;

            GroupmateInfo GroupmateInfo = new GroupmateInfo();

            var Birthdate = Convert.ToDateTime(dgwStudentAllGroupmates.CurrentRow.Cells[4].Value);
            var RegDate = Convert.ToDateTime(dgwStudentAllGroupmates.CurrentRow.Cells[7].Value);

            GroupmateInfo.ShowClickedGroupmateInfo(
              Convert.ToInt32(dgwStudentAllGroupmates.CurrentRow.Cells[0].Value),
              Convert.ToInt32(dgwStudentAllGroupmates.CurrentRow.Cells[1].Value),
              dgwStudentAllGroupmates.CurrentRow.Cells[2].Value.ToString(),
              dgwStudentAllGroupmates.CurrentRow.Cells[3].Value.ToString(),
              Birthdate.ToShortDateString().ToString(),
              dgwStudentAllGroupmates.CurrentRow.Cells[5].Value.ToString(),
              dgwStudentAllGroupmates.CurrentRow.Cells[6].Value.ToString(),
              RegDate.ToShortDateString().ToString(),
              dgwStudentAllGroupmates.CurrentRow.Cells[8].Value.ToString(),
              dgwStudentAllGroupmates.CurrentRow.Cells[9].Value.ToString()
              );

            GroupmateInfo.Show();
        }



        ////////  //"Library"-option//  ///////////  


        // Creates all items on the panel
        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelStudent.Controls.Clear();
            Height = StandartHeight;
            Width = formNormalWidth;

            //set items
            dgwStudentLibrary.Top = 3;
            dgwStudentLibrary.Left = 3;
            dgwStudentLibrary.Width = 542;
            dgwStudentLibrary.Height = 137;
            dgwStudentLibrary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwStudentLibrary.Font = new Font("Microsoft Sans Serif", Convert.ToInt32(8.25));
            dgwStudentLibrary.DataSource = db.Libraries.ToList();
            dgwStudentLibrary.AllowUserToAddRows = false;
            dgwStudentLibrary.AllowUserToDeleteRows = false;
            dgwStudentLibrary.ReadOnly = true;

            //Download  library button
            Button btnStudentLibraryDownLoad = new Button();
            btnStudentLibraryDownLoad.Top = 183;
            btnStudentLibraryDownLoad.Left = 426;
            btnStudentLibraryDownLoad.Height = 25;
            btnStudentLibraryDownLoad.Width = 80;
            btnStudentLibraryDownLoad.Text = "Download";
            btnStudentLibraryDownLoad.Width = 120;

            //Events
            dgwStudentLibrary.Click += GetSourceId;
            btnStudentLibraryDownLoad.Click += DownloadPdf;

            //add items
            PanelStudent.Controls.Add(dgwStudentLibrary);
            PanelStudent.Controls.Add(btnStudentLibraryDownLoad);
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
            SourceId = Convert.ToInt32(dgwStudentLibrary.CurrentRow.Cells[0].Value);
        }

        //Shows sent messages
        private void sentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentSent StudentSent = new StudentSent();
            StudentSent.Show();
        }

        //Shows Inbox messages
        private void inboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentInbox StudentInbox = new StudentInbox();
            StudentInbox.Show();
        }
    }
}
