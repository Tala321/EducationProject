using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationProject.View.Student
{
    public partial class Student : Form
    {
        private new Color ForeColor = Color.FromName("ControlText");
        private Color ForeColorStatic = Color.FromName("ControlDarkDark");

        // Form size types
        int StandartHeight = 342;
        int ShortHeight = 215;

        public Student()
        {
            InitializeComponent();
            PanelStudent.Controls.Clear();
            PanelStudent.Font = new Font(PanelStudent.Font.FontFamily, 10);

        }

        //strip menu
        private void personalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PanelStudent.Controls.Clear();
            Height = StandartHeight;

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


            Label lblStudentPhoto = new Label();
            lblStudentPhoto.Left = 280;
            lblStudentPhoto.Top = 47;
            lblStudentPhoto.ForeColor = ForeColorStatic;
            lblStudentPhoto.Text = "Photo:";



            //set dynamic items          
            Label lblCurrentStudentId = new Label();
            lblCurrentStudentId.Left = 140;
            lblCurrentStudentId.Top = 44;
            lblCurrentStudentId.ForeColor = ForeColor;
            lblCurrentStudentId.Text = "Id";

            Label lblCurrentStudentGroup = new Label();
            lblCurrentStudentGroup.Left = 140;
            lblCurrentStudentGroup.Top = 67;
            lblCurrentStudentGroup.ForeColor = ForeColor;
            lblCurrentStudentGroup.Text = "Group";

            Label lblCurrentStudentName = new Label();
            lblCurrentStudentName.Left = 140;
            lblCurrentStudentName.Top = 90;
            lblCurrentStudentName.ForeColor = ForeColor;
            lblCurrentStudentName.Text = "Name";

            Label lblCurrentStudentSurname = new Label();
            lblCurrentStudentSurname.Left = 140;
            lblCurrentStudentSurname.Top = 113;
            lblCurrentStudentSurname.ForeColor = ForeColor;
            lblCurrentStudentSurname.Text = "Surname";


            Label lblCurrentStudentBirthdate = new Label();
            lblCurrentStudentBirthdate.Left = 140;
            lblCurrentStudentBirthdate.Top = 136;
            lblCurrentStudentBirthdate.ForeColor = ForeColor;
            lblCurrentStudentBirthdate.Text = "Birthdate";


            Label lblCurrentStudentEmail = new Label();
            lblCurrentStudentEmail.Left = 140;
            lblCurrentStudentEmail.Top = 159;
            lblCurrentStudentEmail.ForeColor = ForeColor;
            lblCurrentStudentEmail.Text = "Email";

            Label lblCurrentStudentPhone = new Label();
            lblCurrentStudentPhone.Left = 140;
            lblCurrentStudentPhone.Top = 182;
            lblCurrentStudentPhone.ForeColor = ForeColor;
            lblCurrentStudentPhone.Text = "N/A";

            Label lblCurrentStudentRegistrationDate = new Label();
            lblCurrentStudentRegistrationDate.Left = 140;
            lblCurrentStudentRegistrationDate.Top = 205;
            lblCurrentStudentRegistrationDate.ForeColor = ForeColor;
            lblCurrentStudentRegistrationDate.Text = "N/A";


            Label lblCurrrentStudentPhoto = new Label();
            lblCurrrentStudentPhoto.Left = 378;
            lblCurrrentStudentPhoto.Top = 47;
            lblCurrrentStudentPhoto.ForeColor = ForeColor;
            lblCurrrentStudentPhoto.Text = "N/A";

            Button btnStudentInfoEdit = new Button();
            btnStudentInfoEdit.Left = 17;
            btnStudentInfoEdit.Top = 235;
            btnStudentInfoEdit.Text = "Edit";
            btnStudentInfoEdit.Height = 25;
            btnStudentInfoEdit.Width = 80;

            //add click eventHandler to the btn-"Edit"
            btnStudentInfoEdit.Click += new EventHandler(this.EditStudentPersonalInfo);

            //adding  items

            PanelStudent.Controls.Add(lblStudentId);
            PanelStudent.Controls.Add(lblStudentGroup);
            PanelStudent.Controls.Add(lblStudentName);
            PanelStudent.Controls.Add(lblStudentSurname);
            PanelStudent.Controls.Add(lblStudentBirthdate);
            PanelStudent.Controls.Add(lblStudentEmail);
            PanelStudent.Controls.Add(lblStudentPhone);
            PanelStudent.Controls.Add(lblStudentRegistrationDate);
            PanelStudent.Controls.Add(btnStudentInfoEdit);
            PanelStudent.Controls.Add(lblStudentPhoto);

            PanelStudent.Controls.Add(lblCurrentStudentId);
            PanelStudent.Controls.Add(lblCurrentStudentGroup);
            PanelStudent.Controls.Add(lblCurrentStudentName);
            PanelStudent.Controls.Add(lblCurrentStudentSurname);
            PanelStudent.Controls.Add(lblCurrentStudentBirthdate);
            PanelStudent.Controls.Add(lblCurrentStudentEmail);
            PanelStudent.Controls.Add(lblCurrentStudentPhone);
            PanelStudent.Controls.Add(lblCurrentStudentRegistrationDate);
            PanelStudent.Controls.Add(lblCurrrentStudentPhoto);
            PanelStudent.Controls.Add(btnStudentInfoEdit);


        }

        //Edit personal info
        private void EditStudentPersonalInfo(object sender, EventArgs e)
        {
            StudentEditInfo EditStudentInfo = new StudentEditInfo();
            EditStudentInfo.Show();
        }

        //Show Tasks
        private void showTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelStudent.Controls.Clear();
            Height = StandartHeight;

            //set items in Student's "Show tasks" option

            DataGridView dgwStudentAllTasks = new DataGridView();
            dgwStudentAllTasks.Top = 3;
            dgwStudentAllTasks.Left = 3;
            dgwStudentAllTasks.Width = 543;
            dgwStudentAllTasks.Height = 137;

            Button btnStudentTaskExport = new Button();
            btnStudentTaskExport.Top = 183;
            btnStudentTaskExport.Left = 426;
            btnStudentTaskExport.Height = 25;
            btnStudentTaskExport.Text = "Export Transcipt";
            btnStudentTaskExport.Width = 120;

            //add items
            PanelStudent.Controls.Add(dgwStudentAllTasks);
            PanelStudent.Controls.Add(btnStudentTaskExport);
        }

        //Teacher info
        private void teacherInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelStudent.Controls.Clear();
            Height = ShortHeight;

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

            Button btnStudentWriteMessageToTeacher = new Button();
            btnStudentWriteMessageToTeacher.Left = 260;
            btnStudentWriteMessageToTeacher.Top = 84;
            btnStudentWriteMessageToTeacher.Height = 25;
            btnStudentWriteMessageToTeacher.Text = "Message";

            //add click eventHandler to the btn-"Message" to write to the Teacher
            btnStudentWriteMessageToTeacher.Click += new EventHandler(this.WritePrivateMessageToTeacher);

            //set dynamic items

            Label lblStudentCurrentTeacherName = new Label();
            lblStudentCurrentTeacherName.Left = 110;
            lblStudentCurrentTeacherName.Top = 44;
            lblStudentCurrentTeacherName.ForeColor = ForeColor;
            lblStudentCurrentTeacherName.Text = "Name";

            Label lblStudentCurrentTeacherSurname = new Label();
            lblStudentCurrentTeacherSurname.Left = 110;
            lblStudentCurrentTeacherSurname.Top = 67;
            lblStudentCurrentTeacherSurname.ForeColor = ForeColor;
            lblStudentCurrentTeacherSurname.Text = "Surname";

            Label lblStudentCurrentTeacherEmail = new Label();
            lblStudentCurrentTeacherEmail.Left = 110;
            lblStudentCurrentTeacherEmail.Top = 90;

            lblStudentCurrentTeacherEmail.ForeColor = ForeColor;
            lblStudentCurrentTeacherEmail.Text = "Email";

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

        //shows new Form to write to the Teacher
        private void WritePrivateMessageToTeacher(object sender, EventArgs e)
        {
            MessageToTeacher messageToTeacher = new MessageToTeacher();
            messageToTeacher.Show();
        }

        private void mentorInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelStudent.Controls.Clear();
            Height = ShortHeight;

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

            Button btnStudentWriteMessageMentor = new Button();
            btnStudentWriteMessageMentor.Left = 260;
            btnStudentWriteMessageMentor.Top = 84;
            btnStudentWriteMessageMentor.Height = 25;
            btnStudentWriteMessageMentor.Text = "Message";

            //add click eventHandler to the btn-"Message" to write to the Mentor
            btnStudentWriteMessageMentor.Click += new EventHandler(this.WritePrivateMessageToMentor);

            //set dynamic data
            Label lblStudentCurrentMentorName = new Label();
            lblStudentCurrentMentorName.Left = 110;
            lblStudentCurrentMentorName.Top = 44;
            lblStudentCurrentMentorName.ForeColor = ForeColor;
            lblStudentCurrentMentorName.Text = "Name";

            Label lblStudentCurrentMentorSurName = new Label();
            lblStudentCurrentMentorSurName.Left = 110;
            lblStudentCurrentMentorSurName.Top = 67;
            lblStudentCurrentMentorSurName.ForeColor = ForeColor;
            lblStudentCurrentMentorSurName.Text = "Surname";

            Label lblStudentCurrentMentorEmail = new Label();
            lblStudentCurrentMentorEmail.Left = 110;
            lblStudentCurrentMentorEmail.Top = 90;

            lblStudentCurrentMentorEmail.ForeColor = ForeColor;
            lblStudentCurrentMentorEmail.Text = "Email";

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

        // shows new Form to write to the Mentor
        private void WritePrivateMessageToMentor(object sender, EventArgs e)
        {
            MessageToMentor messageToMentor = new MessageToMentor();
            messageToMentor.Show();
        }

        //shows new Form to write to a Groupmate
        private void toGroupmateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentMessageToGroupmate messageToGroupmate = new StudentMessageToGroupmate();
            messageToGroupmate.Show();
        }

        // shows all Groupmates
        private void groupmatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelStudent.Controls.Clear();
            Height = StandartHeight;

            DataGridView dgwStudentAllGroupmates = new DataGridView();
            dgwStudentAllGroupmates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwStudentAllGroupmates.Top = 3;
            dgwStudentAllGroupmates.Left = 4;
            dgwStudentAllGroupmates.Width = 541;
            dgwStudentAllGroupmates.Height = 257;

            //add items
            PanelStudent.Controls.Add(dgwStudentAllGroupmates);
        }

        // Shows Student's Library
        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelStudent.Controls.Clear();
            Height = StandartHeight;

            DataGridView dgwStudentLibrary = new DataGridView();
            dgwStudentLibrary.Top = 3;
            dgwStudentLibrary.Left = 3;
            dgwStudentLibrary.Width = 542;
            dgwStudentLibrary.Height = 137;

            //Download  library button
            Button btnStudentLibraryDownLoad = new Button();
            btnStudentLibraryDownLoad.Top = 183;
            btnStudentLibraryDownLoad.Left = 426;
            btnStudentLibraryDownLoad.Height = 25;
            btnStudentLibraryDownLoad.Width = 80;
            btnStudentLibraryDownLoad.Text = "Download";
            btnStudentLibraryDownLoad.Width = 120;

            //add items
            PanelStudent.Controls.Add(dgwStudentLibrary);
            PanelStudent.Controls.Add(btnStudentLibraryDownLoad);
        }
    }
}
