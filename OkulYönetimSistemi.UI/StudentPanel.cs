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
    public partial class StudentPanel : Form
    {
        Student st;
        ServicePoint point;

        public StudentPanel()
        {
            InitializeComponent();
            point = new ServicePoint();
        }
        
        public StudentPanel(Student stu):this()
        {
            st = stu;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //if (System.Windows.Forms.Application.MessageLoop)
            //{
            //    System.Windows.Forms.Application.Exit();
            //}
            Main m = new Main();
            m.Show();
            this.Close();
        }

        private void StudentPanel_Load(object sender, EventArgs e)
        {
            lblUser.Text = st.ToString();
        }

        private void pctrExam_Click(object sender, EventArgs e)
        {
            ExamForm exForm = new ExamForm(st);
            exForm.Show();
        }

        private void pctrLecture_Click(object sender, EventArgs e)
        {
    //select * from Lectures where ID in ( select LectureID from ClassLectures where ClassID in (select ID from Classes where ID=2))
            StudentLectureForm slform = new StudentLectureForm(st);
            slform.Show();
        }
    }
}
