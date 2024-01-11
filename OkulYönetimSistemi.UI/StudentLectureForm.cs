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
    public partial class StudentLectureForm : Form
    {
        ServicePoint point;
        Student st;

        public StudentLectureForm()
        {
            InitializeComponent();
            point = new ServicePoint();
        }

        public StudentLectureForm(Student stu):this()
        {
            st = stu;
        }
        private void StudentLectureForm_Load(object sender, EventArgs e)
        {
            // Manşet
            Student stlist = point.StudentService.FindById(st.ID);

            label1.Text = stlist.ToString();
            label2.Text = stlist.ClassID + ". Sınıf";
            label3.Text = stlist.BirthDate.ToString();
            label4.Text = stlist.IsActive.ToString();
            //---Manşet--------------------------------//

            ICollection<Lecture> lecList = point.LectureService.PanelLectureList(st.ID);
            ICollection<ExamReport> xRepList = point.ExamReportService.toListExamReportStud(st.ID);

            listLectureResult.Items.Clear();

            if (xRepList.Count == 0) 
            {
                foreach (Lecture item in lecList)
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = item.Name;
                    li.SubItems.Add("-1");
                    li.SubItems.Add("null");
                    li.SubItems.Add("null");
                    li.SubItems.Add("null");
                    li.Tag = item;
                    listLectureResult.Items.Add(li);
                }
            }
            else
            {
                // ders e ait sınav bilgisi varsa kontrolü buradan yapılır
                foreach (ExamReport item in xRepList)
                {
                    foreach (Lecture items in lecList)
                    {
                        ListViewItem listItem = new ListViewItem();
                        listItem.Text = items.Name;
                        //listItem.Text = item.Student.ToString();

                        if (item.Exam.Name == items.Name) 
                        {
                            listItem.SubItems.Add(item.Result.ToString());
                            //vize 2 veya final sınavına girdiyse buradan bir kontrol daha yapılır
                            listItem.SubItems.Add("-");
                            listItem.SubItems.Add("-");
                            //bu kısımda ise servislerde yazılmış bir method ile hesaplanmış veri çağırılır 
                            // ve bu kısımda "ortalama" hanesine veri yazdırılır
                            listItem.SubItems.Add("-");
                        }
                        else
                        {
                            listItem.SubItems.Add("-1");
                            listItem.SubItems.Add("null");
                            listItem.SubItems.Add("null");
                            listItem.SubItems.Add("null");
                        }

                        listItem.Tag = item;
                        listLectureResult.Items.Add(listItem);
                    }
                }
            }
        }
    }
}
