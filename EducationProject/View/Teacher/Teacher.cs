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
    public partial class Teacher : Form
    {
        private new Color ForeColor = Color.FromName("ControlText");
        private Color ForeColorStatic = Color.FromName("ControlDarkDark");

        // Form size types
        int StandartHeight = 342;
        int ShortHeight = 215;

        public Teacher()
        {
            InitializeComponent();
            PanelTeacher.Controls.Clear();
            PanelTeacher.Font = new Font(PanelTeacher.Font.FontFamily, 10);

        }
        //"Personal Info" option
        private void personalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PanelTeacher.Controls.Clear();
            Height = 380;

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

        //Edit Personal Info
        private void EditTeacherPersonalInfo(object sender, EventArgs e)
        {
            TeacherEditInfo EditStudentInfo = new TeacherEditInfo();
            EditStudentInfo.Show();
        }

        //"Tasks" option
        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelTeacher.Controls.Clear();
            Height = StandartHeight;

            //set static items
            DataGridView dgwTeacherAllTasks = new DataGridView();
            dgwTeacherAllTasks.Top = 3;
            dgwTeacherAllTasks.Left = 3;
            dgwTeacherAllTasks.Width = 543;
            dgwTeacherAllTasks.Height = 137;

            Button btnTeacherAddTask = new Button();
            btnTeacherAddTask.Left = 132;
            btnTeacherAddTask.Top = 174;
            btnTeacherAddTask.Height = 25;
            btnTeacherAddTask.Width = 80;
            btnTeacherAddTask.Text = "Add Task";

            Button btnTeacherDeleteTask = new Button();
            btnTeacherDeleteTask.Left = 218;
            btnTeacherDeleteTask.Top = 174;
            btnTeacherDeleteTask.Height = 25;
            btnTeacherDeleteTask.Width = 98;
            btnTeacherDeleteTask.Text = "Delete Task";

            Button btnTeacherUpdateTask = new Button();
            btnTeacherUpdateTask.Left = 322;
            btnTeacherUpdateTask.Top = 174;
            btnTeacherUpdateTask.Height = 25;
            btnTeacherUpdateTask.Width = 98;
            btnTeacherUpdateTask.Text = "Update Task";

            //add click eventHandler to the btn-"Add Task"
            btnTeacherAddTask.Click += new EventHandler(this.AddTask);

            //add click eventHandler to the btn-"Add Update"
            btnTeacherUpdateTask.Click += new EventHandler(this.UpdateTask);


            //add static items
            PanelTeacher.Controls.Add(dgwTeacherAllTasks);
            PanelTeacher.Controls.Add(btnTeacherAddTask);
            PanelTeacher.Controls.Add(btnTeacherDeleteTask);
            PanelTeacher.Controls.Add(btnTeacherUpdateTask);
        }

        //add task to the tasklist
        private void AddTask(object sender, EventArgs e)
        {
            TeacherAddTask AddTask = new TeacherAddTask();
            AddTask.Show();
        }

        //Update task from the tasklist
        private void UpdateTask(object sender, EventArgs e)
        {
            TeacherUpdateTask updateTask = new TeacherUpdateTask();
            updateTask.Show();
        }

        //Assign Task to student(s)
        private void assignTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherAssignTask assignTask = new TeacherAssignTask();
            assignTask.Show();
        }

        //"Groups" option
        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelTeacher.Controls.Clear();
            Height = StandartHeight;
            //set static items

            DataGridView dgwTeacherGroups = new DataGridView();
            dgwTeacherGroups.Top = 3;
            dgwTeacherGroups.Left = 3;
            dgwTeacherGroups.Width = 543;
            dgwTeacherGroups.Height = 137;


            Label lblTeacherSelectGroups = new Label();
            lblTeacherSelectGroups.Left = 0;
            lblTeacherSelectGroups.Top = 183;
            lblTeacherSelectGroups.ForeColor = ForeColorStatic;
            lblTeacherSelectGroups.Text = "Choose group:";

            ComboBox cbxTeacherSelectGroups = new ComboBox();
            cbxTeacherSelectGroups.Left = 107;
            cbxTeacherSelectGroups.Top = 183;
            cbxTeacherSelectGroups.Width = 97;
            cbxTeacherSelectGroups.Height = 21;
            cbxTeacherSelectGroups.ForeColor = ForeColorStatic;

            //add static items

            PanelTeacher.Controls.Add(dgwTeacherGroups);
            PanelTeacher.Controls.Add(lblTeacherSelectGroups);
            PanelTeacher.Controls.Add(cbxTeacherSelectGroups);
        }

        //shows new Form to write to a Group
        private void toStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherMessageToGroup MessageToGroup = new TeacherMessageToGroup();
            MessageToGroup.Show();
        }

        //shows new Form to write to a Collegue
        private void toCollegueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherMessageToCollegue MessageToCollegue = new TeacherMessageToCollegue();
            MessageToCollegue.Show();
        }

        //shows sent messages
        private void sentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherSent TeacherSent = new TeacherSent();
            TeacherSent.Show();
        }

        //shows inbox messages
        private void inboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherInbox TeacherInbox = new TeacherInbox();
            TeacherInbox.Show();
        }

        //Collegues option
        private void colleguesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelTeacher.Controls.Clear();
            Height = StandartHeight;
            //set static items
            DataGridView dgwTeacherCollegues = new DataGridView();
            dgwTeacherCollegues.Top = 3;
            dgwTeacherCollegues.Left = 3;
            dgwTeacherCollegues.Width = 545;
            dgwTeacherCollegues.Height = 257;

            //add static items
            PanelTeacher.Controls.Add(dgwTeacherCollegues);

        }

        //  "Library" option
        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelTeacher.Controls.Clear();
            Height = StandartHeight;

            //set static items

            DataGridView dgwTeacherLibrary = new DataGridView();
            dgwTeacherLibrary.Top = 3;
            dgwTeacherLibrary.Left = 3;
            dgwTeacherLibrary.Width = 543;
            dgwTeacherLibrary.Height = 137;

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

            //add static items
            PanelTeacher.Controls.Add(dgwTeacherLibrary);
            PanelTeacher.Controls.Add(btnTeacherLibraryAdd);
            PanelTeacher.Controls.Add(btnTeacherLibraryDelete);
            PanelTeacher.Controls.Add(btnTeacherLibraryDownload);

        }

        private void mentorInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelTeacher.Controls.Clear();
            Height = ShortHeight;

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
            btnTeacherWriteMessageMentor.Left = 260;
            btnTeacherWriteMessageMentor.Top = 84;
            btnTeacherWriteMessageMentor.Height = 25;
            btnTeacherWriteMessageMentor.Text = "Message";

            //add click eventHandler to the btn-"Message" to write to the Mentor
            btnTeacherWriteMessageMentor.Click += new EventHandler(this.TeacherWriteMessageToMentor);

            //set dynamic Items

            ComboBox cbxTeacherGroupMentor = new ComboBox();
            cbxTeacherGroupMentor.Left = 114;
            cbxTeacherGroupMentor.Top = 14;
            cbxTeacherGroupMentor.Width = 97;
            cbxTeacherGroupMentor.Height = 21;
            cbxTeacherGroupMentor.ForeColor = ForeColorStatic;

            Label lblTeacherCurrentMentorName = new Label();
            lblTeacherCurrentMentorName.Left = 110;
            lblTeacherCurrentMentorName.Top = 44;
            lblTeacherCurrentMentorName.ForeColor = ForeColor;
            lblTeacherCurrentMentorName.Text = "Name";

            Label lblTeacherCurrentMentorSurName = new Label();
            lblTeacherCurrentMentorSurName.Left = 110;
            lblTeacherCurrentMentorSurName.Top = 67;
            lblTeacherCurrentMentorSurName.ForeColor = ForeColor;
            lblTeacherCurrentMentorSurName.Text = "Surname";

            Label lblTeacherCurrentMentorEmail = new Label();
            lblTeacherCurrentMentorEmail.Left = 110;
            lblTeacherCurrentMentorEmail.Top = 90;

            lblTeacherCurrentMentorEmail.ForeColor = ForeColor;
            lblTeacherCurrentMentorEmail.Text = "Email";

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

        private void TeacherWriteMessageToMentor(object sender, EventArgs e)
        {
            TeacherMessageToMentor MessageToMentor = new TeacherMessageToMentor();
            MessageToMentor.Show();
        }
    }
}
