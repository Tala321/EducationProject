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
        //file dialog
        static OpenFileDialog fileDialog = new OpenFileDialog();

        //Choose and copy pdf file  to our PdfSource folder
        static public void DownloadPdf()
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //declare and set variables 
                string rootPath = Directory.GetCurrentDirectory().ToString();
                string PdfSource = Path.Combine(rootPath, "PdfSource");
                string ChosedFile = fileDialog.FileName;
                string FileName = Path.GetFileName(ChosedFile);

                //DataBase
                EducationProjectEntities db = new EducationProjectEntities();

                if (Path.GetExtension(FileName).ToString() == ".pdf")
                {
                    //copy to our pdfSource folder

                    foreach (var item in db.PdfSources.ToList())
                    {
                        if (FileName.ToString() == item.PdfSourceName)
                        {
                            MessageBox.Show(@"This file  is already exist in database, Please choose another one or cgange the name.");
                            break;
                        }
                        else
                        {
                            
                            PdfSource pdf = new PdfSource()
                            {
                                PdfSourceName = FileName.ToString()
                            };

                            File.Copy(ChosedFile, Path.Combine(PdfSource, FileName));
                            db.PdfSources.Add(pdf);
                            db.SaveChanges();
                        }

                    }

                   
                }
                else
                {
                    //if fileExtension isn't pdf

                    MessageBox.Show("Please select a pdf file");
                }
            }
        }
    }
}
