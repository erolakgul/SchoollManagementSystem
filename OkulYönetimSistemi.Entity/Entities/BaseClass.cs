using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OkulYönetimSistemi.Entity.Entities
{
    public class BaseClass
    {
        [Key]
        public int ID { get; set; }
        public bool IsActive { get; set; }
    }
}
