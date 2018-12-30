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
    public partial class TeacherAddTask : Form
    {
        EducationProjectEntities db = new EducationProjectEntities();

        //Holds info
        DateTime date;

        public TeacherAddTask()
        {
            InitializeComponent();
            dgwAddTasksList.DataSource = db.Tasks.ToList();
            Extensions.FillWithCategories(cbxTeacherAddTaskCategory);
        }

        //Adds a task to the database
        private void btnTeacherAddTaskAdd_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                if (tbxTeacherAddTaskDuration.Text.All(char.IsDigit))
                {
                    if (DateTime.TryParse(tbxTeacherAddTaskStartDate.Text, out date))
                    {
                        Task task = new Task()
                        {
                            TaskName = tbxTeacherAddTaskName.Text,
                            TaskUrl = tbxTeacherAddTaskUrl.Text,
                            TaskStartDate= tbxTeacherAddTaskStartDate.Text,
                            TaskDuration = Convert.ToInt32(tbxTeacherAddTaskDuration.Text),
                            TaskDetails = tbxTeacherAddTaskDetails.Text,
                            TaskCategoryId = Convert.ToInt32(cbxTeacherAddTaskCategory.Text)
                        };
                        TeacherForm.btnTeacherAddTask.Enabled = true;
                        db.Tasks.Add(task);
                        db.SaveChanges();
                        CleanFields();
                        dgwAddTasksList.DataSource = db.Tasks.ToList();
                        MessageBox.Show("Successfully saved to the database");
                        MessageBox.Show("Please, refresh the main screen to see the changes");
                    }
                    else
                    {

                        MessageBox.Show("Please, Enter valid date: Start Date");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid datatype: Duration");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        //Enables add button after closing
        private void TeacherAddTask_FormClosed(object sender, FormClosedEventArgs e)
        {
            TeacherForm.btnTeacherAddTask.Enabled = true;
        }

        //Cleans All fields after adding  a task
        private void CleanFields()
        {
            tbxTeacherAddTaskDetails.Text = "";
            tbxTeacherAddTaskDuration.Text = "";
            tbxTeacherAddTaskName.Text = "";
            tbxTeacherAddTaskStartDate.Text = "";
            tbxTeacherAddTaskUrl.Text = "";
            cbxTeacherAddTaskCategory.Text = null;
        }

        //Checks if all fields filled in
        private bool CheckFields()
        {
            if (tbxTeacherAddTaskName.Text == "" || tbxTeacherAddTaskUrl.Text == "" || tbxTeacherAddTaskStartDate.Text == "" || tbxTeacherAddTaskDuration.Text == "" || tbxTeacherAddTaskDetails.Text == "" || cbxTeacherAddTaskCategory.Text == "")
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
