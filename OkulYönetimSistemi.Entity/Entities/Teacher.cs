using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OkulYönetimSistemi.Entity.Entities
{
    public partial class Teacher : BaseClass
    {
        public Teacher()
        {
            this.Attendances = new List<Attendance>();
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
        [StringLength(10, MinimumLength = 10)]
        public string Mobile { get; set; }
        [StringLength(10, MinimumLength = 10)]
        public string HomePhone { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string UserName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string Password { get; set; }

        // devamsızlığa idsini gönderir
        public virtual ICollection<Attendance> Attendances { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
