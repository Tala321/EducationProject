﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using EducationProject.View.Teacher;
using EducationProject.View.Student;
using EducationProject.View.Mentor;
using EducationProject.View;


namespace EducationProject
{
    static class Extensions
    {
        static string rootPath;
        static string PdfSource;
        static string ChosedFile;
        static string FileName;
        static string FolderName;
        static int TeacherId;


        static OpenFileDialog fileDialog = new OpenFileDialog();


        ////////  //Teacher extensions//  ///////////



        //Chooses a folder  where to download a pdf
        static public void DownloadPdf(string _SourceFileName)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();

            if (folder.ShowDialog() == DialogResult.OK)
            {
                rootPath = Directory.GetCurrentDirectory().ToString();
                FolderName = folder.SelectedPath.ToString();
                PdfSource = Path.Combine(rootPath, "PdfSource");
                if (File.Exists(Path.Combine(FolderName, _SourceFileName)))
                {
                    MessageBox.Show("This file is already exist  in this folder");
                }
                else
                {
                    File.Copy(Path.Combine(PdfSource, _SourceFileName), Path.Combine(FolderName, _SourceFileName));
                    MessageBox.Show("The file downloaded successfully");
                }
            }
        }

        //Deletes a pdf from the source folder
        static public void DeletePdf(string _SourceFileName)
        {
            rootPath = Directory.GetCurrentDirectory().ToString();
            PdfSource = Path.Combine(rootPath, "PdfSource");
            File.Delete(Path.Combine(PdfSource, _SourceFileName));
            MessageBox.Show("The file Deleted");
        }




        //Deletes Task from the database
        static public void DeleteTask(int _TaskId)
        {
            EducationProjectEntities db = new EducationProjectEntities();

            try
            {
                foreach (var item in db.Tasks.ToList())
                {
                    if (item.TaskId == _TaskId)
                    {
                        db.Tasks.Remove(item);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You can't delete this task , because it has been assigned to a student");
            }
        }

        //Fills a combo box with the task categories
        static public void FillWithCategories(ComboBox _cbx)
        {
            EducationProjectEntities db = new EducationProjectEntities();

            foreach (var item in db.TaskCategories.ToList())
            {
                _cbx.Items.Add(item.TaskCategoryId);
            }
        }

        //Fills a combo box With the tasks names
        static public void FillCbxTask(ComboBox _cbx)
        {
            EducationProjectEntities db = new EducationProjectEntities();

            foreach (var item in db.Tasks.ToList())
            {
                _cbx.Items.Add(item.TaskName);
            }
        }


        //"Mentor info","Groups","Assign Task" ,"My Messages" - options//

        //Fills a combo box with the groups names
        static public void FillCbxGroups(ComboBox _cbx)
        {
            EducationProjectEntities db = new EducationProjectEntities();

            foreach (var item1 in db.Teachers.ToList())
            {
                if(item1.TeacherEmail== WelcomeScreen.UserEmail)
                {
                    TeacherId = item1.TeacherId;
                }
            }
            foreach (var item in db.Groups.Where(x=> x.TeacherId== TeacherId).ToList())
            {
                _cbx.Items.Add(item.GroupName);
            }
        }

        //Fills a combo box with the Mentors emails
        static public void FillCbxMentor(ComboBox _cbx)
        {
            EducationProjectEntities db = new EducationProjectEntities();

            foreach (var item in db.Mentors.ToList())
            {
                _cbx.Items.Add(item.MentorEmail);
            }
        }

        //"My messages" - option//

        //Fills a combo box with the Colleagues email
        static public void FillWithColleaguesEmails(ComboBox _cbx)
        {
            EducationProjectEntities db = new EducationProjectEntities();

            foreach (var item in db.Teachers.Where(x => x.TeacherEmail != WelcomeScreen.UserEmail).ToList())
            {
                _cbx.Items.Add(item.TeacherEmail);
            }
        }

        ////////  //End Teacher//  ///////////


        ////////  //For all Forms extensions//  ///////////

        //Sends message to the chose person
        public static void SendMessage(string _to, string _title, string _body)
        {
            EducationProjectEntities db = new EducationProjectEntities();

            Message message = new Message()
            {
                MessageFrom = WelcomeScreen.UserEmail,
                MessageTo = _to,
                MessageTitle = _title,
                MessageBody = _body

            };

            db.Messages.Add(message);
            db.SaveChanges();
        }

        //Cheks if all fields filled in
        public static bool CheckFields(TextBox _title, TextBox _body, ComboBox _cbx)
        {
            if (_title.Text == "" || _body.Text == "" || _cbx.Text == "")
            {

                return false;
            }
            else
            {
                return true;
            }
        }

        //Clears fields after sending a message ,only in Colleague and Group options
        public static void ClearFields(TextBox _title, TextBox _body, ComboBox _cbx)
        {
            _title.Text = "";
            _body.Text = "";
            _cbx.Text = "";
        }

        //Show clicked inbox/sent message
        static public void ShowMessageInfo(DataGridView _dgw)
        {
            MessageBox.Show(
       "MESSAGE INFO" + Environment.NewLine +
        Environment.NewLine +
      "Message Id: " + _dgw.CurrentRow.Cells[0].Value.ToString() +
       Environment.NewLine +
       Environment.NewLine +
      "From: " + _dgw.CurrentRow.Cells[1].Value.ToString() +
       Environment.NewLine +
       Environment.NewLine +
       "To: " + _dgw.CurrentRow.Cells[2].Value.ToString() +
       Environment.NewLine +
       Environment.NewLine +
      "Title: " + _dgw.CurrentRow.Cells[3].Value.ToString() +
       Environment.NewLine +
       Environment.NewLine +
       "Body: " + _dgw.CurrentRow.Cells[4].Value.ToString()
   );
        }

        //"Library"- option//

        //Chooses and copy a pdf file  to the our PdfSource folder
        static public void AddPdfFile()
        {

            EducationProjectEntities db = new EducationProjectEntities();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //set paths
                rootPath = Directory.GetCurrentDirectory().ToString();
                PdfSource = Path.Combine(rootPath, "PdfSource");
                ChosedFile = fileDialog.FileName;
                FileName = Path.GetFileName(ChosedFile);

                if (Path.GetExtension(FileName) == ".pdf")
                {

                    //Check if  this name is already exist in the database
                    if (db.PdfSources.All(e => e.PdfSourceName != FileName))
                    {
                        PdfSource pdf = new PdfSource()
                        {
                            PdfSourceName = FileName.ToString()
                        };

                        //Copy the file to the PdfSource folder
                        File.Copy(ChosedFile, Path.Combine(PdfSource, FileName));

                        db.PdfSources.Add(pdf);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("This name is exist in the database, please change the name or choose another one");
                    }
                }
                else
                {
                    MessageBox.Show("Selected file must be in a pdf format");
                }
            }
        }

        //"Task"- option//

        //Shows task info
        static public void ShowTaskInfo(int _TaskId)
        {
            EducationProjectEntities db = new EducationProjectEntities();

            foreach (var item in db.Tasks.ToList())
            {
                if (item.TaskId == _TaskId)
                {
                    MessageBox.Show(
                  "TASK INFO" + Environment.NewLine +
                  Environment.NewLine +
                  "Id:" + "" + item.TaskId + Environment.NewLine +
                   Environment.NewLine +
                  "Name:" + "" + item.TaskName + Environment.NewLine +
                   Environment.NewLine +
                  "Url:" + "" + item.TaskUrl + Environment.NewLine +
                   Environment.NewLine +
                  "Start Date:" + "" + item.TaskStartDate + Environment.NewLine +
                   Environment.NewLine +
                  "Task Duration:" + "" + item.TaskDuration + Environment.NewLine +
                   Environment.NewLine +
                  "Details:" + "" + item.TaskDetails + Environment.NewLine +
                   Environment.NewLine +
                  "Category Id:" + "" + item.TaskCategoryId + Environment.NewLine
                  );


                }
                StudentForm.dgwStudentAllTasks.Enabled = true;
                TeacherForm.dgwTeacherAllTasks.Enabled = true;
                MentorForm.dgwMentorTasks.Enabled = true;
            }
        }


       
        ////////  //End "For all Forms extensions"//  ///////////




        ////////  //Studen extensions//  ///////////

        //Fills a combo box with the Groupmates email
        static public void FillWithGroupmatesEmails(ComboBox _cbx)
        {
            EducationProjectEntities db = new EducationProjectEntities();
            foreach (var item in db.Students.Where(x => x.GroupId == StudentForm.GroupId && x.StudentEmail != WelcomeScreen.UserEmail).ToList())
            {
                _cbx.Items.Add(item.StudentEmail);
            }
        }

        ////////  //End Student//  ///////////


        ////////  //Mentor extensions//  ///////////

        //Fills a combo box with the Students email
        static public void FillWithStudentsEmails(ComboBox _cbx)
        {
            EducationProjectEntities db = new EducationProjectEntities();

            foreach (var item in db.Groups.Where(x => x.GroupId == MentorForm.GroupId).ToList())
            {
                _cbx.Items.Add(item.GroupEmail);
            }    
        }


        //Fills a combo box with the Mentors email
        static public void FillWithMentorsEmails(ComboBox _cbx)
        {
            EducationProjectEntities db = new EducationProjectEntities();

            foreach (var item in db.Mentors.Where(x=>x.MentorEmail != WelcomeScreen.UserEmail).ToList())
            {
                _cbx.Items.Add(item.MentorEmail);
            }
        }

        //Fills a combo box with the Colleagues email
        static public void FillWithTeachersEmails(ComboBox _cbx)
        {
            EducationProjectEntities db = new EducationProjectEntities();
            foreach (var item1 in db.Teachers.ToList())
            {
                foreach (var item in db.Groups.Where(x => x.GroupId == MentorForm.GroupId).ToList())
                {
                    if (item1.TeacherId== item.TeacherId)
                    {
                        _cbx.Items.Add(item1.TeacherEmail);
                    }                   
                }
            }
        }
        ////////  //End Mentor//  ///////////
    }
}
