using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OkulYönetimSistemi.BL.BaseServices;
using OkulYönetimSistemi.Entity.Entities;

namespace OkulYönetimSistemi.BL.DataServices
{
    public class ClassLectureService : ServiceBase<ClassLecture>
    {
        public override MessageService Insert(ClassLecture dto)
        {
            if (context.ClassLecture.Any(x => x.ClassID == dto.ClassID && x.LectureID == dto.LectureID && x.IsActive)) 
            {
                result.ResultID = 0;
                if (result.IsSuccess == false)
                {
                    result.Message = "Kayıt işlemi başarısız ..";
                    return result;
                }
            }
            bool isExist = (dto == null) ? false : true;
            if (isExist)
            {
                result.ResultID = dto.ID;
                result.Message = "Kayıt işlemi başarılı..";

                dto.IsActive = true;
                dbset.Add(dto);
                context.SaveChanges();
            }
            return result;
        }

        public override MessageService Update(ClassLecture dto)
        {
            //ilk önce dersleri 0 yapmıştık,şimdide seçilenleri 1 yapıcaz öncelikle

            //if (dbset.Any(x => x.ID == dto.ID)) // && x.IsActive == falses
            //{
            //    ClassLecture ent = FindById(dto.ID);

            //    ent.ClassID = dto.ClassID;
            //    ent.LectureID = dto.LectureID;
            //    //ent.IsActive = true;

            //    result.ResultID = ent.ID;
            //    if (result.IsSuccess == true) 
            //    {
            //        result.Message = "Güncelleme başarılı..";
            //        context.SaveChanges();
            //        return result;
            //    }
            //}

            //lecture edit sınıfından btnclassedit butonu ile sınıfa ait tüm derslerin aktifliği false olarak gönderilir
            if (dbset.Any(x => x.ClassID == dto.ClassID && x.LectureID == dto.LectureID && x.IsActive == false)) 
            {
                ClassLecture ent = FindId(dto.ID);
                //mesela 1.nolu id li satır geldi,o satırın güncellemesi yapılır gönderilir
                ent.ClassID = dto.ClassID;
                ent.LectureID = dto.LectureID;
                ent.IsActive = true;

                result.ResultID = ent.ID;
                if (result.IsSuccess == true)
                {
                    result.Message = "Güncelleme başarılı..";
                    context.SaveChanges();
                    return result;
                }
            }
            result.Message = "Güncelleme başarısız..";
            return result;
        }
        
        //lecture edit için eklendi,yine orada kullanıldı

        //lectureedit ten dönen değer ile bu sınıfın id si yakalanır
        public int GetID(ClassLecture dto)
        {
            if (dbset.Any(x => x.ClassID == dto.ClassID && x.LectureID == dto.LectureID)) 
            {
                return dbset.Where(x => x.ClassID == dto.ClassID && x.LectureID == dto.LectureID).FirstOrDefault().ID;    
            }
            return 0;
        }
        public ICollection<ClassLecture> toListClassLecture(int _id)
        {
            var s = context.ClassLecture.Where(x => x.ClassID == _id).ToList();
            return s;
        }
    }
}
