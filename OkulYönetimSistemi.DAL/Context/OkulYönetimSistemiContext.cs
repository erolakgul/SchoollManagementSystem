using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using OkulYönetimSistemi.Entity.Entities;

namespace OkulYönetimSistemi.DAL.Context
{
    public class OkulYönetimSistemiContext : DbContext
    {
        //yapıcı methodda connection açılır
        public OkulYönetimSistemiContext()
        {
            Database.Connection.ConnectionString = "Data Source=EROLAKGUL\\BESIKTAS;Initial Catalog=OkulYonetimSistemi; User=sa; Password=istanbul;";
        }

        public DbSet<Answer> Answer { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<ClassLecture> ClassLecture { get; set; }
        public DbSet<Exam> Exam { get; set; }
        public DbSet<ExamReport> ExamReport { get; set; }
        public DbSet<Lecture> Lecture { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}
