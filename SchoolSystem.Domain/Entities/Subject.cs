using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolSystem.Domain.Entities
{
    public class Subject
    {
 
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
        public int Period { get; set; }

       

    }
}
