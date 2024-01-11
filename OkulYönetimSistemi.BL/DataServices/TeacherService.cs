using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OkulYönetimSistemi.BL.BaseServices;
using OkulYönetimSistemi.Entity.Entities;

namespace OkulYönetimSistemi.BL.DataServices
{
    public class TeacherService : ServiceBase<Teacher>
    {
        public override MessageService Insert(Teacher dto)
        {
            if (context.Teacher.Any(x => x.IdentityNo == dto.IdentityNo)) 
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
                result.Message = "Kayıt başarılı..";

                dto.IsActive = true;
                dbset.Add(dto);
                context.SaveChanges();
            }
            return result;
        }

        public override MessageService Update(Teacher dto)
        {
            if (dbset.Any(x=> x.ID==dto.ID))
            {
                Teacher ent = FindById(dto.ID);
                ent.FirstName = dto.FirstName;
                ent.LastName = dto.LastName;
                ent.UserName = dto.UserName;
                ent.Password = dto.Password;
                ent.IdentityNo = dto.IdentityNo;

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
        //public bool Login(string user, string pass)
        //{
        //    if (context.Teacher.Any(x=> x.UserName==user && x.Password==pass))
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        public Teacher Login(string user, string pass)
        {
            if (context.Teacher.Any(x => x.UserName == user && x.Password == pass))
            {
                return dbset.Where(x => x.UserName == user && x.Password == pass).FirstOrDefault();
            }
            return null;
        }
    }
}

//dbset.Where(x => x.UserName == user && x.Password == pass).FirstOrDefault();