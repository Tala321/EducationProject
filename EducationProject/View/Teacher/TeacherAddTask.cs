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

        public TeacherAddTask()
        {
            InitializeComponent();
            dgwAddTasksList.DataSource = db.Tasks.ToList();
            Extensions.FillWithCategories(cbxTeacherAddTaskCategory);
        }

        //Adds a task to the database
        private void btnTeacherAddTaskAdd_Click(object sender, EventArgs e)
        {
            Task task = new Task()
            {
                TaskName = tbxTeacherAddTaskName.Text,
                TaskUrl = tbxTeacherAddTaskUrl.Text,
                TaskStartDate = tbxTeacherAddTaskStartDate.Text,
                TaskDuration = Convert.ToInt32(tbxTeacherAddTaskDuration.Text),
                TaskDetails = tbxTeacherAddTaskDetails.Text,
                TaskCategoryId = Convert.ToInt32(cbxTeacherAddTaskCategory.Text)
            };
           TeacherForm.btnTeacherAddTask.Enabled = true;
            db.Tasks.Add(task);
            db.SaveChanges();
            dgwAddTasksList.DataSource = db.Tasks.ToList();
        }

        //Enables add button after closing
        private void TeacherAddTask_FormClosed(object sender, FormClosedEventArgs e)
        {
            TeacherForm.btnTeacherAddTask.Enabled = true;
        }
    }
}
