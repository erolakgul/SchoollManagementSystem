using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OkulYönetimSistemi.Entity.Entities
{
    public partial class Student : BaseClass
    {
        public Student()
        {
            this.Answers = new List<Answer>();
            this.Attendances = new List<Attendance>();
            this.ExamReports = new List<ExamReport>();
        }
        
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(11, MinimumLength = 11)]
        public string IdentityNo { get; set; }
        [Required]
        public System.DateTime BirthDate { get; set; }
        [Required]
        [StringLength(50)]
        public string GuardianName { get; set; }
        [Required]
        [StringLength(50)]
        public string GuardianLastName { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string GuardianPhone { get; set; }

        [StringLength(50)]
        public string GuardianEmail { get; set; }
        [StringLength(10, MinimumLength = 10)]
        public string HomePhone { get; set; }

        [Required]
        public string Address { get; set; }
        [Required]
        [StringLength(3, MinimumLength = 3)]
        public string StudentNo { get; set; }
        [Required]
        public System.DateTime RegistrationDate { get; set; }
        [Required]
        [StringLength(50)]
        public string RegistrationTerm { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string UserName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string Password { get; set; }

        public Nullable<int> ClassID { get; set; }
        // sınıf sınıfının idsini alır
        public virtual Class Class { get; set; }

        //cevap ve devamsızlık sınıflarına id sini gönderir.
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<ExamReport> ExamReports { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + " ( " + StudentNo + " )";
        }
    }
}
