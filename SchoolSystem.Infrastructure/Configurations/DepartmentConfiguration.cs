using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.Infrastructure.Configurations
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            //builder.HasData(
            //       new Department
            //       {
            //           Id = 1,
            //           Name = "Computer Science"         
            //       },
            //       new Department
            //       {
            //           Id = 2,
            //           Name = "Information Systems"      
            //       },
            //       new Department
            //       {
            //           Id = 3,
            //           Name = "Artificial Intelligence" 
            //       }
            //);

        }
    }
}
