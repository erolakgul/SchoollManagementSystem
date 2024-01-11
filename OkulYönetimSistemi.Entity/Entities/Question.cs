using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OkulYönetimSistemi.Entity.Entities
{
    public partial class Question : BaseClass
    {
        public Question()
        {
            this.Answers = new List<Answer>();
        }

        public int ExamID { get; set; }

        [Required]
        public string QuestionContent { get; set; }
        [Required]
        public string Option_1 { get; set; }
        [Required]
        public string Option_2 { get; set; }
        public string Option_3 { get; set; }
        public string Option_4 { get; set; }
        public int CorrectAnswer { get; set; }
        
        public Int16 Points { get; set; }

        //cevaplar sınıfına id sini gönderir
        public virtual ICollection<Answer> Answers { get; set; }
        // sınav sınıfının idsini alır
        public virtual Exam Exam { get; set; }

        public override string ToString()
        {
            return QuestionContent;
        }
    }
}
