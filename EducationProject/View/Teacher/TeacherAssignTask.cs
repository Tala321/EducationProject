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
    public partial class TeacherAssignTask : Form
    {
        EducationProjectEntities db = new EducationProjectEntities();

        //declare variables to hold id
        int GroupId;
        int StudentId;

        public TeacherAssignTask()
        {
            InitializeComponent();
            Extensions.FillCbxGroups(cbxTeacherAssignGroup);
            Extensions.FillCbxTask(cbxTeacherAssignTask);
        }

        //show students from the selected group
        private void cbxTeacherAssignGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            chbxTeacherAssignStudetnList.Items.Clear();
            foreach (var item in db.Groups.ToList())
            {
                if (item.GroupName == cbxTeacherAssignGroup.SelectedItem.ToString())
                {
                    GroupId = item.GroupId;
                    foreach (var item1 in db.Students.ToList())
                    {
                        if (item1.GroupId == GroupId)
                        {
                            chbxTeacherAssignStudetnList.Items.Add(item1.StudentName);
                        }

                    }
                }
            }
        }

        //set all items checked
        private void chbxTeacherAssignToAll_Click(object sender, EventArgs e)
        {
            if (chbxTeacherAssignToAll.Checked)
            {
                for (int i = 0; i < chbxTeacherAssignStudetnList.Items.Count; i++)
                {
                    chbxTeacherAssignStudetnList.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < chbxTeacherAssignStudetnList.Items.Count; i++)
                {
                    chbxTeacherAssignStudetnList.SetItemChecked(i, false);
                }
            }

        }

        //assign task to selected student
        private void btnAssignTaskStudent_Click(object sender, EventArgs e)
        {
            if (cbxTeacherAssignGroup.Text == null || cbxTeacherAssignTask.Text == null || chbxTeacherAssignStudetnList.Text == null)
            {
                foreach (var item1 in chbxTeacherAssignStudetnList.CheckedItems)
                {
                    foreach (var item in db.Students.ToList())
                    {
                        if (item.StudentName == item1.ToString())
                        {
                            StudentId = item.StudentId;
                            foreach (var item2 in db.Tasks.ToList())
                            {
                                if (item2.TaskName == cbxTeacherAssignTask.Text)
                                {
                                    AssignTask assign = new AssignTask()
                                    {
                                        StudentId = StudentId,
                                        TaskId = item2.TaskId
                                    };
                                    db.AssignTasks.Add(assign);
                                    db.SaveChanges();
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select all fields");
            }
        }
    }
}
