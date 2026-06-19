using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.Infrastructure.Configurations
{
    internal class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {

        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            //builder.HasData(
            //    new Subject
            //    {
            //        Id = 1,
            //        Name = "Database",
            //        Period = new DateTime(2027, 1, 1)
            //    },
            //    new Subject
            //    {
            //        Id = 2,
            //        Name = "Algorithms",
            //        Period = new DateTime(2027, 1, 1)
            //    },
            //    new Subject
            //    {
            //        Id = 3,
            //        Name = "Artificial Intelligence",
            //        Period = new DateTime(2027, 1, 1)
            //    },
            //    new Subject
            //    {
            //        Id = 4,
            //        Name = "Operating Systems",
            //        Period = new DateTime(2027, 1, 1)
            //    }
            //);
        }
    }
}
