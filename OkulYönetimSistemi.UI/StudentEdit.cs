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
    public partial class StudentEdit : Form
    {
        ServicePoint point;

        public StudentEdit()
        {
            InitializeComponent();
            point = new ServicePoint();
        }
        private void StudentEdit_Load(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void btnDeleteStu_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz ?", "", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                Student st = listStudent.SelectedItem as Student;
                txtStatus.Text = st.FirstName + "-" + point.StudentService.Delete(st.ID).Message;
                UpdateControls();
            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi..");
            }

        }

        private void btnUpdateStu_Click(object sender, EventArgs e)
        {
            Student st = listStudent.SelectedItem as Student;

            st.FirstName = txtStuName.Text;
            st.LastName = txtStuLastName.Text;
            st.IdentityNo = txtStuId.Text;
            st.BirthDate = txtStuBirth.Value;
            st.GuardianName = txtGuardName.Text;
            st.GuardianLastName = txtGuardLastName.Text;
            st.GuardianEmail = txtGuardMail.Text;
            st.GuardianPhone = txtGuardMobile.Text;
            st.HomePhone = txtHomePhone.Text;
            st.StudentNo = txtStuNo.Text;
            st.RegistrationTerm = txtStuRegTerm.Text;
            st.Address = txtStuAddress.Text;
            st.UserName = txtStuUser.Text;
            st.Password = txtStuPass.Text;

            MessageService stat = point.StudentService.Update(st);
            txtStatus.Text = stat.Message + "-" + st.FirstName;

            if (stat.ResultID > 0)
            {
                UpdateControls();
            }
        }

        private void btnAddStu_Click(object sender, EventArgs e)
        {

            if (txtStuName.Text == "" || txtStuLastName.Text == "" || txtStuId.Text == "" || txtStuBirth.Text == "" || txtGuardName.Text == "" || txtGuardLastName.Text == "" || txtGuardMobile.Text == "" || txtStuNo.Text == "" || txtStuRegTerm.Text == "" || txtStuAddress.Text == "" || txtStuUser.Text == "" || txtStuPass.Text == "" || txtSınıfId.Text == "") 
            {
                MessageBox.Show("Eksik yerleri doldurun lütfen...");
            }
            else
            {
                Student st = new Student()
                {
                    FirstName = txtStuName.Text,
                    LastName = txtStuLastName.Text,
                    IdentityNo = txtStuId.Text,
                    BirthDate = txtStuBirth.Value,
                    GuardianName = txtGuardName.Text,
                    GuardianLastName = txtGuardLastName.Text,
                    GuardianEmail = txtGuardMail.Text,
                    GuardianPhone = txtGuardMobile.Text,
                    HomePhone = txtHomePhone.Text,
                    StudentNo = txtStuNo.Text,
                    RegistrationDate = DateTime.Now,
                    RegistrationTerm = txtStuRegTerm.Text,
                    Address = txtStuAddress.Text,
                    UserName = txtStuUser.Text,
                    Password = txtStuPass.Text,
                    ClassID = int.Parse(txtSınıfId.Text)
                };

                MessageService stat = point.StudentService.Insert(st);
                txtStatus.Text = stat.Message + "-" + st.FirstName;

                if (stat.ResultID > 0)
                {
                    UpdateControls();
                }
            }
        }

        private void listStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listStudent.SelectedItems.Count > 0)
            {
                Student st = listStudent.SelectedItem as Student;
                txtStuName.Text = st.FirstName;
                txtStuLastName.Text = st.LastName;
                txtStuId.Text = st.IdentityNo;
                txtStuBirth.Value = st.BirthDate;
                txtGuardName.Text = st.GuardianName;
                txtGuardLastName.Text = st.GuardianLastName;
                txtGuardMobile.Text = st.GuardianPhone;
                txtGuardMail.Text = st.GuardianEmail;
                txtHomePhone.Text = st.HomePhone;
                txtStuNo.Text = st.StudentNo;
                txtStuRegTerm.Text = st.RegistrationTerm;
                txtStuAddress.Text = st.Address;
                txtStuUser.Text = st.UserName;
                txtStuPass.Text = st.Password;
                txtSınıfId.Text = Convert.ToString(st.ClassID);
            }
        }
        private void UpdateControls()
        {
            foreach (var item in tabPage1.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox txt = item as TextBox;
                    if (txt.Name != txtStatus.Name) txt.Clear();
                }
            }
            txtStuBirth.Value = DateTime.Now;
            listStudent.Items.Clear();

            ICollection<Student> listStu = point.StudentService.ToList();
            //ICollection<Student> listStu = point.StudentService.ToListStu();

            foreach (Student item in listStu)
            {
                listStudent.Items.Add(item);
            }
        }
    }
}
