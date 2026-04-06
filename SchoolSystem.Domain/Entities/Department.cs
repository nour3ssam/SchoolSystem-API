using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolSystem.Domain.Entities
{
    public class Department
    {
        public Department()
        {
            Students = new HashSet<Student>();
        }
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        #region Relation With Student
        [InverseProperty(nameof(Student.Department))]
        public ICollection<Student> Students { get; set; }
        #endregion

    }
}
