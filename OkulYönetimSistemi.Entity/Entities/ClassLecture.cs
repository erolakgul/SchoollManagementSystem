using System;
using System.Collections.Generic;

namespace OkulYönetimSistemi.Entity.Entities
{
    public partial class ClassLecture : BaseClass
    {
        public ClassLecture()
        {
            this.Attendances = new List<Attendance>();
            this.Exams = new List<Exam>();
        }
        public int ClassID { get; set; }
        public int LectureID { get; set; }

        // sınıf ve lecture sınıfının id sini alır
        public virtual Class Class { get; set; }
        public virtual Lecture Lecture { get; set; }
        //devamsızlık ve sınavlar sınıfına id sini gönderir
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
    }
}
