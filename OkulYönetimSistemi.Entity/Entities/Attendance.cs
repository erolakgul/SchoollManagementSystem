using System;
using System.Collections.Generic;

namespace OkulYönetimSistemi.Entity.Entities
{
    public partial class Attendance : BaseClass
    {
        public Attendance()
        {
            this.Students = new List<Student>();
        }
        public int ClassLectureID { get; set; }
        public int TeacherID { get; set; }
        public int LectureHours { get; set; }
        public System.DateTime Date { get; set; }

        // ClassLecture ve öğretmen sınıflarının id lerini alır
        public virtual ClassLecture ClassLecture { get; set; }
        public virtual Teacher Teacher { get; set; }
        //öğrenci sınfına id sini gönderir
        public virtual ICollection<Student> Students { get; set; }
    }
}
