using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OkulYönetimSistemi.Entity.Entities
{
    public partial class Exam : BaseClass
    {
        public Exam()
        {
            this.Questions = new List<Question>();
            this.ExamReports = new List<ExamReport>();
        }
        public int ClassLectureID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public System.DateTime ExamDate { get; set; }
        public int Duration { get; set; }

        // ClassLecture sınıfından idsini alır
        public virtual ClassLecture ClassLecture { get; set; }
        //sorular sınıfına idsini gönderir.
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<ExamReport> ExamReports { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
