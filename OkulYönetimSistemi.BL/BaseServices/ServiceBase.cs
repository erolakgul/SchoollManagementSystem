using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using OkulYönetimSistemi.DAL.Context;
using OkulYönetimSistemi.Entity.Entities;

namespace OkulYönetimSistemi.BL.BaseServices
{
    public abstract class ServiceBase<TEntity> where TEntity : BaseClass
    {
        protected OkulYönetimSistemiContext context;
        protected DbSet<TEntity> dbset;
        protected ServicePoint services;
        protected MessageService result;

        public ServiceBase()
        {
            context = new OkulYönetimSistemiContext();
            services = new ServicePoint();
            result = new MessageService();
            dbset = context.Set<TEntity>();
        }

        //false olanlar alınır  *********** lectureedit için eklendi,classlectureservice te kullanıldı
        public TEntity FindId(int id)
        {
            return dbset.Where(x => x.ID == id && x.IsActive == false).FirstOrDefault();
        }
        //aktifliği true olanlar alınır
        public TEntity FindById(int id)
        {
            return dbset.Where(x => x.ID == id && x.IsActive).FirstOrDefault();
        }
        public ICollection<TEntity> ToList()
        {
            return dbset.Where(x => x.IsActive).ToList();
        }

        public MessageService Delete(int id)
        {
            TEntity entity = FindById(id);

            if (entity == null)
            {
                result.ResultID = 0;
                if (result.IsSuccess==false)
                {
                    result.Message="Silme İşlemi Gerçekleştirilemedi..";
                    return result;
                }
            }
            // sildirmiyoruz hiçbir bilgiyi,aktif i ni false a çekiyoruz
            entity.IsActive = false;
            result.ResultID = entity.ID;
            result.Message = "Başarıyla Silindi..";
            context.SaveChanges();
            return result;
        }
        
        // abstract methodlar override edilcek daha sonra sınıfların servislerinde
        public abstract MessageService Insert(TEntity dto);

        public abstract MessageService Update(TEntity dto);

        public string InsertBase(TEntity dto)
        {
            string mes;

            dto.IsActive = true;
            dbset.Add(dto);
            context.SaveChanges();
            mes = "Kayıt başarılı";
            return mes;
        }

        public string UpdateBase(TEntity dto)
        {
            string mes;

            if (dto.ID > 0)
            {
                context.SaveChanges();
            }
            mes = "Güncellendi";
            return mes;
        }
    }
}
