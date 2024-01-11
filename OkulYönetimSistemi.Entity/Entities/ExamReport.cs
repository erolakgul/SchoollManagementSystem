using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimSistemi.Entity.Entities
{
    public class ExamReport : BaseClass
    {
        public int ExamID { get; set; }
        public int StudentID { get; set; }
        public double Result { get; set; }
        //öğrenci ve soru sınıflarının id lerini alır
        public virtual Exam Exam { get; set; }
        public virtual Student Student { get; set; }
    }
}
