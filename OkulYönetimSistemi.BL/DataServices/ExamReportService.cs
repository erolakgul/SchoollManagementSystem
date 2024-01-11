using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OkulYönetimSistemi.BL.BaseServices;
using OkulYönetimSistemi.Entity.Entities;

namespace OkulYönetimSistemi.BL.DataServices
{
    public class ExamReportService : ServiceBase<ExamReport>
    {
        public override MessageService Insert(ExamReport dto)
        {
            if (context.ExamReport.Any(x => x.ID == dto.ID))
            {
                result.ResultID = 0;
                if (result.IsSuccess == false)
                {
                    result.Message = "Daha önce kaydedilmiş veri..";
                    return result;
                }
            }
            bool isExist = (dto == null) ? false : true;
            if (isExist)
            {
                result.ResultID = dto.ID;
                result.Message = "Sınav sonucunuz kaydedildi..";

                dto.IsActive = true;
                dbset.Add(dto);        // dto nesnesi dbset sınıfına basılır
                context.SaveChanges(); // db ye kaydedilir
            }
            return result;
        }
        public override MessageService Update(ExamReport dto)
        {
            throw new NotImplementedException();
        }
        public ICollection<ExamReport> toListExamReportStud(int _id)
        {
            var s = context.ExamReport.Where(x => x.StudentID == _id).ToList();
            return s;
        }
    }
}
