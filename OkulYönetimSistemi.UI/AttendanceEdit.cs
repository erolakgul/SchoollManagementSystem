using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OkulYönetimSistemi.BL.BaseServices;
using OkulYönetimSistemi.Entity.Entities;

namespace OkulYönetimSistemi.UI
{
    public partial class AttendanceEdit : Form
    {
        ServicePoint point;

        public AttendanceEdit()
        {
            InitializeComponent();
            point = new ServicePoint();
        }

        private void AttendanceEdit_Load(object sender, EventArgs e)
        {
            FillList();
            AttUpdate();
        }
        private void FillList()
        {
            listClass.Items.Clear();
            listTea.Items.Clear();
            ICollection<Class> cList = point.ClassService.ToList();
            foreach (Class item in cList)
            {
                listClass.Items.Add(item);
            }

            ICollection<Teacher> tList = point.TeacherService.ToList();
            foreach (Teacher item in tList)
            {
                listTea.Items.Add(item);
            }

            for (int i = 1; i < 4; i++)
            {
                cmbHours.Items.Add(i);
            }

        }
        private void AttUpdate()
        {
            listAtt.Items.Clear();

            ICollection<Attendance> atList = point.AttendanceService.ToList();
            foreach (Attendance item in atList)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.Date.ToString();
                li.SubItems.Add(item.Teacher.ToString());
                li.SubItems.Add(item.ClassLecture.Class.ToString());
                li.SubItems.Add(item.ClassLecture.Lecture.ToString());
                li.SubItems.Add(item.LectureHours.ToString());
                li.Tag = item;

                listAtt.Items.Add(li);
            }
        }
        private void StUpdate()
        {
            listStu.Items.Clear();
            listStuAtt.Items.Clear();

            //burada bir sıkıntı var
            Attendance att = listAtt.FocusedItem.Tag as Attendance;
            ICollection<Attendance> atList = point.AttendanceService.ToList();
            Attendance at = atList.Where(x => x.ID == att.ID).FirstOrDefault();
            ICollection<Student> atStuList = at.Students;

            foreach (Student item in atStuList)
            {
                listStuAtt.Items.Add(item);
            }

            ICollection<Student> Stulist = at.ClassLecture.Class.Students;

            foreach (Student item in Stulist)
            {
                if (!atStuList.Any(x => x.ID == item.ID)) listStu.Items.Add(item);
            }
        }

        private void listClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            listClassLectures.Items.Clear();
            Class cl = listClass.SelectedItem as Class;

            ICollection<ClassLecture> lList = point.ClassLectureService.ToList();
            foreach (ClassLecture item in lList)
            {
                if (cl.ID == item.ClassID) listClassLectures.Items.Add(item.Lecture);
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            Class cl = listClass.SelectedItem as Class;
            Lecture lec = listClassLectures.SelectedItem as Lecture;
            Teacher tea = listTea.SelectedItem as Teacher;
            int id = 0;
            ICollection<ClassLecture> clist = point.ClassLectureService.ToList();
            foreach (ClassLecture item in clist)
            {
                if (cl.ID == item.ClassID && lec.ID == item.LectureID) id = item.ID;
            }

            Attendance at = new Attendance()
            {
                Date = Convert.ToDateTime(txtDate.Text),
                LectureHours = Convert.ToInt32(cmbHours.SelectedItem),
                TeacherID = tea.ID,
                ClassLectureID = id
            };

            txtStatus.Text = point.AttendanceService.Insert(at).Message;
            AttUpdate();
        }

        private void btnClassEdit_Click(object sender, EventArgs e)
        {
            Class cl = listClass.SelectedItem as Class;
            Lecture lec = listClassLectures.SelectedItem as Lecture;
            Teacher tea = listTea.SelectedItem as Teacher;
            int id = 0;
            ICollection<ClassLecture> clist = point.ClassLectureService.ToList();
            foreach (ClassLecture item in clist)
            {
                if (cl.ID == item.ClassID && lec.ID == item.LectureID) id = item.ID;
            }

            Attendance at = listAtt.FocusedItem.Tag as Attendance;
            at.Date = Convert.ToDateTime(txtDate.Text);
            at.LectureHours = Convert.ToInt32(cmbHours.SelectedItem);
            at.TeacherID = tea.ID;
            at.ClassLectureID = id;

            txtStatus.Text = point.AttendanceService.Update(at).Message;
            AttUpdate();
        }

        private void btnClassDelete_Click(object sender, EventArgs e)
        {
            Attendance at = listAtt.FocusedItem.Tag as Attendance;
            txtStatus.Text = point.AttendanceService.Delete(at.ID).Message;
            AttUpdate();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = listAtt;
            //tabControl1.Controls.Add(tabPage1);
            tabControl1.SelectedTab.Controls.Add(lv);
        }

        private void listAtt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAtt.SelectedItems.Count > 0)
            {
                StUpdate();
            }
        }

        private void btnAddStu_Click(object sender, EventArgs e)
        {
            if (listStu.SelectedItems.Count > 0)
            {
                Attendance at = listAtt.FocusedItem.Tag as Attendance;
                Student st = listStu.SelectedItem as Student;
                st.Attendances.Add(at);
                point.StudentService.Update(st);

            }
            StUpdate();
        }

        private void btnRemoveStu_Click(object sender, EventArgs e)
        {
            if (listStuAtt.SelectedItems.Count > 0)
            {
                Attendance at = listAtt.FocusedItem.Tag as Attendance;
                Student st = listStuAtt.SelectedItem as Student;
                point.StudentService.DeleteAtt(st, at.ID);

            }
            StUpdate();
        }

        private void btnAllStu_Click(object sender, EventArgs e)
        {
            Attendance att = listAtt.FocusedItem.Tag as Attendance;
            ICollection<Attendance> atList = point.AttendanceService.ToList();
            Attendance at = atList.Where(x => x.ID == att.ID).FirstOrDefault();


            ICollection<Student> Stulist = at.ClassLecture.Class.Students;

            foreach (Student item in Stulist)
            {
                if (!at.Students.Any(x => x.ID == item.ID))
                {
                    item.Attendances.Add(at);
                    point.StudentService.Update(item);
                }
            }
            StUpdate();
        }
    }
}
