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
    public partial class TeacherForm : Form
    {

        //DataBase
        EducationProjectEntities db = new EducationProjectEntities();


        ////////  //We will use it in more than one methods//  /////////// 

        //declare dataGridView
        DataGridView dgwTeacherLibraryList = new DataGridView();
        DataGridView dgwTeacherGroups = new DataGridView();
        public DataGridView dgwTeacherColleagues = new DataGridView();
        public static DataGridView dgwTeacherAllTasks = new DataGridView();


        // holds source id
        int SourceId;
        int GroupId;
        int mentorId;
        int TaskId;

        // Declare dynamic label here , to use when Teacher enters
        public Label lblCurrentTeacherId = new Label();
        public Label lblCurrentTeacherProgram = new Label();
        public Label lblCurrentTeacherName = new Label();
        public Label lblCurrentTeacherSurname = new Label();
        public Label lblCurrentTeacherEmail = new Label();
        public Label lblCurrentTeacherPhone = new Label();
        public Label lblCurrentTeacherBio = new Label();
        public PictureBox pbxTeacherImage = new PictureBox();
        public RichTextBox bioBx = new RichTextBox();
        public static Button btnTeacherInfoEdit = new Button();
        public static Button btnTeacherAddTask = new Button();
        public static Button btnTeacherDeleteTask = new Button();
        public static Button btnTeacherUpdateTask = new Button();
        public static Button btnTeacherWriteMessageMentor = new Button();
        public static Button btnTeacherLibraryAdd = new Button();


        //Declare comboBox 
        ComboBox cbxTeacherSelectGroups = new ComboBox();
        ComboBox cbxTeacherGroupMentor = new ComboBox();


        //declare labels 
        Label lblTeacherCurrentMentorName = new Label();
        Label lblTeacherCurrentMentorSurName = new Label();
        Label lblTeacherCurrentMentorEmail = new Label();


        //Colors
        private new Color ForeColor = Color.FromName("ControlText");
        private Color ForeColorStatic = Color.FromName("ControlDarkDark");

        // Form size types
        int StandartHeight = 342;
        int ShortHeight = 215;

        int panelNormalWidth = 552;
        int formNormalWidth = 593;

        public TeacherForm()
        {
            InitializeComponent();
            PanelTeacher.Controls.Clear();
            PanelTeacher.Font = new Font(PanelTeacher.Font.FontFamily, 10);

        }

        ////////  //"Personal Info"-option//  /////////// 

        //Creates all items on the panel
        private void personalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //prevent opening more than one form
            btnTeacherInfoEdit.Click -= new EventHandler(this.EditTeacherPersonalInfo);
            //

            PanelTeacher.Controls.Clear();
            Height = 380;
            PanelTeacher.Width = panelNormalWidth;
            PanelTeacher.Height = 290;
            Width = formNormalWidth;

            //set Static items

            Label lblTeacherId = new Label();
            lblTeacherId.Left = 14;
            lblTeacherId.Top = 44; lblTeacherId.ForeColor = ForeColorStatic;
            lblTeacherId.Text = "Id:";

            Label lblTeacherProgramName = new Label();
            lblTeacherProgramName.Left = 14;
            lblTeacherProgramName.Top = 67;
            lblTeacherProgramName.ForeColor = ForeColorStatic;
            lblTeacherProgramName.Text = "Program name:";

            Label lblTeacherName = new Label();
            lblTeacherName.Left = 14;
            lblTeacherName.Top = 90;
            lblTeacherName.ForeColor = ForeColorStatic;
            lblTeacherName.Text = "Name:";

            Label lblTeacherSurname = new Label();
            lblTeacherSurname.Left = 14;
            lblTeacherSurname.Top = 113;
            lblTeacherSurname.ForeColor = ForeColorStatic;
            lblTeacherSurname.Text = "Surname:";

            Label lblTeacherEmail = new Label();
            lblTeacherEmail.Left = 14;
            lblTeacherEmail.Top = 136;
            lblTeacherEmail.ForeColor = ForeColorStatic;
            lblTeacherEmail.Text = "Email:";

            Label lblTeacherPhone = new Label();
            lblTeacherPhone.Left = 14;
            lblTeacherPhone.Top = 159;
            lblTeacherPhone.ForeColor = ForeColorStatic;
            lblTeacherPhone.Text = "Phone:";


            Label lblTeacherBio = new Label();
            lblTeacherBio.Left = 14;
            lblTeacherBio.Top = 182;
            lblTeacherBio.ForeColor = ForeColorStatic;
            lblTeacherBio.Text = "Bio:";

            Label lblTeacherPhoto = new Label();
            lblTeacherPhoto.Left = 270;
            lblTeacherPhoto.Top = 47;
            lblTeacherPhoto.ForeColor = ForeColorStatic;
            lblTeacherPhoto.AutoSize = true;
            lblTeacherPhoto.Text = "Photo:";
            //
            pbxTeacherImage.Width = 175;
            pbxTeacherImage.Height = 96;

            //
            bioBx.Top = 192;
            bioBx.Left = 140;
            bioBx.Width = 175;
            bioBx.Height = 96;
            bioBx.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            bioBx.BorderStyle = BorderStyle.None;
            bioBx.BackColor = Color.FromName("Control");
            bioBx.ReadOnly = true;



            //set dynamic items          

            lblCurrentTeacherId.Left = 140;
            lblCurrentTeacherId.Top = 44;
            lblCurrentTeacherId.ForeColor = ForeColor;
            //
            lblCurrentTeacherProgram.Left = 140;
            lblCurrentTeacherProgram.Top = 67;
            lblCurrentTeacherProgram.ForeColor = ForeColor;
            //
            lblCurrentTeacherName.Left = 140;
            lblCurrentTeacherName.Top = 90;
            lblCurrentTeacherName.ForeColor = ForeColor;
            //
            lblCurrentTeacherSurname.Left = 140;
            lblCurrentTeacherSurname.Top = 113;
            lblCurrentTeacherSurname.ForeColor = ForeColor;
            //
            lblCurrentTeacherEmail.Left = 140;
            lblCurrentTeacherEmail.Top = 136;
            lblCurrentTeacherEmail.ForeColor = ForeColor;
            lblCurrentTeacherEmail.AutoSize = true;
            //
            lblCurrentTeacherPhone.Left = 140;
            lblCurrentTeacherPhone.Top = 159;
            lblCurrentTeacherPhone.ForeColor = ForeColor;
            //
            lblCurrentTeacherBio.Left = 140;
            lblCurrentTeacherBio.Top = 182;
            lblCurrentTeacherBio.ForeColor = ForeColor;
            //
            pbxTeacherImage.Left = 358;
            pbxTeacherImage.Top = 47;
            pbxTeacherImage.Width = 149;
            pbxTeacherImage.Height = 172;
            pbxTeacherImage.SizeMode = PictureBoxSizeMode.StretchImage;



            btnTeacherInfoEdit.Left = 429;
            btnTeacherInfoEdit.Top = 230;
            btnTeacherInfoEdit.Text = "Edit";
            btnTeacherInfoEdit.Height = 25;
            btnTeacherInfoEdit.Width = 80;

            //add click eventHandler to the btn-"Edit"
            btnTeacherInfoEdit.Click += new EventHandler(this.EditTeacherPersonalInfo);


            //adding static items

            PanelTeacher.Controls.Add(lblTeacherId);
            PanelTeacher.Controls.Add(lblTeacherProgramName);
            PanelTeacher.Controls.Add(lblTeacherName);
            PanelTeacher.Controls.Add(lblTeacherSurname);
            PanelTeacher.Controls.Add(lblTeacherEmail);
            PanelTeacher.Controls.Add(lblTeacherPhone);
            PanelTeacher.Controls.Add(lblTeacherBio);
            PanelTeacher.Controls.Add(btnTeacherInfoEdit);
            PanelTeacher.Controls.Add(lblTeacherPhoto);
            PanelTeacher.Controls.Add(bioBx);


            //adding dynamic items

            PanelTeacher.Controls.Add(lblCurrentTeacherId);
            PanelTeacher.Controls.Add(lblCurrentTeacherProgram);
            PanelTeacher.Controls.Add(lblCurrentTeacherName);
            PanelTeacher.Controls.Add(lblCurrentTeacherSurname);
            PanelTeacher.Controls.Add(lblCurrentTeacherEmail);
            PanelTeacher.Controls.Add(lblCurrentTeacherPhone);
            PanelTeacher.Controls.Add(lblCurrentTeacherBio);
            PanelTeacher.Controls.Add(pbxTeacherImage);
            PanelTeacher.Controls.Add(btnTeacherInfoEdit);

        }

        //Fills all info  of Current entered teacher
        public void FillTeacherInfo(string _email)
        {
            foreach (var item in db.Teachers.ToList().Where(t => t.TeacherEmail == _email))
            {
                string rootPath = Directory.GetCurrentDirectory();
                string PhotoLocation = Path.Combine("TeacherPhotos", item.TeacherPhoto);
                string FullPath = Path.Combine(rootPath, PhotoLocation);

                lblCurrentTeacherId.Text = item.TeacherId.ToString();
                lblCurrentTeacherProgram.Text = item.PackageId.ToString();
                lblCurrentTeacherName.Text = item.TeacherName.ToString();
                lblCurrentTeacherSurname.Text = item.TeacherSurname.ToString();
                lblCurrentTeacherEmail.Text = item.TeacherEmail.ToString();
                lblCurrentTeacherPhone.Text = item.TeacherPhone.ToString();
                bioBx.Text = item.TeacherBio.ToString();

                pbxTeacherImage.Image = Image.FromFile(FullPath);
            }
        }

        //Edits Personal Info
        private void EditTeacherPersonalInfo(object sender, EventArgs e)
        {
            TeacherEditInfo EditStudentInfo = new TeacherEditInfo();
            EditStudentInfo.Show();
            btnTeacherInfoEdit.Enabled = false;
        }


        ////////  //"Task"-option//  ///////////  

        //Creates all items on the panel
        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Prevetns openning more than1 form
            btnTeacherAddTask.Click -= new EventHandler(this.AddTask);
            btnTeacherUpdateTask.Click -= new EventHandler(this.UpdateTask);
            dgwTeacherAllTasks.DoubleClick -= ShowTaskInfo;
            btnTeacherDeleteTask.Click -= DeleteTask;

            PanelTeacher.Controls.Clear();
            Height = 321;
            PanelTeacher.Width = 847;
            Width = 889;

            //set static items

            dgwTeacherAllTasks.Top = 3;
            dgwTeacherAllTasks.Left = 3;
            dgwTeacherAllTasks.Width = 842;
            dgwTeacherAllTasks.Height = 137;

            //
            dgwTeacherAllTasks.DataSource = db.Tasks.ToList();
            dgwTeacherAllTasks.Font = new Font("Microsoft Sans Serif", Convert.ToInt32(8.25));
            dgwTeacherAllTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwTeacherAllTasks.ReadOnly = true;

            //
            btnTeacherAddTask.Left = 270;
            btnTeacherAddTask.Top = 190;
            btnTeacherAddTask.Height = 25;
            btnTeacherAddTask.Width = 80;
            btnTeacherAddTask.Text = "Add Task";
            
           //
            btnTeacherDeleteTask.Left = 360;
            btnTeacherDeleteTask.Top = 190;
            btnTeacherDeleteTask.Height = 25;
            btnTeacherDeleteTask.Width = 98;
            btnTeacherDeleteTask.Text = "Delete Task";
            //
            btnTeacherUpdateTask.Left = 468;
            btnTeacherUpdateTask.Top = 190;
            btnTeacherUpdateTask.Height = 25;
            btnTeacherUpdateTask.Width = 98;
            btnTeacherUpdateTask.Text = "Update Task";

            //Events
            btnTeacherAddTask.Click += new EventHandler(this.AddTask);
            btnTeacherUpdateTask.Click += new EventHandler(this.UpdateTask);
            dgwTeacherAllTasks.DoubleClick += ShowTaskInfo;
            btnTeacherDeleteTask.Click += DeleteTask;


            //add static items
            PanelTeacher.Controls.Add(dgwTeacherAllTasks);
            PanelTeacher.Controls.Add(btnTeacherAddTask);
            PanelTeacher.Controls.Add(btnTeacherDeleteTask);
            PanelTeacher.Controls.Add(btnTeacherUpdateTask);
        }

        //Deletes Task from the dataBase
        private void DeleteTask(object sender, EventArgs e)
        {
            TaskId = Convert.ToInt32(dgwTeacherAllTasks.CurrentRow.Cells[0].Value);
            Extensions.DeleteTask(TaskId);
            dgwTeacherAllTasks.DataSource = db.Tasks.ToList();
        }

        //Shows clicked task info
        private void ShowTaskInfo(object sender, EventArgs e)
        {
            Extensions.ShowTaskInfo(Convert.ToInt32(dgwTeacherAllTasks.CurrentRow.Cells[0].Value));
            dgwTeacherAllTasks.Enabled = false;
        }

        //Adds a task to the tasklist
        private void AddTask(object sender, EventArgs e)
        {
            TeacherAddTask AddTask = new TeacherAddTask();
            AddTask.Show();
            btnTeacherAddTask.Enabled = false;
        }

        //Updates a task from the tasklist
        private void UpdateTask(object sender, EventArgs e)
        {
            TeacherUpdateTask updateTask = new TeacherUpdateTask();
            updateTask.Show();
            btnTeacherUpdateTask.Enabled = false;
        }


        ////////  //"Assign Task"-option//  ///////////  

        //Assigns (a) task(s)  to (a) Student(s)
        private void AssignTaskToStudent(object sender, EventArgs e)
        {
            TeacherAssignTask assignTask = new TeacherAssignTask();
            assignTask.Show();
        }

        //Shows Transcript
        private void ShowEditTranscript(object sender, EventArgs e)
        {
            TeacherTranscript transcript = new TeacherTranscript();
            transcript.Show();
        }


        ////////  //"Groups"-option//  ///////////  

        //Creates all items on the panel
        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clear dataGridView
            dgwTeacherGroups.DataSource = "";

            //prevent opening 2 or more forms
            dgwTeacherGroups.Click -= ShowStudentInfo;
            //clear comboBox
            cbxTeacherSelectGroups.Items.Clear();

            /////
            PanelTeacher.Controls.Clear();
            Height = StandartHeight;
            PanelTeacher.Width = 847;
            Width = 889;

            //set static items
            //declared  on the top
            dgwTeacherGroups.Top = 3;
            dgwTeacherGroups.Left = 3;
            dgwTeacherGroups.Width = 842;
            dgwTeacherGroups.Height = 137;
            dgwTeacherGroups.Font = new Font("Microsoft Sans Serif", Convert.ToInt32(8.25));
            dgwTeacherGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwTeacherGroups.ReadOnly = true;

            Label lblTeacherSelectGroups = new Label();
            lblTeacherSelectGroups.Left = 0;
            lblTeacherSelectGroups.AutoSize = true;
            lblTeacherSelectGroups.Top = 183;
            lblTeacherSelectGroups.ForeColor = ForeColorStatic;
            lblTeacherSelectGroups.Text = "Choose group:";

            //declared  on the top
            cbxTeacherSelectGroups.Left = 107;
            cbxTeacherSelectGroups.Top = 183;
            cbxTeacherSelectGroups.Width = 97;
            cbxTeacherSelectGroups.Height = 21;
            cbxTeacherSelectGroups.ForeColor = ForeColorStatic;
            cbxTeacherSelectGroups.DropDownStyle = ComboBoxStyle.DropDownList;

            //events
            cbxTeacherSelectGroups.SelectedIndexChanged += ShowStudetnsFromGroup;
            dgwTeacherGroups.Click += ShowStudentInfo;

            //add static items

            PanelTeacher.Controls.Add(dgwTeacherGroups);
            PanelTeacher.Controls.Add(lblTeacherSelectGroups);
            PanelTeacher.Controls.Add(cbxTeacherSelectGroups);

            Extensions.FillCbxGroups(cbxTeacherSelectGroups);

        }

        //Shows students from the selected group
        private void ShowStudetnsFromGroup(object sender, EventArgs e)
        {
            foreach (var item in db.Groups.ToList())
            {
                if (item.GroupName == cbxTeacherSelectGroups.SelectedItem.ToString())
                {
                    GroupId = item.GroupId;
                    dgwTeacherGroups.DataSource = db.Students.Where(d => d.GroupId == GroupId).ToList();
                    break;
                }
            }
        }

        //Shows clicked student info (first get  data from database)
        private void ShowStudentInfo(object sender, EventArgs e)
        {
            var Birthdate = Convert.ToDateTime(dgwTeacherGroups.CurrentRow.Cells[4].Value);
            var RegDate = Convert.ToDateTime(dgwTeacherGroups.CurrentRow.Cells[7].Value);

            TeacherStudentInfo StudentInfo = new TeacherStudentInfo();
            StudentInfo.ShowClickedStudentInfo(
              Convert.ToInt32(dgwTeacherGroups.CurrentRow.Cells[0].Value),
              Convert.ToInt32(dgwTeacherGroups.CurrentRow.Cells[1].Value),
              dgwTeacherGroups.CurrentRow.Cells[2].Value.ToString(),
              dgwTeacherGroups.CurrentRow.Cells[3].Value.ToString(),
              Birthdate.ToShortDateString().ToString(),
              dgwTeacherGroups.CurrentRow.Cells[5].Value.ToString(),
              dgwTeacherGroups.CurrentRow.Cells[6].Value.ToString(),
              RegDate.ToShortDateString().ToString(),
              dgwTeacherGroups.CurrentRow.Cells[8].Value.ToString(),
              dgwTeacherGroups.CurrentRow.Cells[9].Value.ToString()
              );

            StudentInfo.Show();
        }


        ////////  //"My Messages"-option//  ///////////  

        //Shows a new Form to write to a group
        private void toStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherMessageToGroup MessageToGroup = new TeacherMessageToGroup();
            MessageToGroup.Show();
        }

        //Shows sent messages
        private void sentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherSent TeacherSent = new TeacherSent();
            TeacherSent.Show();
        }

        //Shows inbox messages
        private void inboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherInbox TeacherInbox = new TeacherInbox();
            TeacherInbox.Show();
        }

        //Shows a new Form to write to a Colleague
        private void toColleagueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherMessageToColleague MessageToColleague = new TeacherMessageToColleague();
            MessageToColleague.Show();
        }



        ////////  //"Colleagues"-option//  ///////////  

        //Creates all items on the panel
        private void ColleaguesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //prevent opening 2 or more forms
            dgwTeacherColleagues.Click -= ShowColleagueInfo;

            PanelTeacher.Controls.Clear();
            Height = StandartHeight;
            PanelTeacher.Width = 847;
            Width = 889;

            //set static items

            dgwTeacherColleagues.Top = 3;
            dgwTeacherColleagues.Left = 3;
            dgwTeacherColleagues.Width = 842;
            dgwTeacherColleagues.Font = new Font("Microsoft Sans Serif", Convert.ToInt32(8.25));
            dgwTeacherColleagues.Height = 257;
            dgwTeacherColleagues.DataSource = db.Teachers.ToList().Where(r => r.TeacherEmail != WelcomeScreen.UserEmail).ToList();
            dgwTeacherColleagues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwTeacherColleagues.ReadOnly = true;


            //Events
            dgwTeacherColleagues.Click += ShowColleagueInfo;
            //add static items
            PanelTeacher.Controls.Add(dgwTeacherColleagues);

        }

        // Shows clicked colleague info
        private void ShowColleagueInfo(object sender, EventArgs e)
        {


            TeacherInfo ColleagueInfo = new TeacherInfo();
            ColleagueInfo.ShowClickedColleagueInfo(
              Convert.ToInt32(dgwTeacherColleagues.CurrentRow.Cells[0].Value),
              Convert.ToInt32(dgwTeacherColleagues.CurrentRow.Cells[1].Value),
              dgwTeacherColleagues.CurrentRow.Cells[2].Value.ToString(),
              dgwTeacherColleagues.CurrentRow.Cells[3].Value.ToString(),
              dgwTeacherColleagues.CurrentRow.Cells[4].Value.ToString(),
              dgwTeacherColleagues.CurrentRow.Cells[5].Value.ToString(),
              dgwTeacherColleagues.CurrentRow.Cells[6].Value.ToString(),
              dgwTeacherColleagues.CurrentRow.Cells[7].Value.ToString());

            ColleagueInfo.Show();

        }



        ////////  //"Library"-option//  ///////////  

        //Creates all items on the panel
        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PanelTeacher.Controls.Clear();
            Height = StandartHeight;
            PanelTeacher.Width = panelNormalWidth;
            Width = formNormalWidth;

            //set static items


            dgwTeacherLibraryList.Top = 3;
            dgwTeacherLibraryList.Left = 3;
            dgwTeacherLibraryList.Width = 543;
            dgwTeacherLibraryList.Height = 137;
            dgwTeacherLibraryList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwTeacherLibraryList.Font = new Font("Microsoft Sans Serif", Convert.ToInt32(8.25));
            dgwTeacherLibraryList.DataSource = db.Libraries.ToList();
            dgwTeacherLibraryList.AllowUserToAddRows = false;
            dgwTeacherLibraryList.AllowUserToDeleteRows = false;
            dgwTeacherLibraryList.ReadOnly = true;


           
            btnTeacherLibraryAdd.Left = 4;
            btnTeacherLibraryAdd.Top = 178;
            btnTeacherLibraryAdd.Text = "Add";
            btnTeacherLibraryAdd.Height = 25;
            btnTeacherLibraryAdd.Width = 80;

            Button btnTeacherLibraryDelete = new Button();
            btnTeacherLibraryDelete.Left = 99;
            btnTeacherLibraryDelete.Top = 178;
            btnTeacherLibraryDelete.Text = "Delete";
            btnTeacherLibraryDelete.Height = 25;
            btnTeacherLibraryDelete.Width = 80;

            Button btnTeacherLibraryDownload = new Button();
            btnTeacherLibraryDownload.Left = 469;
            btnTeacherLibraryDownload.Top = 178;
            btnTeacherLibraryDownload.Text = "Download";
            btnTeacherLibraryDownload.Height = 25;
            btnTeacherLibraryDownload.Width = 80;

            //Events
            btnTeacherLibraryAdd.Click += AddResource;
            btnTeacherLibraryDelete.Click += DeleteSource;
            dgwTeacherLibraryList.Click += GetSourceId;
            btnTeacherLibraryDownload.Click += DownloadPdf;

            //add static items
            PanelTeacher.Controls.Add(dgwTeacherLibraryList);
            PanelTeacher.Controls.Add(btnTeacherLibraryAdd);
            PanelTeacher.Controls.Add(btnTeacherLibraryDelete);
            PanelTeacher.Controls.Add(btnTeacherLibraryDownload);

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
            SourceId = Convert.ToInt32(dgwTeacherLibraryList.CurrentRow.Cells[0].Value);
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
            dgwTeacherLibraryList.DataSource = db.Libraries.ToList();
        }

        //Adds a source to the library
        private void AddResource(object sender, EventArgs e)
        {
            TeacherAddToLibrary AddSource = new TeacherAddToLibrary();
            AddSource.Show();
            btnTeacherLibraryAdd.Enabled = false;
        }


        ////////  //"Mentor Info"-option//  ///////////  

        //Creates all items on the panel
        private void mentorInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            btnTeacherWriteMessageMentor.Click -= new EventHandler(this.TeacherWriteMessageToMentor);

            //clear comboBox 
            cbxTeacherGroupMentor.Items.Clear();

            ////////////
            PanelTeacher.Controls.Clear();
            Height = ShortHeight;

            PanelTeacher.Width = panelNormalWidth;
            Width = formNormalWidth;

            //set static Items

            Label lblTeacherGroupMentor = new Label();
            lblTeacherGroupMentor.Left = 14;
            lblTeacherGroupMentor.Top = 21;
            lblTeacherGroupMentor.ForeColor = ForeColorStatic;
            lblTeacherGroupMentor.Text = "Group:";

            Label lblTeacherMentorName = new Label();
            lblTeacherMentorName.Left = 14;
            lblTeacherMentorName.Top = 44;
            lblTeacherMentorName.ForeColor = ForeColorStatic;
            lblTeacherMentorName.Text = "Name:";

            Label lblTeacherMentorSurname = new Label();
            lblTeacherMentorSurname.Left = 14;
            lblTeacherMentorSurname.Top = 67;
            lblTeacherMentorSurname.ForeColor = ForeColorStatic;
            lblTeacherMentorSurname.Text = "Surname:";

            Label lblTeacherMentorEmail = new Label();
            lblTeacherMentorEmail.Left = 14;
            lblTeacherMentorEmail.Top = 90;
            lblTeacherMentorEmail.ForeColor = ForeColorStatic;
            lblTeacherMentorEmail.Text = "Email:";


          
            btnTeacherWriteMessageMentor.Left = 300;
            btnTeacherWriteMessageMentor.Top = 84;
            btnTeacherWriteMessageMentor.Height = 25;
            btnTeacherWriteMessageMentor.Text = "Message";
            btnTeacherWriteMessageMentor.AutoSize = true;


            //set dynamic Items


            cbxTeacherGroupMentor.Left = 114;
            cbxTeacherGroupMentor.Top = 14;
            cbxTeacherGroupMentor.Width = 97;
            cbxTeacherGroupMentor.Height = 21;
            cbxTeacherGroupMentor.ForeColor = ForeColorStatic;
            cbxTeacherGroupMentor.DropDownStyle = ComboBoxStyle.DropDownList;


            //declared on the top
            lblTeacherCurrentMentorName.Left = 110;
            lblTeacherCurrentMentorName.Top = 44;
            lblTeacherCurrentMentorName.ForeColor = ForeColor;
            lblTeacherCurrentMentorName.Text = "Name";

            lblTeacherCurrentMentorSurName.Left = 110;
            lblTeacherCurrentMentorSurName.Top = 67;
            lblTeacherCurrentMentorSurName.ForeColor = ForeColor;
            lblTeacherCurrentMentorSurName.Text = "Surname";


            lblTeacherCurrentMentorEmail.Left = 110;
            lblTeacherCurrentMentorEmail.Top = 90;
            lblTeacherCurrentMentorEmail.ForeColor = ForeColor;
            lblTeacherCurrentMentorEmail.Text = "Email";
            lblTeacherCurrentMentorEmail.AutoSize = true;


            //add click eventHandler to the btn-"Message" to write to the Mentor
            btnTeacherWriteMessageMentor.Click += new EventHandler(this.TeacherWriteMessageToMentor);
            Extensions.FillCbxGroups(cbxTeacherGroupMentor);
            cbxTeacherGroupMentor.SelectedIndexChanged += ShowMentorInfo;

            //adding static data

            PanelTeacher.Controls.Add(lblTeacherGroupMentor);
            PanelTeacher.Controls.Add(lblTeacherMentorName);
            PanelTeacher.Controls.Add(lblTeacherMentorSurname);
            PanelTeacher.Controls.Add(lblTeacherMentorEmail);
            PanelTeacher.Controls.Add(btnTeacherWriteMessageMentor);

            //adding dynamic data

            PanelTeacher.Controls.Add(cbxTeacherGroupMentor);
            PanelTeacher.Controls.Add(lblTeacherCurrentMentorName);
            PanelTeacher.Controls.Add(lblTeacherCurrentMentorSurName);
            PanelTeacher.Controls.Add(lblTeacherCurrentMentorEmail);
        }

        //Shows selected mentor info
        private void ShowMentorInfo(object sender, EventArgs e)
        {
            foreach (var item in db.Groups.ToList())
            {
                if (item.GroupName == cbxTeacherGroupMentor.SelectedItem.ToString())
                {
                    mentorId = item.MentorId;
                    foreach (var item1 in db.Mentors.ToList())
                    {
                        if (item1.MentorId == mentorId)
                        {
                            lblTeacherCurrentMentorName.Text = item1.MentorName;
                            lblTeacherCurrentMentorSurName.Text = item1.MentorSurname;
                            lblTeacherCurrentMentorEmail.Text = item1.MentorEmail;
                        }
                    }
                }
            }
        }
        //Shows a new Form to write to a mentor
        private void TeacherWriteMessageToMentor(object sender, EventArgs e)
        {
            TeacherMessageToMentor MessageToMentor = new TeacherMessageToMentor();
            MessageToMentor.Show();
            btnTeacherWriteMessageMentor.Enabled = false;
        }
    }
}
