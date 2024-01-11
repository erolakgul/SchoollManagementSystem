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
    public partial class ExamForm : Form
    {
        Student st;
        ServicePoint point;
        ICollection<Exam> exList;

        public ExamForm()
        {
            InitializeComponent();
            point = new ServicePoint();
        }
        public ExamForm(Student stud)
            : this()
        {
            st = stud;
            exList = point.StudentService.ExamStu(st);
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            boxWel.Text = st.ToString();
            if (exList.Count > 0)
            {
                foreach (Exam ex in exList)
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = ex.Name;
                    li.SubItems.Add(ex.ClassLecture.Lecture.ToString());
                    li.SubItems.Add(ex.ExamDate.ToString());
                    li.SubItems.Add(ex.Duration.ToString());
                    li.Tag = ex;
                    listExam.Items.Add(li);

                    lbltime.Text = (ex.ExamDate.Minute - DateTime.Now.Minute).ToString();
                }
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            foreach (Exam item in exList)
            {
                lblSınav.Text = item.Name;

                if (item.ExamDate > DateTime.Now)
                {
                    label4.Text = "Sınav Tarihi   :";
                    lbltime.Text = item.ExamDate.ToString();

                    if (item.ExamDate.Month == DateTime.Now.Month && item.ExamDate.Day == DateTime.Now.Day && item.ExamDate.Hour == DateTime.Now.Hour)
                    {
                        if ((item.ExamDate.Minute - DateTime.Now.Minute) > 1)
                        {
                            label4.Text = "Kalan Süre     :";
                            lbltime.Text = (item.ExamDate.Minute - DateTime.Now.Minute).ToString() + " dk";
                        }
                        else if ((item.ExamDate.Minute - DateTime.Now.Minute) == 1)
                        {
                            label4.Text = "Kalan Süre     :";
                            lbltime.Text = (60 - (DateTime.Now.Second - item.ExamDate.Second)).ToString() + " sn";
                        }
                    }
                }

                if (item.ExamDate <= DateTime.Now)
                {
                    timer1.Stop();
                    StudentForm stForm = new StudentForm(st, item);
                    stForm.Show();
                    this.Hide();
                }
            }
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {

        }
    }
}
