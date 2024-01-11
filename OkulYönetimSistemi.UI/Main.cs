using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OkulYönetimSistemi.BL.BaseServices;

namespace OkulYönetimSistemi.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 0.9)
            {
                this.Opacity += 0.02;
            }
            else
            {
                tmr.Stop();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.06;
            tmr.Start();
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, this.Width, this.Height);
            Region region = new Region(path);
            this.Region = region;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        // asıl kısım
        ServicePoint point = new ServicePoint();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (point.TeacherService.Login(txtUserName.Text,txtPassword.Text) != null)
            {
                // teacherform un yapıcı methoduna buradan,giren kişinin verilerini gönderiyoruz
                TeacherForm tcForm = new TeacherForm(point.TeacherService.Login(txtUserName.Text,txtPassword.Text));
                tcForm.Show();
                this.Hide();
            }
            else if (point.StudentService.Login(txtUserName.Text,txtPassword.Text) != null)
            {
                //student panel eklendikten sonra ilk olarak examform u açmıyoruz artık
                //ExamForm exForm = new ExamForm(point.StudentService.Login(txtUserName.Text, txtPassword.Text));
                //exForm.Show();
                StudentPanel spanel = new StudentPanel(point.StudentService.Login(txtUserName.Text, txtPassword.Text));
                spanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş yapılamaz..");
            }
        }
    }
}
