using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationProject.View.Mentor
{
    public partial class Mentor : Form
    {
        private new Color ForeColor = Color.FromName("ControlText");
        private Color ForeColorStatic = Color.FromName("ControlDarkDark");

        // Form size types
        int StandartHeight = 342;
        int ShortHeight = 215;

        public Mentor()
        {
            InitializeComponent();
            PanelMentor.Controls.Clear();
            PanelMentor.Font = new Font(PanelMentor.Font.FontFamily, 10);
        }

        private void personalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelMentor.Controls.Clear();
            Height = 380;

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
            lblMentorProgramName.Text = "Program name:";

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

            Label lblMentorBirthdate = new Label();
            lblMentorBirthdate.Left = 14;
            lblMentorBirthdate.Top = 136;
            lblMentorBirthdate.ForeColor = ForeColorStatic;
            lblMentorBirthdate.Text = "Birthdate:";

            Label lblMentorEmail = new Label();
            lblMentorEmail.Left = 14;
            lblMentorEmail.Top = 159;
            lblMentorEmail.ForeColor = ForeColorStatic;
            lblMentorEmail.Text = "Email:";

            Label lblMentorPhone = new Label();
            lblMentorPhone.Left = 14;
            lblMentorPhone.Top = 182;
            lblMentorPhone.ForeColor = ForeColorStatic;
            lblMentorPhone.Text = "Phone:";

            Label lblMentorRegistrationDate = new Label();
            lblMentorRegistrationDate.Left = 14;
            lblMentorRegistrationDate.Top = 205;
            lblMentorRegistrationDate.ForeColor = ForeColorStatic;
            lblMentorRegistrationDate.Text = "Registration Date:";

            Label lblMentorBio = new Label();
            lblMentorBio.Left = 14;
            lblMentorBio.Top = 228;
            lblMentorBio.ForeColor = ForeColorStatic;
            lblMentorBio.Text = "Bio:";

            Label lblMentorPhoto = new Label();
            lblMentorPhoto.Left = 280;
            lblMentorPhoto.Top = 47;
            lblMentorPhoto.ForeColor = ForeColorStatic;
            lblMentorPhoto.Text = "Photo:";


            //set dynamic items          
            Label lblCurrentMentorId = new Label();
            lblCurrentMentorId.Left = 140;
            lblCurrentMentorId.Top = 44;
            lblCurrentMentorId.ForeColor = ForeColor;
            lblCurrentMentorId.Text = "Id";

            Label lblCurrentMentorProgram = new Label();
            lblCurrentMentorProgram.Left = 140;
            lblCurrentMentorProgram.Top = 67;
            lblCurrentMentorProgram.ForeColor = ForeColor;
            lblCurrentMentorProgram.Text = "Program name";

            Label lblCurrentMentorName = new Label();
            lblCurrentMentorName.Left = 140;
            lblCurrentMentorName.Top = 90;
            lblCurrentMentorName.ForeColor = ForeColor;
            lblCurrentMentorName.Text = "Name";

            Label lblCurrentMentorSurname = new Label();
            lblCurrentMentorSurname.Left = 140;
            lblCurrentMentorSurname.Top = 113;
            lblCurrentMentorSurname.ForeColor = ForeColor;
            lblCurrentMentorSurname.Text = "Surname";


            Label lblCurrentMentorBirthdate = new Label();
            lblCurrentMentorBirthdate.Left = 140;
            lblCurrentMentorBirthdate.Top = 136;
            lblCurrentMentorBirthdate.ForeColor = ForeColor;
            lblCurrentMentorBirthdate.Text = "Birthdate";


            Label lblCurrentMentorEmail = new Label();
            lblCurrentMentorEmail.Left = 140;
            lblCurrentMentorEmail.Top = 159;
            lblCurrentMentorEmail.ForeColor = ForeColor;
            lblCurrentMentorEmail.Text = "Email";

            Label lblCurrentMentorPhone = new Label();
            lblCurrentMentorPhone.Left = 140;
            lblCurrentMentorPhone.Top = 182;
            lblCurrentMentorPhone.ForeColor = ForeColor;
            lblCurrentMentorPhone.Text = "N/A";

            Label lblCurrentMentorRegistrationDate = new Label();
            lblCurrentMentorRegistrationDate.Left = 140;
            lblCurrentMentorRegistrationDate.Top = 205;
            lblCurrentMentorRegistrationDate.ForeColor = ForeColor;
            lblCurrentMentorRegistrationDate.Text = "N/A";

            Label lblCurrentMentorBio = new Label();
            lblCurrentMentorBio.Left = 140;
            lblCurrentMentorBio.Top = 228;
            lblCurrentMentorBio.ForeColor = ForeColor;
            lblCurrentMentorBio.Text = "Bio";


            Label lblCurrrentMentorPhoto = new Label();
            lblCurrrentMentorPhoto.Left = 378;
            lblCurrrentMentorPhoto.Top = 47;
            lblCurrrentMentorPhoto.ForeColor = ForeColor;
            lblCurrrentMentorPhoto.Text = "N/A";


            Button btnMentorInfoEdit = new Button();
            btnMentorInfoEdit.Left = 449;
            btnMentorInfoEdit.Top = 220;
            btnMentorInfoEdit.Text = "Edit";
            btnMentorInfoEdit.Height = 25;
            btnMentorInfoEdit.Width = 80;

            //add click eventHandler to the btn-"Edit"
            btnMentorInfoEdit.Click += new EventHandler(this.EditMentorPersonalInfo);


            //adding static items

            PanelMentor.Controls.Add(lblMentorId);
            PanelMentor.Controls.Add(lblMentorProgramName);
            PanelMentor.Controls.Add(lblMentorName);
            PanelMentor.Controls.Add(lblMentorSurname);
            PanelMentor.Controls.Add(lblMentorBirthdate);
            PanelMentor.Controls.Add(lblMentorEmail);
            PanelMentor.Controls.Add(lblMentorPhone);
            PanelMentor.Controls.Add(lblMentorRegistrationDate);
            PanelMentor.Controls.Add(lblMentorBio);
            PanelMentor.Controls.Add(btnMentorInfoEdit);
            PanelMentor.Controls.Add(lblMentorPhoto);


            //adding dynamic items

            PanelMentor.Controls.Add(lblCurrentMentorId);
            PanelMentor.Controls.Add(lblCurrentMentorProgram);
            PanelMentor.Controls.Add(lblCurrentMentorName);
            PanelMentor.Controls.Add(lblCurrentMentorSurname);
            PanelMentor.Controls.Add(lblCurrentMentorBirthdate);
            PanelMentor.Controls.Add(lblCurrentMentorEmail);
            PanelMentor.Controls.Add(lblCurrentMentorPhone);
            PanelMentor.Controls.Add(lblCurrentMentorRegistrationDate);
            PanelMentor.Controls.Add(lblCurrentMentorBio);
            PanelMentor.Controls.Add(lblCurrrentMentorPhoto);
            PanelMentor.Controls.Add(btnMentorInfoEdit);
        }

        //Edit Personal info 
        private void EditMentorPersonalInfo(object sender, EventArgs e)
        {
            MentorEditInfo MentorEditInfo = new MentorEditInfo();
            MentorEditInfo.Show();
        }

        //"Task"- option
        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelMentor.Controls.Clear();
            Height = StandartHeight;
            //set static items
            DataGridView dgwMentorTasks = new DataGridView();
            dgwMentorTasks.Top = 3;
            dgwMentorTasks.Left = 3;
            dgwMentorTasks.Width = 545;
            dgwMentorTasks.Height = 257;

            //add static data
            PanelMentor.Controls.Add(dgwMentorTasks);
        }


        //"Group"- option
        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelMentor.Controls.Clear();
            Height = StandartHeight;
            //set static items
            DataGridView dgwMentorGroup = new DataGridView();
            dgwMentorGroup.Top = 3;
            dgwMentorGroup.Left = 3;
            dgwMentorGroup.Width = 545;
            dgwMentorGroup.Height = 257;

            //add static data
            PanelMentor.Controls.Add(dgwMentorGroup);
        }

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

        // shows Colleagues 
        private void colleaguesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelMentor.Controls.Clear();
            Height = StandartHeight;

            //set static items
            DataGridView dgwMentorTeachersList = new DataGridView();
            dgwMentorTeachersList.Top = 30;
            dgwMentorTeachersList.Left = 3;
            dgwMentorTeachersList.Width = 240;
            dgwMentorTeachersList.Height = 230;

            DataGridView dgwMentorsList = new DataGridView();
            dgwMentorsList.Top = 30;
            dgwMentorsList.Left = 305;
            dgwMentorsList.Width = 240;
            dgwMentorsList.Height = 230;


            Label lblMentorTeachersList = new Label();
            lblMentorTeachersList.Left = 3;
            lblMentorTeachersList.Top = 10;
            lblMentorTeachersList.ForeColor = ForeColor;
            lblMentorTeachersList.Text = "Teachers List:";


            Label lblMentorsList = new Label();
            lblMentorsList.Left = 302;
            lblMentorsList.Top = 10;
            lblMentorsList.ForeColor = ForeColor;
            lblMentorsList.Text = "Mentors List:";

            //add static items
            PanelMentor.Controls.Add(dgwMentorTeachersList);
            PanelMentor.Controls.Add(dgwMentorsList);
            PanelMentor.Controls.Add(lblMentorsList);
            PanelMentor.Controls.Add(lblMentorTeachersList);

        }

        //Colleagues Lists
        private void toGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MentorMessageToGroup MessageToGroup = new MentorMessageToGroup();
            MessageToGroup.Show();
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

        //  "Library" option
        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelMentor.Controls.Clear();
            Height = StandartHeight;

            //set static items

            DataGridView dgwMentorLibrary = new DataGridView();
            dgwMentorLibrary.Top = 3;
            dgwMentorLibrary.Left = 3;
            dgwMentorLibrary.Width = 543;
            dgwMentorLibrary.Height = 137;

            Button btnMentorLibraryAdd = new Button();
            btnMentorLibraryAdd.Left = 4;
            btnMentorLibraryAdd.Top = 178;
            btnMentorLibraryAdd.Text = "Add";
            btnMentorLibraryAdd.Height = 25;
            btnMentorLibraryAdd.Width = 80;

            Button btnMentorLibraryDelete = new Button();
            btnMentorLibraryDelete.Left = 99;
            btnMentorLibraryDelete.Top = 178;
            btnMentorLibraryDelete.Text = "Delete";
            btnMentorLibraryDelete.Height = 25;
            btnMentorLibraryDelete.Width = 80;

            Button btnMentorLibraryDownload = new Button();
            btnMentorLibraryDownload.Left = 469;
            btnMentorLibraryDownload.Top = 178;
            btnMentorLibraryDownload.Text = "Download";
            btnMentorLibraryDownload.Height = 25;
            btnMentorLibraryDownload.Width = 80;

            //add static items
            PanelMentor.Controls.Add(dgwMentorLibrary);
            PanelMentor.Controls.Add(btnMentorLibraryAdd);
            PanelMentor.Controls.Add(btnMentorLibraryDelete);
            PanelMentor.Controls.Add(btnMentorLibraryDownload);

        }

    }
}
