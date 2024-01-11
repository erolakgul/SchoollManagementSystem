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
    public partial class ExamEdit : Form
    {
        ServicePoint point;
        public ExamEdit()
        {
            InitializeComponent();
            point = new ServicePoint();
        }

        private void ExamEdit_Load(object sender, EventArgs e)
        {
            fillClass();
            for (int i = 1; i < 5; i++)
            {
                txtCorrectAns.Items.Add(i);
            }
            UpdateControls();
        }

        private void fillClass()
        {
            ICollection<Class> clsList = point.ClassService.ToList();
            foreach (Class item in clsList)
            {
                listClass.Items.Add(item);
            }
        }

        private void UpdateControls()
        {
            txtExamName.Clear();
            txtExamDur.Clear();
            txtExamDes.Clear();
            txtExamDate.Clear();

            listLec.ClearSelected();
            listClass.ClearSelected();

            ICollection<Exam> exList = point.ExamService.ToList();
            foreach (Exam item in exList)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = item.Name;
                listItem.SubItems.Add(item.ClassLecture.Class.Name);
                listItem.SubItems.Add(item.ClassLecture.Lecture.Name);
                listItem.SubItems.Add(item.ExamDate.ToString());
                listItem.SubItems.Add(item.Duration.ToString());
                listItem.Tag = item;

                listExam.Items.Add(listItem);
            }
        }

        private void UpdateQues()
        {
            listQue.Items.Clear();

            foreach (var item in tabPage2.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox tx = item as TextBox;
                    tx.Clear();
                }
            }
        }

        private void listClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            listLec.Items.Clear();
            if (listClass.SelectedItems.Count > 0)
            {
                ICollection<ClassLecture> lecList = point.ClassLectureService.ToList();
                Class cl = listClass.SelectedItem as Class;

                foreach (ClassLecture item in lecList)
                {
                    if (item.ClassID == cl.ID)
                    {
                        listLec.Items.Add(item.Lecture);
                    }
                }
            }
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            if (txtExamName.Text == "" || txtExamDes.Text == "" || txtExamDur.Text == "") 
            {
                MessageBox.Show("Önce sınıf,sonra ders seçtikten sonra verileri eksiksiz bir şekilde giriniz..");
            }
            else
            {
                listExam.Items.Clear();

                ICollection<ClassLecture> lecList = point.ClassLectureService.ToList();
                Class cl = listClass.SelectedItem as Class;
                Lecture lec = listLec.SelectedItem as Lecture;
                int id = 0;
                foreach (ClassLecture item in lecList)
                {
                    if (item.ClassID == cl.ID && item.LectureID == lec.ID)
                    {
                        id = item.ID;
                    }
                }
                Exam ex = new Exam()
                {
                    Name = txtExamName.Text,
                    Description = txtExamDes.Text,
                    Duration = Convert.ToInt32(txtExamDur.Text),
                    ExamDate = Convert.ToDateTime(txtExamDate.Text),
                    ClassLectureID = id

                };

                txtStatus.Text = point.ExamService.Insert(ex).Message;

                UpdateControls();
            }
        }

        private void btnUpdateExam_Click(object sender, EventArgs e)
        {
            if (listClass.SelectedItems.Count > 0 && listLec.SelectedItems.Count > 0)
            {
                ICollection<ClassLecture> lecList = point.ClassLectureService.ToList();
                Class cl = listClass.SelectedItem as Class;
                Lecture lec = listLec.SelectedItem as Lecture;
                int id = 0;
                foreach (ClassLecture item in lecList)
                {
                    if (item.ClassID == cl.ID && item.LectureID == lec.ID)
                    {
                        id = item.ID;
                    }
                }
                Exam ex = listExam.FocusedItem.Tag as Exam;

                ex.Name = txtExamName.Text;
                ex.Description = txtExamDes.Text;
                ex.Duration = Convert.ToInt32(txtExamDur.Text);
                ex.ExamDate = Convert.ToDateTime(txtExamDate.Text);
                ex.ClassLectureID = id;

                txtStatus.Text = point.ExamService.Update(ex).Message;
                listExam.Items.Clear();
                UpdateControls();
            }
            else MessageBox.Show("Sınıf ve ders seçmeniz gerekli");
        }

        private void listExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listExam.SelectedItems.Count > 0)
            {
                if (listExam.FocusedItem != null)
                {
                    Exam ex = listExam.FocusedItem.Tag as Exam;
                    txtExamName.Text = ex.Name;
                    txtExamDes.Text = ex.Description;
                    txtExamDur.Text = ex.Duration.ToString();

                    listQue.Items.Clear();
                    ICollection<Question> qList = point.QuestionService.ToList();
                    foreach (Question item in qList)
                    {
                        if (item.ExamID == ex.ID)
                        {
                            listQue.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void btnDeleteExam_Click(object sender, EventArgs e)
        {
            Exam ex = listExam.FocusedItem.Tag as Exam;
            txtStatus.Text = ex.Name + " sınavı : " + point.ExamService.Delete(ex.ID).Message;
            listExam.Items.Clear();
            UpdateControls();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = listExam;
            tabControl1.SelectedTab.Controls.Add(lv);
        }

        private void btnAddQue_Click(object sender, EventArgs e)
        {

            if (txtContent.Text == "" || txt1op.Text == "" || txt2op.Text == "" || txtCorrectAns.Text == "" || txtPuan.Text == "") 
            {
                MessageBox.Show("Doldurulmamış kısımlar mevcut..");
            }
            else
            {
                Exam ex = listExam.FocusedItem.Tag as Exam;

                Question que = new Question()
                {
                    ExamID = ex.ID,
                    QuestionContent = txtContent.Text,
                    Option_1 = txt1op.Text,
                    Option_2 = txt2op.Text,
                    Option_3 = txt3op.Text,
                    Option_4 = txt4op.Text,
                    CorrectAnswer = Convert.ToInt32(txtCorrectAns.Text),
                    Points = Convert.ToInt16(txtPuan.Text)
                };
                txtQueStatus.Text = point.QuestionService.Insert(que).Message;
                UpdateQues();
            }
        }

        private void listQue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listQue.SelectedItems.Count > 0)
            {
                Question qu = listQue.SelectedItem as Question;
                txtContent.Text = qu.QuestionContent;
                txt1op.Text = qu.Option_1;
                txt2op.Text = qu.Option_2;
                txt3op.Text = qu.Option_3;
                txt4op.Text = qu.Option_4;
                txtCorrectAns.Text = qu.CorrectAnswer.ToString();
            }
        }

        private void btnUpdateQue_Click(object sender, EventArgs e)
        {
            Exam ex = listExam.FocusedItem.Tag as Exam;

            Question que = listQue.SelectedItem as Question;
            que.ExamID = ex.ID;
            que.QuestionContent = txtContent.Text;
            que.Option_1 = txt1op.Text;
            que.Option_2 = txt2op.Text;
            que.Option_3 = txt3op.Text;
            que.Option_4 = txt4op.Text;
            que.CorrectAnswer = Convert.ToInt32(txtCorrectAns.Text);
            que.Points = Convert.ToInt16(txtPuan.Text);

            txtQueStatus.Text = point.QuestionService.Update(que).Message;
            UpdateQues();
        }

        private void btnDeleteQue_Click(object sender, EventArgs e)
        {
            Question que = listQue.SelectedItem as Question;
            txtQueStatus.Text = point.QuestionService.Delete(que.ID).Message;
            UpdateQues();
        }
    }
}
