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

        //Choose and copy pdf file  to our PdfSource folder
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
                        MessageBox.Show("This name exist in the database, please change the name or choose another one");
                    }
                }
                else
                {
                    MessageBox.Show("Selected file must be in a pdf format");
                }
            }
        }

        //Choose folder  where to download pdf
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

        //delete pdf from source folder
        static public void DeletePdf(string _SourceFileName)
        {
            rootPath = Directory.GetCurrentDirectory().ToString();
            PdfSource = Path.Combine(rootPath, "PdfSource");
            File.Delete(Path.Combine(PdfSource, _SourceFileName));
            MessageBox.Show("The file Deleted");
        }
    }
}
