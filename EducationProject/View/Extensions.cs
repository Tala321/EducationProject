using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace EducationProject
{
    static class Extensions
    {
        static string rootPath;
        static string PdfSource;
        static string ChosedFile;
        static string FileName;
        static string FolderName;

       
        static OpenFileDialog fileDialog = new OpenFileDialog();


        ////////  //Teacher extensions//  ///////////

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

        //Chooses a folder  where to download a pdf
        static public void DownloadPdf(string _SourceFileName)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();

            if (folder.ShowDialog() == DialogResult.OK)
            {
                rootPath = Directory.GetCurrentDirectory().ToString();
                FolderName = folder.SelectedPath.ToString();
                PdfSource = Path.Combine(rootPath, "PdfSource");
                File.Copy(Path.Combine(PdfSource, _SourceFileName), Path.Combine(FolderName, _SourceFileName));
                MessageBox.Show("The file downloaded successfully");
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


         //"Task"- option//

        //Shows task info
        static public void ShowTaskInfo(int _TaskId )
        {
            EducationProjectEntities db = new EducationProjectEntities();

            foreach (var item in db.Tasks.ToList())
            {
                if(item.TaskId== _TaskId)
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
            }
        }

        //Deletes Task from the database
        static public void DeleteTask(int _TaskId)
        {
            EducationProjectEntities db = new EducationProjectEntities();

            foreach (var item in db.Tasks.ToList())
            {
                if(item.TaskId== _TaskId)
                {
                    db.Tasks.Remove(item);
                    db.SaveChanges();
                }

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


        //"Mentor info","Groups","Assign Task" - options//
        
        //Fills a combo box with the groups names
        static public void FillCbxGroups(ComboBox _cbx)
        {
            EducationProjectEntities db = new EducationProjectEntities();

            foreach (var item in db.Groups.ToList())
            {
                _cbx.Items.Add(item.GroupName);
            }
        }

        ////////  //End Teacher//  ///////////
    }
}
