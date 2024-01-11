using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OkulYönetimSistemi.Entity.Entities
{
    public partial class Class : BaseClass
    {
        public Class()
        {
            this.Students = new List<Student>();
            this.ClassLectures = new List<ClassLecture>();
        }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Grade { get; set; }

        // ClassLecture ve öğrenci sınıflarna id sini gönderir
        public virtual ICollection<ClassLecture> ClassLectures { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
