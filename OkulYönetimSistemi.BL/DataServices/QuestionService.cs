using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OkulYönetimSistemi.BL.BaseServices;
using OkulYönetimSistemi.Entity.Entities;

namespace OkulYönetimSistemi.BL.DataServices
{
    public class QuestionService : ServiceBase<Question>
    {
        public override MessageService Insert(Question dto)
        {
            bool isExist = (dto == null) ? false : true;
            if (isExist)
            {
                result.ResultID = dto.ID;
                result.Message = "Kayıt başarılı..";

                dto.IsActive = true;
                dbset.Add(dto);
                context.SaveChanges();
            }
            return result;
        }
        public override MessageService Update(Question dto)
        {
            if (dbset.Any(x => x.ID == dto.ID)) 
            {
                Question ent = FindById(dto.ID);
                ent.ExamID = dto.ExamID;
                ent.Option_1 = dto.Option_1;
                ent.Option_2 = dto.Option_2;
                ent.Option_3 = dto.Option_3;
                ent.Option_4 = dto.Option_4;
                ent.QuestionContent = dto.QuestionContent;
                ent.CorrectAnswer = dto.CorrectAnswer;
                ent.Points = dto.Points;

                result.ResultID = ent.ID;
                if (result.IsSuccess==true)
                {
                    result.Message = "Güncelleme başarılı..";
                    context.SaveChanges();
                    return result;
                }
            }
            result.Message = "Güncelleme başarısız ..";
            return result;
        }
        public ICollection<Question> toListQues(int _id)
        {
            //exam id buraya studentform dan gönderilir o sınava ait sorular da geri gönderilir
            return context.Question.Where(x => x.ExamID == _id).OrderBy(x => x.ID).ToList();
        }
    }
}
