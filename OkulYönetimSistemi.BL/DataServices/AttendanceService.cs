using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OkulYönetimSistemi.BL.BaseServices;
using OkulYönetimSistemi.Entity.Entities;

namespace OkulYönetimSistemi.BL.DataServices
{
    public class AttendanceService : ServiceBase<Attendance>
    {
        public override MessageService Insert(Attendance dto)
        {
            if (context.Attendance.Any(x=> x.ClassLectureID==dto.ClassLectureID && x.TeacherID ==dto.TeacherID && x.Date==dto.Date))
            {
                result.ResultID = 0;
                if (result.IsSuccess==false)
                {
                    result.Message = "Kayıt başarısız ...";
                    return result;
                }
            }
            bool isExist = (dto == null) ? false : true;
            if (isExist)
            {
                result.ResultID = dto.ID;
                result.Message = "Kayıt işlemi başarı ile gerçekleştirildi..";
                
                dto.IsActive = true;
                dbset.Add(dto);
                context.SaveChanges();
            }
            return result;
        }
        public override MessageService Update(Attendance dto)
        {
            if (dbset.Any(x => x.ID == dto.ID)) 
            {
                Attendance ent = FindById(dto.ID);

                ent.ClassLectureID = dto.ClassLectureID;
                ent.TeacherID = dto.TeacherID;
                ent.Date = dto.Date;
                ent.LectureHours = dto.LectureHours;
                ent.Students = dto.Students;

                result.ResultID = dto.ID;
                if (result.IsSuccess==true)
                {
                    context.SaveChanges();
                    result.Message = "Güncelleme işlemi başarılı..";
                    return result;
                }
                result.Message = "Güncelleme işlemi başarısız ..";
            }
            return result;
        }

        //devamsızlıkları sıralıyoruz.
        public ICollection<Attendance> OrderBy()
        {
            // where ile tolist() kullanılır
            return dbset.Where(x => x.IsActive).OrderByDescending(x => x.Date).ToList();

            //alternatifi
            //return context.Attendance.Where(x => x.IsActive).OrderByDescending(x => x.Date).ToList();
        }
    }
}
