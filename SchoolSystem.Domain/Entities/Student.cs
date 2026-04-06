using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolSystem.Domain.Entities
{
    public class Student
    {

        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        public string Phone { get; set; }


        #region Relation With Department
        public int? DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        [InverseProperty(nameof(Entities.Department.Students))]
        public Department Department { get; set; }
        #endregion

    }
}
