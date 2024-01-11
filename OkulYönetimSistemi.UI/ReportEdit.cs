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
    public partial class ReportEdit : Form
    {
        ICollection<ExamReport> exList;
        ICollection<Class> cList;
        ICollection<ClassLecture> clList;
        ICollection<Student> stuList;
        ICollection<Lecture> lecList;
        ServicePoint point;

        public ReportEdit()
        {
            InitializeComponent();
            point = new ServicePoint();

            exList = point.ExamReportService.ToList();
            cList = point.ClassService.ToList();
            stuList = point.StudentService.ToList();
            lecList = point.LectureService.ToList();
        }

        private void ReportEdit_Load(object sender, EventArgs e)
        {
            label2.Enabled = false;
            cmbDers.Enabled = false;

            foreach (ExamReport item in exList)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = item.Student.ToString();
                listItem.SubItems.Add(item.Exam.Name);
                listItem.SubItems.Add(item.Exam.ExamDate.ToString());
                listItem.SubItems.Add(item.Result.ToString());
                listItem.Tag = item;
                listViewSonuclar.Items.Add(listItem);
            }
            BoxDoldur();
        }
        public void BoxDoldur()
        {
            cmbSınıf.Items.Add("");
            foreach (Class item in cList)
            {
                cmbSınıf.Items.Add(item.Name);
            }
        }

        private void cmbSınıf_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 0;
            cmbDers.Items.Clear();

            object cc = cmbSınıf.SelectedItem;

            foreach (Class item in cList)
            {
                if (item.Name == cc)
                {
                    c = item.ID;
                }
            }
            // seçili sınıfa ait dersler listelenir
            //clList = point.ClassLectureService.toListClassLecture(c);

            //foreach (ClassLecture item in clList)
            //{
            //    cmbDers.Items.Add(item.Lecture.Name);
            //}
            cmbOgr.Items.Clear();
            cmbOgr.Text = "";
            foreach (Student item in stuList)
            {
                if (item.ClassID == c)
                {
                    cmbOgr.Items.Add(item.ToString());
                }
            }

        }

        private void cmbOgr_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 0;
            object cc = cmbOgr.SelectedItem;

            foreach (Student item in stuList)
            {
                if (item.ToString() == cc.ToString())
                {
                    c = item.ID;
                }
            }
            // c de şuan student id var 
            ICollection<ExamReport> xRepList = point.ExamReportService.toListExamReportStud(c);
            listViewSonuclar.Items.Clear();

            foreach (ExamReport item in xRepList)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = item.Student.ToString();
                listItem.SubItems.Add(item.Exam.Name);
                listItem.SubItems.Add(item.Exam.ExamDate.ToString());
                listItem.SubItems.Add(item.Result.ToString());
                listItem.Tag = item;
                listViewSonuclar.Items.Add(listItem);
            }
        }

        private void btnAllStudent_Click(object sender, EventArgs e)
        {
            cmbSınıf.Items.Clear();
            BoxDoldur();
            listViewSonuclar.Items.Clear();
            foreach (ExamReport item in exList)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = item.Student.ToString();
                listItem.SubItems.Add(item.Exam.Name);
                listItem.SubItems.Add(item.Exam.ExamDate.ToString());
                listItem.SubItems.Add(item.Result.ToString());
                listItem.Tag = item;
                listViewSonuclar.Items.Add(listItem);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            cmbSınıf.Enabled = false;
            cmbOgr.Enabled = false;
            cmbDers.Enabled = true;

            cmbDers.Items.Clear();

            foreach (Lecture item in lecList)
            {
                cmbDers.Items.Add(item);
            }
        }

        private void cmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cd = 0;

            int cc = cmbDers.SelectedIndex;

            // cc den index numarası geliyor,ilki için 0 seçilir
            foreach (Lecture item in lecList)
            {
                if (cc + 1 == item.ClassLectures.Count)
                {
                    cd = item.ID;
                    break;
                }
            }
            // cd de şuan lecture id var ,seçilen dersin id sini alınır

            //örnek olarak coğrafya seç,dersin id si  1002
            // select * from ExamReports where StudentID in ( select ID from Students where ClassID in (select ClassID from ClassLectures where LectureID=1002))

            ICollection<Student> exaStuList = point.StudentService.ReportExamListStu(cd);
            listViewSonuclar.Items.Clear();

            if (exaStuList == null || exaStuList.Count == 0) 
            {
                MessageBox.Show("Belirtilen kriterlerde listenelecek veri bulunamamıştır..");
            }
            else
            {
                foreach (Student items in exaStuList)
                {
                    ICollection<ExamReport> xRepList = point.ExamReportService.toListExamReportStud(items.ID);

                    foreach (ExamReport item in xRepList)
                    {
                        ListViewItem listItem = new ListViewItem();
                        listItem.Text = item.Student.ToString();
                        listItem.SubItems.Add(item.Exam.Name);
                        listItem.SubItems.Add(item.Exam.ExamDate.ToString());
                        listItem.SubItems.Add(item.Result.ToString());
                        listItem.Tag = item;
                        listViewSonuclar.Items.Add(listItem);
                    }
                }
            }
        }
    }
}
