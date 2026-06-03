using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.Infrastructure.Configurations
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            // builder.HasData(
            //    new Student
            //    {
            //        Id = 1,
            //        Name = "Ali Ahmed",
            //        Address = "Cairo",
            //        Phone = "01011111111",
            //        DepartmentId = 1
            //    },
            //    new Student
            //    {
            //        Id = 2,
            //        Name = "Mohamed Samy",
            //        Address = "Giza",
            //        Phone = "01022222222",
            //        DepartmentId = 2
            //    },
            //    new Student
            //    {
            //        Id = 3,
            //        Name = "Omar Hassan",
            //        Address = "Alexandria",
            //        Phone = "01033333333",
            //        DepartmentId = 3
            //    }
            //);

        }
    }
}
