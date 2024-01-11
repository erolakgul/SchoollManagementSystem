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
    public partial class LectureEdit : Form
    {
        ServicePoint point;
        public LectureEdit()
        {
            InitializeComponent();
            point = new ServicePoint();
        }

        private void LectureEdit_Load(object sender, EventArgs e)
        {
            UpdateControls();
            int c = point.ClassService.Count();

            for (int i = 1; i < c + 2; i++)
            {
                cmbGrade.Items.Add(i);
            }
        }

        private void UpdateControls()
        {
            chkClassLec.Items.Clear();
            listClass.Items.Clear();
            listLec.Items.Clear();

            ICollection<Lecture> lecList = point.LectureService.ToList();

            foreach (Lecture item in lecList)
            {
              chkClassLec.Items.Add(item);
              listLec.Items.Add(item);   
            }

            ICollection<Class> clList = point.ClassService.ToList();
            foreach (Class item in clList)
            {
                listClass.Items.Add(item);
            }
        }

        private void ResetLec()
        {
            UpdateControls();
            txtLecDes.Clear();
            txtLecName.Clear();
        }

        private void btnAddLec_Click(object sender, EventArgs e)
        {
            if (txtLecName.Text == "" || txtLecDes.Text == "") 
            {
                MessageBox.Show("Boş veri göndermeyiniz..");
            }
            else
            {
                Lecture lec = new Lecture()
                {
                    Name = txtLecName.Text,
                    Description = txtLecDes.Text
                };
                txtLecStatus.Text = point.LectureService.Insert(lec).Message;
                //txtLecStatus.Text = point.LectureService.InsertBase(lec);
                ResetLec();
            }
        }

        private void btnUpdateLec_Click(object sender, EventArgs e)
        {
            Lecture lec = listLec.SelectedItem as Lecture;
            lec.Name = txtLecName.Text;
            lec.Description = txtLecDes.Text;

            txtLecStatus.Text = point.LectureService.Update(lec).Message;
            //txtLecStatus.Text = point.LectureService.UpdateBase(lec);
            ResetLec();
        }

        private void btnDeleteLec_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz ?", "", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                Lecture lec = listLec.SelectedItem as Lecture;
                txtLecStatus.Text = lec.Name + "-" + point.LectureService.Delete(lec.ID).Message;
                ResetLec();

                //foreign key olarak classlecture da olan silinmiş dersinde aktifliğini 0 yapıyoruz
                ICollection<ClassLecture> clist = point.ClassLectureService.ToList();
                foreach (ClassLecture item in clist)
                {
                    if (item.LectureID == lec.ID)
                    {
                        point.ClassLectureService.Delete(item.ID);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi..");
            }
        }

        private void listLec_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lecture lec = listLec.SelectedItem as Lecture;
            txtLecName.Text = lec.Name;
            txtLecDes.Text = lec.Description;
        }

        private void listClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            Class cl = listClass.SelectedItem as Class;
            txtClassName.Text = cl.Name;
            cmbGrade.Text = cl.Grade;

            ICollection<ClassLecture> clist = point.ClassLectureService.ToList();
            //her tık sonrası listbox ı boşalt
            listClassLectures.Items.Clear();

            //ve sonra doldur
            foreach (ClassLecture item in clist)
            {
                //tüm dersler çekilir,seçili olanların id leri ile karşılaştırılıp listbox doldurulur
                if (item.ClassID == cl.ID)
                {
                    listClassLectures.Items.Add(item.Lecture);
                }
            }
            txtClassStatus.Text = "";
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {

            if (txtClassName.Text=="" || cmbGrade.SelectedItem==null || chkClassLec.CheckedItems.Count == 0)
            {
                MessageBox.Show("Sınıf adı ve derecesini belirledikten sonra ders seçimi yapınız..");
            }
            else
            {
                Class cls = new Class()
                {
                    Name = txtClassName.Text,
                    Grade = cmbGrade.SelectedItem.ToString()
                };
                txtClassStatus.Text = point.ClassService.Insert(cls).Message;

                ClassLecture cLec = new ClassLecture()
                {
                    ClassID = point.ClassService.GetID(cls)
                };

                foreach (Lecture item in chkClassLec.CheckedItems)
                {
                    cLec.LectureID = item.ID;
                    point.ClassLectureService.Insert(cLec);
                }
                txtClassName.Clear();
                UpdateControls();
            }
        }

        private void btnClassEdit_Click(object sender, EventArgs e)
        {
            Class cls = listClass.SelectedItem as Class;
            cls.Name = txtClassName.Text;
            cls.Grade = cmbGrade.SelectedItem.ToString();
            txtClassStatus.Text = cls.Name + " için " + point.ClassService.Update(cls).Message;
            //buraya kadar class sınıfını güncelledik

            // ****** bu kısımda da seçilen dersleri o sınıfa ekliyoruz ****** //

            //seçilen sınıfa ait tüm derslerin aktifliği false yapılır
            ICollection<ClassLecture> clist = point.ClassLectureService.ToList();
            
            foreach (ClassLecture item in clist)
            {
                if (item.ClassID == cls.ID)
                {
                    point.ClassLectureService.Delete(item.ID);
                }
            }

            //güncelleme yapılan sınıfın id nin verileri classlecture a id üzerinden gönderilir 
            ClassLecture cLec = new ClassLecture()
            {
                ClassID = point.ClassService.GetID(cls)
            };
            //check edilen dersler yeniden classlecture tablosuna doldurulur tekrar
            foreach (Lecture item in chkClassLec.CheckedItems)
            {
                cLec.LectureID = item.ID;
                //sınıf id sini ve lectureid yi gönderiyip bize classlectureid olarak dönecek bir method yazdık ClassLectureService'e
                cLec.ID = point.ClassLectureService.GetID(cLec);

                //seçilen ders o sınıfın içinde yoksa insert e varsa update e gönderilir
                if (cLec.ID == 0) 
                {
                    txtClassStatus.Text += "\n" + "Sınıf Dersleri İçin : " + point.ClassLectureService.Insert(cLec).Message;
                }
                else
                {
                    txtClassStatus.Text += "\n" + "Sınıf Dersleri İçin : " + point.ClassLectureService.Update(cLec).Message;
                }
            }
            listClassLectures.Items.Clear();
            txtClassName.Clear();
            UpdateControls();
        }

        private void btnClassDelete_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz ?", "", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes) 
            {
                // Sınıfın aktifliği 0 yapılır
                Class cls = listClass.SelectedItem as Class;
                txtClassStatus.Text = cls.Name + "-" + point.ClassService.Delete(cls.ID).Message;

                //Sınıfa ait derslerin görünümü 0 yapılır 
                //**** İsteğe bağlı,eğer bu kısım çalıştırılmazsa bile sınıf aktif olmadığı için görünmez

                //ICollection<ClassLecture> clist = point.ClassLectureService.ToList();

                //foreach (ClassLecture item in clist)
                //{
                //    if (item.ClassID == cls.ID)
                //    {
                //        point.ClassLectureService.Delete(item.ID);
                //    }
                //}   
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi..");
            }
            listClassLectures.Items.Clear();
            UpdateControls();
        }


    }
}
