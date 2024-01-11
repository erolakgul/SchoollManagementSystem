using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OkulYönetimSistemi.BL.BaseServices;
using OkulYönetimSistemi.Entity.Entities;

namespace OkulYönetimSistemi.BL.DataServices
{
    public class StudentService : ServiceBase<Student>
    {
        public override MessageService Insert(Student dto)
        {
            if (context.Student.Any(x=> x.IdentityNo==dto.IdentityNo))
            {
                result.ResultID = 0;
                if (result.IsSuccess==false)
                {
                    result.Message = "Kayıt başarısız ..";
                    return result;
                }
            }
            bool isExist = (dto == null) ? false : true;
            if (isExist)
            {
                dto.IsActive = true;
                dbset.Add(dto);
                context.SaveChanges();

                result.ResultID = dto.ID;
                result.Message = "Kayıt başarılı..";
            }
            return result;
        }
        public override MessageService Update(Student dto)
        {
            if (dbset.Any(x => x.ID == dto.ID)) 
            {
                Student ent = FindById(dto.ID);
                ent.FirstName = dto.FirstName;
                ent.LastName = dto.LastName;
                ent.UserName = dto.UserName;
                ent.Password = dto.Password;
                ent.ClassID = dto.ClassID;

                foreach (Attendance item in dto.Attendances)
                {
                    Attendance at = context.Attendance.Where(x => x.ID == item.ID).FirstOrDefault();
                    ent.Attendances.Add(at);
                }

                result.ResultID = ent.ID;
                if (result.IsSuccess==true)
                {
                    result.Message = "Güncelleme başarılı..";
                    context.SaveChanges();
                    return result;
                }
            }
            result.Message = "Güncelleme başarısız..";
            return result;
        }
        public MessageService DeleteAtt(Student dto,int attID)
        {
            if (dbset.Any(x=> x.ID==dto.ID))
            {
                Student ent = FindById(dto.ID);
                Attendance at = context.Attendance.Where(x => x.ID == attID).FirstOrDefault();
                ent.Attendances.Remove(at);

                result.ResultID = ent.ID;
                if (result.IsSuccess==true)
                {
                    result.Message = "Silme işlemi başarılı..";
                    context.SaveChanges();
                    return result;
                }
            }
            result.Message = "Silme işlemi başarısız ..";
            return result;
        }

        public ICollection<Exam> ExamStu(Student dto)
        {
            if (context.Student.Any(x => x.ID == dto.ID)) 
            {
                Student ent = FindById(dto.ID);
                List<Exam> listExam = new List<Exam>();

                foreach (ClassLecture item in dto.Class.ClassLectures)
                {
                    foreach (Exam ex in item.Exams)
                    {
                        if (ex.ExamDate > DateTime.Now)
                        {
                            listExam.Add(ex);
                        }
                    }
                }
                return listExam;
            }
            return null;
        }

        public Student Login(string user, string pass)
        {
            if (context.Student.Any(x=> x.UserName==user && x.Password==pass))
            {
                return dbset.Where(x => x.UserName == user && x.Password == pass).FirstOrDefault();
            }
            return null;
        }


        public ICollection<Student> ReportExamListStu(int _id)
        {
            // derse göre sonuçlanmış sınavların öğrenci listelerini getirmek için yazıldı //

            var a = context.ClassLecture.Where(x => x.LectureID == _id).ToList();
            //sınav tarihi geçmiş derslerin sınavları listelenir
            var exam = context.Exam.Where(x => x.ExamDate < DateTime.Now).ToList();

            List<Student> listStu = new List<Student>();

            if (a.Any(x => x.LectureID == _id)) 
            {
                foreach (ClassLecture item in a)
                {
                    foreach (Exam xitem in exam)
                    {
                        //classlectureid lerin eşit oldukları yrlerde ;
                        if (xitem.ClassLectureID == item.ID) 
                        {
                            // sınav id leri eşit olup (exam ve examreport un)
                            var exaReport = context.ExamReport.Where(x => x.ExamID == xitem.ID).ToList();
                            // liste olarak boş dönmeyen sonuçlar içerisnden
                            if (exaReport.Count == 0) 
                            {
                                return null;
                            }
                            else
                            {

                                if (item.Exams.Count != 0)
                                {
                                    // öğrenci leri çekip generik list içerisnde toplayıp
                                    var b = context.Student.Where(x => x.ClassID == item.ClassID).ToList();

                                    foreach (Student items in b)
                                    {
                                        listStu.Add(items);
                                    }
                                }
                            }
                        }
                    }
                }
                //reportedit sınfına geri gönderiyoruz
                return listStu;
            }
            return null;
        }
    }
}
