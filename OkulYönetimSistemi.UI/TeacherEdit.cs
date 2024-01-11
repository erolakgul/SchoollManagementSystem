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
    public partial class TeacherEdit : Form
    {
        ServicePoint point;

        public TeacherEdit()
        {
            InitializeComponent();
            point = new ServicePoint();
        }

        private void TeacherEdit_Load(object sender, EventArgs e)
        {
            UpdateControls();
        }
        private void UpdateControls()
        {
            foreach (var item in tabPage1.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox tx = item as TextBox;
                    tx.Clear();
                }
            }

            txtBirthDate.Value = DateTime.Now;

            ICollection<Teacher> tList = point.TeacherService.ToList();
            listTea.Items.Clear();
            foreach (Teacher item in tList)
            {
                listTea.Items.Add(item);
            }
        }

        private void btnAddTea_Click(object sender, EventArgs e)
        {
            
            Teacher tch = new Teacher()
            {
                FirstName = txtTeaName.Text,
                LastName = txtTeaLastName.Text,
                IdentityNo = txtTeaId.Text,
                BirthDate = txtBirthDate.Value,
                Mobile = txtTeaMobile.Text,
                HomePhone = txtTeaHomePhone.Text,
                Email = txtTeaEmail.Text,
                Address = txtTeaAddress.Text,
                UserName = txtTeaUser.Text,
                Password = txtTeaPass.Text
            };

            txtStatus.Text = point.TeacherService.Insert(tch).Message;
            UpdateControls();
            MessageBox.Show(tch.FirstName +" " + "Başarıyla kaydedildi..");
        }

        private void listTea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTea.SelectedItems.Count > 0)
            {
                Teacher tch = listTea.SelectedItem as Teacher;

                txtTeaName.Text = tch.FirstName;
                txtTeaLastName.Text = tch.LastName;
                txtTeaId.Text = tch.IdentityNo;
                txtBirthDate.Value = tch.BirthDate;
                txtTeaMobile.Text = tch.Mobile;
                txtTeaHomePhone.Text = tch.HomePhone;
                txtTeaEmail.Text = tch.Email;
                txtTeaAddress.Text = tch.Address;
                txtTeaUser.Text = tch.UserName;
                txtTeaPass.Text = tch.Password;

            }
        }

        private void btnUpdateTea_Click(object sender, EventArgs e)
        {
            if (listTea.SelectedItems.Count > 0)
            {
                Teacher tch = listTea.SelectedItem as Teacher;

                tch.FirstName = txtTeaName.Text;
                tch.LastName = txtTeaLastName.Text;
                tch.IdentityNo = txtTeaId.Text;
                tch.BirthDate = txtBirthDate.Value;
                tch.Mobile = txtTeaMobile.Text;
                tch.HomePhone = txtTeaHomePhone.Text;
                tch.Email = txtTeaEmail.Text;
                tch.Address = txtTeaAddress.Text;
                tch.UserName = txtTeaUser.Text;
                tch.Password = txtTeaPass.Text;

                txtStatus.Text = point.TeacherService.Update(tch).Message;
                UpdateControls();
            }
        }

        private void btnDeleteTea_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz ?", "", MessageBoxButtons.YesNo);

            if (onay == DialogResult.Yes)
            {
                if (listTea.SelectedItems.Count > 0)
                {
                    Teacher tch = listTea.SelectedItem as Teacher;
                    txtStatus.Text = point.TeacherService.Delete(tch.ID).Message;
                    UpdateControls();
                }
            }
            else
            {
                UpdateControls();
            }

        }
    }
}
