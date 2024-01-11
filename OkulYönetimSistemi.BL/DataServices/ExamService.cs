using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OkulYönetimSistemi.BL.BaseServices;
using OkulYönetimSistemi.Entity.Entities;

namespace OkulYönetimSistemi.BL.DataServices
{
    public class ExamService : ServiceBase<Exam>
    {
        public override MessageService Insert(Exam dto)
        {
            if (context.Exam.Any(x => x.ClassLectureID == dto.ClassLectureID))
            {
                result.ResultID = 0;
                if (result.IsSuccess == false)
                {
                    result.Message = "Kayıt işlemi başarısız..";
                    return result;
                }
            }
            bool isExist = (dto == null) ? false : true;
            if (isExist)
            {
                result.ResultID = dto.ID;
                result.Message = "Kayıt gerçekleştirildi..";

                dto.IsActive = true;
                dbset.Add(dto);
                context.SaveChanges();
            }
            return result;
        }

        public override MessageService Update(Exam dto)
        {
            if (dbset.Any(x => x.ID == dto.ID))
            {
                Exam ent = FindById(dto.ID);
                ent.Name = dto.Name;
                ent.Description = dto.Description;
                ent.Duration = dto.Duration;
                ent.ExamDate = dto.ExamDate;
                ent.ClassLectureID = dto.ClassLectureID;

                result.ResultID = ent.ID;
                if (result.IsSuccess == true)
                {
                    result.Message = "Güncelleme başarılı..";
                    context.SaveChanges();
                    return result;
                }
            }
            result.Message = "Güncelleme başarısız ...";
            return result;
        }
        public int TimeOfExam(int _id)
        {
            var time = context.Exam.Where(x => x.ID == _id);
            return time.Single(x => x.IsActive).Duration;
        }
        public int ExamPassive(int _id)
        {
            Exam ent = FindById(_id);
            ent.IsActive = false;
            context.SaveChanges();

            return ent.ID;
        }
    }
}
