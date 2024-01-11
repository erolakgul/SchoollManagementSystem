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
    public partial class StudentForm : Form
    {
        Student st;
        Exam ex;
        ServicePoint point;
        ICollection<Question> qList;
        ICollection<Question> qList2;
        int sayac;

        public StudentForm()
        {
            InitializeComponent();
            point = new ServicePoint();
        }
        public StudentForm(Student log, Exam exam)
            : this()
        {
            st = log;
            ex = exam;

            qList = point.QuestionService.toListQues(ex.ID);
            qList2 = point.QuestionService.ToList();
            sayac = point.ExamService.TimeOfExam(ex.ID) + DateTime.Now.Minute;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            this.Text = ex.Name;
            bowWel.Text = st.ToString();

            // ---------------- //
            listQue.Items.Clear();

            foreach (Question item in qList2)
            {
                if (item.ExamID == ex.ID)
                {
                    listQue.Items.Add(item);
                }
            }
            lblTime.Text = Convert.ToString(point.ExamService.TimeOfExam(ex.ID));
            timer1.Start();
        }

        private void listQue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listQue.SelectedItems.Count > 0)
            {
                Question qu = listQue.SelectedItem as Question;
                txtQue.Text = qu.QuestionContent;
                label2.Text = qu.Option_1;
                label3.Text = qu.Option_2;
                label4.Text = qu.Option_3;
                label5.Text = qu.Option_4;
                //txtCorrectAns.Text = qu.CorrectAnswer.ToString();
            }
            lblSonuc.Text = "";
            
            //groupBox4.Controls.OfType<RadioButton>().ToList().ForEach(p => groupBox4.Controls.Remove(p)); // komple siler
            groupBox4.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
            foreach (RadioButton rad in groupBox4.Controls.OfType<RadioButton>().ToList())
            {
                if (rad.Checked == true) 
                {
                    rad.Checked = false;
                    break;
                }
            }
        }

        private void btnQuesSave_Click(object sender, EventArgs e)
        {
            byte answ;
            Question q = listQue.SelectedItem as Question;

            if (rb1.Checked == true)
            {
                answ = 1;
                foreach (Question item in qList)
                {
                    if (item.ID == q.ID)
                    {
                        Answer ans = new Answer()
                        {
                            QuestionID = item.ID,
                            StudentID = st.ID,
                            StudentAnswer = answ
                        };
                        lblSonuc.Text = point.AnswerService.Insert(ans).Message;
                    }
                }
            }
            else if (rb2.Checked == true)
            {
                answ = 2;
                foreach (Question item in qList)
                {
                    if (item.ID == q.ID)
                    {
                        Answer ans = new Answer()
                        {
                            QuestionID = item.ID,
                            StudentID = st.ID,
                            StudentAnswer = answ
                        };
                        lblSonuc.Text = point.AnswerService.Insert(ans).Message;
                    }
                }
            }
            else if (rb3.Checked == true)
            {
                answ = 3;
                foreach (Question item in qList)
                {
                    if (item.ID == q.ID)
                    {
                        Answer ans = new Answer()
                        {
                            QuestionID = item.ID,
                            StudentID = st.ID,
                            StudentAnswer = answ
                        };
                        lblSonuc.Text = point.AnswerService.Insert(ans).Message;
                    }
                }
            }
            else if (rb4.Checked == true)
            {
                answ = 4;
                foreach (Question item in qList)
                {
                    if (item.ID == q.ID)
                    {
                        Answer ans = new Answer()
                        {
                            QuestionID = item.ID,
                            StudentID = st.ID,
                            StudentAnswer = answ
                        };
                        lblSonuc.Text = point.AnswerService.Insert(ans).Message;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < sayac; i++)
            {
                if ((sayac - DateTime.Now.Minute) > 1)
                {
                    lblTime.Text = (sayac - DateTime.Now.Minute).ToString() + " dk";
                }
                else if ((sayac - DateTime.Now.Minute) == 1)
                {
                    lblTime.Text = (60 - (DateTime.Now.Second)).ToString() + " sn";
                }
                else if (lblTime.Text == "1 sn")
                {
                    timer1.Stop();
                    lblSonuc.Text = "Sınav süreniz sona ermiştir..";
                    listQue.Enabled = false;
                }
            }
        }

        private void btnSınavBitir_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Bitirmek istediğinize emin misiniz ?", "", MessageBoxButtons.YesNo);
            int puan = 0;

            if (onay == DialogResult.Yes)
            {
                label2.Text = ""; label3.Text = ""; label4.Text = ""; label5.Text = "";
                timer1.Stop();
                lblSonuc.Text = "Sınavı sonlandırdınız..";

                //ICollection<Answer> ans = point.AnswerService.ToList();

                //öğrencinin cevaplarını liste halinde aldık
                ICollection<Answer> ans2 = point.AnswerService.toListAnswer(st.ID);
                //  bu kısıma gelen öğrenci bilgisi st nin içinde
                //  bu kısıma gelen sınav bilgisi ex in içinde
                //  bu kısıma gelmeden önce soruların cevapları da ans nin içinde

                foreach (Question items in qList)
                {  // bu kısımda ise qlist bu girilen sınava ait soruların olduğu listeyi  içerir.
                    foreach (Answer item in ans2)
                    {    // bu kısımda da öğrencinin daha önceden verdiği cevaplar listelenir
                        if (items.ID == item.QuestionID) 
                        {
                            if (item.StudentAnswer == items.CorrectAnswer)
                            { // verilen cevap doğru ise,o soruya ait puanı eklet
                                puan += items.Points;
                            }   
                        }
                    }
                }
                ExamReport er = new ExamReport()
                {
                    ExamID = ex.ID,
                    StudentID = st.ID,
                    Result = puan
                };

                label3.Text = point.ExamReportService.Insert(er).Message;
                btnSınavBitir.Enabled = false;

                DialogResult onay2 = MessageBox.Show("Sayın " + st.FirstName + " sınav sonucunuz : " + puan, "", MessageBoxButtons.OK);
                //label2.Text = "Sayın " + st.FirstName + " sınav sonucunuz : " + puan;
                if (onay2==DialogResult.OK)
                {
                    if (System.Windows.Forms.Application.MessageLoop)
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                }
                //if ( point.ExamService.ExamPassive(ex.ID) > 0)
                //{
                //    label4.Text = "Sınav pasive çekilmiştir..";
                //}
                //else
                //{
                //    label4.Text = "Bir sorun oluştu..";
                //}
            }
        }
    }
}
