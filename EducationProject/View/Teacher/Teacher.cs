﻿using System;
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
    public partial class Teacher : Form
    {

        //DataBase
        EducationProjectEntities db = new EducationProjectEntities();


        ////////  //We will use it in more than one methods//  /////////// 

        //declare dataGridView
        DataGridView dgwTeacherLibraryList = new DataGridView();
        DataGridView dgwTeacherGroups = new DataGridView();
        public DataGridView dgwTeacherColleagues = new DataGridView();
        public DataGridView dgwTeacherAllTasks = new DataGridView();


        // holds source id
        int SourceId;
        int GroupId;
        int mentorId;
        int TaskId;

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

        ////////  //End - We will use it in more than one methods//  /////////// 


        public Teacher()
        {
            InitializeComponent();
            PanelTeacher.Controls.Clear();
            PanelTeacher.Font = new Font(PanelTeacher.Font.FontFamily, 10);

        }

        ////////  //"Personal Info"-option//  /////////// 

        //Creates all items on the panel
        private void personalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PanelTeacher.Controls.Clear();
            Height = 380;
            PanelTeacher.Width = panelNormalWidth;
            Width = formNormalWidth;
            //set Static items

            Label lblTeacherId = new Label();
            lblTeacherId.Left = 14;
            lblTeacherId.Top = 44;
            lblTeacherId.ForeColor = ForeColorStatic;
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

            Label lblTeacherBirthdate = new Label();
            lblTeacherBirthdate.Left = 14;
            lblTeacherBirthdate.Top = 136;
            lblTeacherBirthdate.ForeColor = ForeColorStatic;
            lblTeacherBirthdate.Text = "Birthdate:";

            Label lblTeacherEmail = new Label();
            lblTeacherEmail.Left = 14;
            lblTeacherEmail.Top = 159;
            lblTeacherEmail.ForeColor = ForeColorStatic;
            lblTeacherEmail.Text = "Email:";

            Label lblTeacherPhone = new Label();
            lblTeacherPhone.Left = 14;
            lblTeacherPhone.Top = 182;
            lblTeacherPhone.ForeColor = ForeColorStatic;
            lblTeacherPhone.Text = "Phone:";

            Label lblTeacherRegistrationDate = new Label();
            lblTeacherRegistrationDate.Left = 14;
            lblTeacherRegistrationDate.Top = 205;
            lblTeacherRegistrationDate.ForeColor = ForeColorStatic;
            lblTeacherRegistrationDate.Text = "Registration Date:";

            Label lblTeacherBio = new Label();
            lblTeacherBio.Left = 14;
            lblTeacherBio.Top = 228;
            lblTeacherBio.ForeColor = ForeColorStatic;
            lblTeacherBio.Text = "Bio:";

            Label lblTeacherPhoto = new Label();
            lblTeacherPhoto.Left = 280;
            lblTeacherPhoto.Top = 47;
            lblTeacherPhoto.ForeColor = ForeColorStatic;
            lblTeacherPhoto.Text = "Photo:";


            //set dynamic items          
            Label lblCurrentTeacherId = new Label();
            lblCurrentTeacherId.Left = 140;
            lblCurrentTeacherId.Top = 44;
            lblCurrentTeacherId.ForeColor = ForeColor;
            lblCurrentTeacherId.Text = "Id";

            Label lblCurrentTeacherProgram = new Label();
            lblCurrentTeacherProgram.Left = 140;
            lblCurrentTeacherProgram.Top = 67;
            lblCurrentTeacherProgram.ForeColor = ForeColor;
            lblCurrentTeacherProgram.Text = "Program name";

            Label lblCurrentTeacherName = new Label();
            lblCurrentTeacherName.Left = 140;
            lblCurrentTeacherName.Top = 90;
            lblCurrentTeacherName.ForeColor = ForeColor;
            lblCurrentTeacherName.Text = "Name";

            Label lblCurrentTeacherSurname = new Label();
            lblCurrentTeacherSurname.Left = 140;
            lblCurrentTeacherSurname.Top = 113;
            lblCurrentTeacherSurname.ForeColor = ForeColor;
            lblCurrentTeacherSurname.Text = "Surname";


            Label lblCurrentTeacherBirthdate = new Label();
            lblCurrentTeacherBirthdate.Left = 140;
            lblCurrentTeacherBirthdate.Top = 136;
            lblCurrentTeacherBirthdate.ForeColor = ForeColor;
            lblCurrentTeacherBirthdate.Text = "Birthdate";


            Label lblCurrentTeacherEmail = new Label();
            lblCurrentTeacherEmail.Left = 140;
            lblCurrentTeacherEmail.Top = 159;
            lblCurrentTeacherEmail.ForeColor = ForeColor;
            lblCurrentTeacherEmail.Text = "Email";

            Label lblCurrentTeacherPhone = new Label();
            lblCurrentTeacherPhone.Left = 140;
            lblCurrentTeacherPhone.Top = 182;
            lblCurrentTeacherPhone.ForeColor = ForeColor;
            lblCurrentTeacherPhone.Text = "N/A";

            Label lblCurrentTeacherRegistrationDate = new Label();
            lblCurrentTeacherRegistrationDate.Left = 140;
            lblCurrentTeacherRegistrationDate.Top = 205;
            lblCurrentTeacherRegistrationDate.ForeColor = ForeColor;
            lblCurrentTeacherRegistrationDate.Text = "N/A";

            Label lblCurrentTeacherBio = new Label();
            lblCurrentTeacherBio.Left = 140;
            lblCurrentTeacherBio.Top = 228;
            lblCurrentTeacherBio.ForeColor = ForeColor;
            lblCurrentTeacherBio.Text = "Bio";


            Label lblCurrrentTeacherPhoto = new Label();
            lblCurrrentTeacherPhoto.Left = 378;
            lblCurrrentTeacherPhoto.Top = 47;
            lblCurrrentTeacherPhoto.ForeColor = ForeColor;
            lblCurrrentTeacherPhoto.Text = "N/A";


            Button btnTeacherInfoEdit = new Button();
            btnTeacherInfoEdit.Left = 449;
            btnTeacherInfoEdit.Top = 220;
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
            PanelTeacher.Controls.Add(lblTeacherBirthdate);
            PanelTeacher.Controls.Add(lblTeacherEmail);
            PanelTeacher.Controls.Add(lblTeacherPhone);
            PanelTeacher.Controls.Add(lblTeacherRegistrationDate);
            PanelTeacher.Controls.Add(lblTeacherBio);
            PanelTeacher.Controls.Add(btnTeacherInfoEdit);
            PanelTeacher.Controls.Add(lblTeacherPhoto);


            //adding dynamic items

            PanelTeacher.Controls.Add(lblCurrentTeacherId);
            PanelTeacher.Controls.Add(lblCurrentTeacherProgram);
            PanelTeacher.Controls.Add(lblCurrentTeacherName);
            PanelTeacher.Controls.Add(lblCurrentTeacherSurname);
            PanelTeacher.Controls.Add(lblCurrentTeacherBirthdate);
            PanelTeacher.Controls.Add(lblCurrentTeacherEmail);
            PanelTeacher.Controls.Add(lblCurrentTeacherPhone);
            PanelTeacher.Controls.Add(lblCurrentTeacherRegistrationDate);
            PanelTeacher.Controls.Add(lblCurrentTeacherBio);
            PanelTeacher.Controls.Add(lblCurrrentTeacherPhoto);
            PanelTeacher.Controls.Add(btnTeacherInfoEdit);
        }

        //Edits Personal Info
        private void EditTeacherPersonalInfo(object sender, EventArgs e)
        {
            TeacherEditInfo EditStudentInfo = new TeacherEditInfo();
            EditStudentInfo.Show();
        }

        ////////  // End -"Personal Info"-option//  /////////// 


        ////////  //"Task"-option//  ///////////  

        //Creates all items on the panel
        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {


            PanelTeacher.Controls.Clear();
            Height = 321;
            PanelTeacher.Width = 847;
            Width = 889;

            //set static items

            dgwTeacherAllTasks.Top = 3;
            dgwTeacherAllTasks.Left = 3;
            dgwTeacherAllTasks.Width = 842;
            dgwTeacherAllTasks.Height = 137;

            dgwTeacherAllTasks.DataSource = db.Tasks.ToList();
            dgwTeacherAllTasks.Font = new Font("Microsoft Sans Serif", Convert.ToInt32(8.25));
            dgwTeacherAllTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwTeacherAllTasks.ReadOnly = true;


            Button btnTeacherAddTask = new Button();
            btnTeacherAddTask.Left = 270;
            btnTeacherAddTask.Top = 190;
            btnTeacherAddTask.Height = 25;
            btnTeacherAddTask.Width = 80;
            btnTeacherAddTask.Text = "Add Task";

            Button btnTeacherDeleteTask = new Button();
            btnTeacherDeleteTask.Left = 360;
            btnTeacherDeleteTask.Top = 190;
            btnTeacherDeleteTask.Height = 25;
            btnTeacherDeleteTask.Width = 98;
            btnTeacherDeleteTask.Text = "Delete Task";

            Button btnTeacherUpdateTask = new Button();
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

        }

        //Adds a task to the tasklist
        private void AddTask(object sender, EventArgs e)
        {
            TeacherAddTask AddTask = new TeacherAddTask();
            AddTask.Show();
        }

        //Updates a task from the tasklist
        private void UpdateTask(object sender, EventArgs e)
        {
            TeacherUpdateTask updateTask = new TeacherUpdateTask();
            updateTask.Show();
        }

        //Assigns a task to (a) student(s)
        private void assignTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherAssignTask assignTask = new TeacherAssignTask();
            assignTask.Show();
        }

        ////////  // End -"Task"-option//  /////////// 



        ////////  //"Groups"-option//  ///////////  

        //Creates all items on the panel
        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cleade dataGridView
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

        ////////  //End - "Groups"-option//  ///////////  



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

        ////////  //End- "My Messages"-option//  ///////////  



        ////////  //"Colleagues"-option//  ///////////  

        //Creates all items on the panel
        private void ColleaguesToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            dgwTeacherColleagues.DataSource = db.Teachers.ToList();
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

        ////////  //End-"Colleagues"-option//  ///////////  



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


            Button btnTeacherLibraryAdd = new Button();
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
        }

        ////////  //End -"Library"-option//  ///////////  



        ////////  //"Mentor Info"-option//  ///////////  

        //Creates all items on the panel
        private void mentorInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
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


            Button btnTeacherWriteMessageMentor = new Button();
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
        }

        ////////  //End - "Mentor Info"-option//  ///////////  
    }
}
