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
    public partial class TeacherTranscript : Form
    {
        EducationProjectEntities db = new EducationProjectEntities();

        //Holds a Task Id
        int assignTaskId;

        public TeacherTranscript()
        {
            InitializeComponent();
        }

        private void TeacherAssignedTasks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'educationProjectDataSet3.AssignTasks' table. You can move, or remove it, as needed.
            this.assignTasksTableAdapter.Fill(this.educationProjectDataSet3.AssignTasks);
            // TODO: This line of code loads data into the 'educationProjectDataSet.Transcripts' table. You can move, or remove it, as needed.
            ColumnEditStatus();
        }

        //Sets edit edit status of columns
        private void ColumnEditStatus()
        {
            dgwTeacherTranscript.Columns[0].ReadOnly = true;
            dgwTeacherTranscript.Columns[1].ReadOnly = true;
            dgwTeacherTranscript.Columns[2].ReadOnly = true;
        }


        //Gets clicked AssignTaskId 
        private void dgwTeacherTranscript_Click(object sender, EventArgs e)
        {
            assignTaskId = Convert.ToInt32(dgwTeacherTranscript.CurrentRow.Cells[0].Value);
        }

        //Adds a point to the clicked task
        private void btnTeacherTaskPointAdd_Click(object sender, EventArgs e)
        {
            foreach (var item in db.AssignTasks.ToList())
            {
                if (tbxTeacherTaskPoint.Text.All(char.IsDigit))
                {
                    if (Convert.ToInt32(tbxTeacherTaskPoint.Text)<101)
                    {
                        if (item.AssignTaskId == assignTaskId)
                        {
                            item.TaskPoint = Convert.ToInt32(tbxTeacherTaskPoint.Text);
                            db.SaveChanges();
                            dgwTeacherTranscript.DataSource = db.AssignTasks.ToList();
                            tbxTeacherTaskPoint.Text = "";
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Entered value should be between 0 and 100");
                        break;
                    }                 
                }
                else
                {
                    MessageBox.Show("Entered parameter isn't a number or  field is null");
                    break;
                }
            }
        }
    }
}
