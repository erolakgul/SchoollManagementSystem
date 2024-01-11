using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OkulYönetimSistemi.BL.BaseServices;
using OkulYönetimSistemi.Entity.Entities;

namespace OkulYönetimSistemi.BL.DataServices
{
    public class AnswerService : ServiceBase<Answer>
    {
        //override insert dediğimizde servicebase den gönderdiğimiz answer sınıfının olduğu methodu çağıracaktır
        public override MessageService Insert(Answer dto)
        {
          //context servicebase den gelen nesne,Answer ise context in set edilmesi ile  dbset nesnesi üzerinden erişilir
            //formdan gönderilen veriler ile db deki veriler karşılaştırılır { context VS dto }
            if (context.Answer.Any(x=> x.QuestionID == dto.QuestionID && x.StudentID == dto.StudentID))
            {
                result.ResultID = 0;
                if (result.IsSuccess==false)
                {
                    result.Message = "Soru daha önce cevaplanmış...";
                    return result;
                }
            }
            
            bool isExist = (dto == null) ? false : true ;
            if (isExist)
            {
                result.ResultID = dto.ID;
                result.Message = "Cevabınız kaydedildi...";

                dto.IsActive = true;
                dbset.Add(dto);        // dto nesnesi dbset sınıfına basılır
                context.SaveChanges(); // db ye kaydedilir
            }
            return result;
        }

        public override MessageService Update(Answer dto)
        { 
            //context.Answer.Any yerine dbset ile de answer sınfımıza erişebiliriz
            // db deki id ile update işlemi ile gönderilen id karşılaştırılır eşitse ;
            if (dbset.Any(x => x.ID == dto.ID)) 
            {
                Answer ent = FindById(dto.ID);
                // ent nesnesi şuan güncellenen veriyi almış durumda
                ent.QuestionID = dto.QuestionID;
                ent.StudentID = dto.StudentID;
                ent.StudentAnswer = dto.StudentAnswer;

                result.ResultID = ent.ID;
                if (result.IsSuccess==true)
                {
                    result.Message = "Güncelleme işlemi başarılı..";
                    context.SaveChanges();
                    return result;
                }
            }
            result.Message = "Güncelleme başarısız..";
            return result;
        }
        public ICollection<Answer> toListAnswer(int _id)
        {
            var s = context.Answer.Where(x => x.StudentID == _id).ToList();
            return s;
        }
    }
}
