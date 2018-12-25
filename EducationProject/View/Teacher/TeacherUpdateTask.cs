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
    public partial class TeacherUpdateTask : Form
    {
        EducationProjectEntities db = new EducationProjectEntities();

        //Declares variables to hold TaskId
        int Taskid;

        public TeacherUpdateTask()
        {
            InitializeComponent();
            dgwUpdateTasksList.DataSource = db.Tasks.ToList();
            Extensions.FillWithCategories(cbxTeacherUpdateTaskCategory);
            dgwUpdateTasksList.Click += GetTaskInfo;
        }

        //Gets selected task info
        private void GetTaskInfo(object sender, EventArgs e)
        {
            Taskid = Convert.ToInt32(dgwUpdateTasksList.CurrentRow.Cells[0].Value);
            tbxTeacherUpdateTaskName.Text = dgwUpdateTasksList.CurrentRow.Cells[1].Value.ToString();
            tbxTeacherUpdateTaskUrl.Text = dgwUpdateTasksList.CurrentRow.Cells[2].Value.ToString();
            tbxTeacherUpdateTaskStartDate.Text = dgwUpdateTasksList.CurrentRow.Cells[3].Value.ToString();
            tbxTeacherUpdateTaskDuration.Text = dgwUpdateTasksList.CurrentRow.Cells[4].Value.ToString();
            tbxTeacherUpdateTaskDetails.Text = dgwUpdateTasksList.CurrentRow.Cells[5].Value.ToString();
            cbxTeacherUpdateTaskCategory.Text = dgwUpdateTasksList.CurrentRow.Cells[6].Value.ToString();

        }


        //Updates task
        private void btnTeacherUpdateTaskAdd_Click(object sender, EventArgs e)
        {
            TeacherForm teacher = new TeacherForm();
            if (CheckFields())
            {
                if (tbxTeacherUpdateTaskDuration.Text.All(char.IsDigit))
                {
                    foreach (var item in db.Tasks.ToList())
                    {


                        if (item.TaskId == Taskid)
                        {
                            item.TaskName = tbxTeacherUpdateTaskName.Text;
                            item.TaskUrl = tbxTeacherUpdateTaskUrl.Text;
                            item.TaskStartDate = tbxTeacherUpdateTaskStartDate.Text;
                            item.TaskDuration = Convert.ToInt32(tbxTeacherUpdateTaskDuration.Text);
                            item.TaskDetails = tbxTeacherUpdateTaskDetails.Text;
                            item.TaskCategoryId = Convert.ToInt32(cbxTeacherUpdateTaskCategory.Text);
                            dgwUpdateTasksList.DataSource = db.Tasks.ToList();

                            db.SaveChanges();
                            TeacherForm.btnTeacherUpdateTask.Enabled = true;
                            CleanFields();
                            break;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Please enter a valid datatype: Duration");
                }
            }
            else
            {
                MessageBox.Show("Please select a task to update");
            }
        }

        //Enables add button after closing
        private void TeacherUpdateTask_FormClosed(object sender, FormClosedEventArgs e)
        {
            TeacherForm.btnTeacherUpdateTask.Enabled = true;
        }

        //Cleans All fields after adding  a task
        private void CleanFields()
        {
            tbxTeacherUpdateTaskDetails.Text = "";
            tbxTeacherUpdateTaskDuration.Text = "";
            tbxTeacherUpdateTaskName.Text = "";
            tbxTeacherUpdateTaskStartDate.Text = "";
            tbxTeacherUpdateTaskUrl.Text = "";
            cbxTeacherUpdateTaskCategory.Text = null;
        }

        //Checks if all fields filled in
        private bool CheckFields()
        {
            if (tbxTeacherUpdateTaskName.Text == "" || tbxTeacherUpdateTaskUrl.Text == "" || tbxTeacherUpdateTaskStartDate.Text == "" || tbxTeacherUpdateTaskDuration.Text == "" || tbxTeacherUpdateTaskDetails.Text == "" || cbxTeacherUpdateTaskCategory.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
