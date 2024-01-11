using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OkulYönetimSistemi.BL.BaseServices;
using OkulYönetimSistemi.Entity.Entities;

namespace OkulYönetimSistemi.BL.DataServices
{
    public class ClassService : ServiceBase<Class>
    {
        public override MessageService Insert(Class dto)
        {
            if (context.Class.Any(x => x.Name == dto.Name)) 
            {
                result.ResultID = 0;
                if (result.IsSuccess==false)
                {
                    result.Message = "Kayıt İşlemi Başarısız ..";
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
        public override MessageService Update(Class dto)
        {
            if (dbset.Any(x => x.ID == dto.ID)) 
            {
                Class ent = FindById(dto.ID);
                ent.Name = dto.Name;
                ent.Grade = dto.Grade;

                result.ResultID = ent.ID;
                if (result.IsSuccess==true)
                {
                    context.SaveChanges();
                    result.Message = "Güncelleme işlemi başarılı ..";
                    return result;
                }
            }
            result.Message = "Güncelleme başarısız..";
            return result;
        }

        //gönderilen sınıfın id si yakalanır
        public int GetID(Class dto)
        {
            return dbset.Where(x => x.Name == dto.Name && x.Grade == dto.Grade && x.IsActive).FirstOrDefault().ID;
        }

        public int Count()
        {
            return context.Class.Count();
        }
    }
}
