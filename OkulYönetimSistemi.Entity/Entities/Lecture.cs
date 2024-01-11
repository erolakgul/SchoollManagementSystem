using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OkulYönetimSistemi.Entity.Entities
{
    public partial class Lecture : BaseClass
    {
        public Lecture()
        {
            this.ClassLectures = new List<ClassLecture>();
        }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        // ClassLecture a id sini gönderir
        public virtual ICollection<ClassLecture> ClassLectures { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
