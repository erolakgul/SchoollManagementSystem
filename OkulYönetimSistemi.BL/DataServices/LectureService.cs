using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OkulYönetimSistemi.BL.BaseServices;
using OkulYönetimSistemi.Entity.Entities;

namespace OkulYönetimSistemi.BL.DataServices
{
    public class LectureService : ServiceBase<Lecture>
    {
        public override MessageService Insert(Lecture dto)
        {
            if (context.Lecture.Any(x => x.Name == dto.Name)) 
            {
                result.ResultID = 0;
                if (result.IsSuccess==false)
                {
                    result.Message = "Kayıt başarısız..";
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

        public override MessageService Update(Lecture dto)
        {
            if (dbset.Any(x => x.ID == dto.ID)) 
            {
                Lecture ent = FindById(dto.ID);
                ent.Name = dto.Name;
                ent.Description = dto.Description;

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

        public ICollection<Lecture> PanelLectureList(int _id)
        {
            // en son hangi değer dönerse onun servisine method
            var a = context.Student.Where(x => x.ID == _id).ToList();
            List<Lecture> lec = new List<Lecture>();

            if (a.Any(x => x.ID == _id))
            {
                foreach (Student item in a)
                {
                    var b = context.ClassLecture.Where(x => x.ClassID == item.ClassID).ToList();

                    foreach (ClassLecture items in b)
                    {
                        var c = context.Lecture.Where(x => x.ID == items.LectureID).ToList();

                        foreach (Lecture citem in c)
                        {
                            lec.Add(citem);
                        }
                    }
                }
                return lec;
            }
            return null;
        }
    }
}
