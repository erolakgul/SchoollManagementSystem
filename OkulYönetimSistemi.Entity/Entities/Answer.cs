using System;
using System.Collections.Generic;

namespace OkulYönetimSistemi.Entity.Entities
{
    public partial class Answer : BaseClass
    {
        public int QuestionID { get; set; }
        public int StudentID { get; set; }
        public byte StudentAnswer { get; set; }

        //öğrenci ve soru sınıflarının id lerini alır
        public virtual Question Question { get; set; }
        public virtual Student Student { get; set; }
    }
}
