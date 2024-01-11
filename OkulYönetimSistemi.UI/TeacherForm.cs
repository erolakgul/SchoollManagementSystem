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
    public partial class TeacherForm : Form
    {
        TeacherEdit te;
        StudentEdit se;
        LectureEdit le;
        ExamEdit ee;
        AttendanceEdit ae;
        ReportEdit re;
        Teacher t;

        public TeacherForm()
        {
            InitializeComponent();
            //eğer hiç açılmamış sayfalar var ise, kapat butonuna tıkladığımızda hata verecektir
            //bunu önlemek içinde; yapıcı method içinde hali hazırda bir nesne açarız
            te = new TeacherEdit();
            se = new StudentEdit();
            le = new LectureEdit();
            ee = new ExamEdit();
            ae = new AttendanceEdit();
            re = new ReportEdit();
        }
        public TeacherForm(Teacher tea):this() // methoda nesneyi göndermiş olduk
        {
            //main methodunun login işlemi ile teacherform a gönderilen txtuser ve password burada yakalanır
            t = tea;
            //form load da da t.tostring() ile teacher sınıfındaki overload methodtan dönen isim soyisim alınır
        }

        private void pctrTeacher_Click(object sender, EventArgs e)
        {
            te = new TeacherEdit();
            te.Show();
        }

        private void pctrStudent_Click(object sender, EventArgs e)
        {
            se = new StudentEdit();
            se.Show();
        }

        private void pctrLecture_Click(object sender, EventArgs e)
        {
            le = new LectureEdit();
            le.Show();
        }

        private void pctrExam_Click(object sender, EventArgs e)
        {
            ee = new ExamEdit();
            ee.Show();
        }

        private void pctrAttendance_Click(object sender, EventArgs e)
        {
            ae = new AttendanceEdit();
            ae.Show();
        }

        private void pctrReports_Click(object sender, EventArgs e)
        {
            re = new ReportEdit();
            re.Show();
        }

        private void btnTFCancel_Click(object sender, EventArgs e)
        {
            te.Close();
            se.Close();
            le.Close();
            ee.Close();
            ae.Close();
            re.Close();
            this.Close();
            Main m = new Main();
            m.Show();
        }

        ServicePoint point = new ServicePoint();
        
        private void TeacherForm_Load(object sender, EventArgs e)
        {
            // 8 haziran 2016 22:32 burada kaldın
            //teacher sınıfında tostring methodu overload edilmiştir,isim ve soyisim döndürür.
            lblUser.Text = t.ToString();   
        }

    }
}
