using SchoolSystem.Domain.Entities;
using SchoolSystem.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.Infrastructure
{
    public static class DbSeeder
    {
        public static async Task SeedAsync(ApplicationDbContext context)
        {
            #region Department
            if (!context.Departments.Any())
            {
                var departments = new List<Department>
                {
                    new Department { Name = "Computer Science" },
                    new Department { Name = "Information Systems" },
                    new Department { Name = "Artificial Intelligence" }
                };
                await context.Departments.AddRangeAsync(departments);
                await context.SaveChangesAsync();

            }
            #endregion


            #region Student
            if (!context.Students.Any())
            {
                var departments = context.Departments.ToList();
                var students = new List<Student>() {
                   new Student {
                       Name = "Ali Ahmed",
                       Address = "Cairo",
                       Phone = "01011111111",
                       DepartmentId = departments.First(d => d.Name == "Computer Science").Id
                   },
                   new Student
                   {
                       Name = "Mohamed Samy",
                       Address = "Giza",
                       Phone = "01022222222",
                       DepartmentId =  departments.First(d => d.Name == "Information Systems").Id
                   },
                   new Student
                   {
                       Name = "Omar Hassan",
                       Address = "Alexandria",
                       Phone = "01033333333",
                       DepartmentId =departments.First(d => d.Name == "Artificial Intelligence").Id
                   }
                };
                await context.Students.AddRangeAsync(students);
                await context.SaveChangesAsync();

            }
            #endregion



            #region Subject
            if (!context.Subjects.Any())
            {
                var Subjects = new List<Subject>()
                {
                    new Subject
                    {
                        Name = "Database",
                        Period = 3
                    },
                    new Subject
                    {
                        Name = "Algorithms",
                        Period = 2
                    },
                    new Subject
                    {
                        Name = "Artificial Intelligence",
                        Period = 2
                    },
                    new Subject
                    {
                        Name = "Operating Systems",
                        Period = 3
                    }
                };
                await context.Subjects.AddRangeAsync(Subjects);
                await context.SaveChangesAsync();

            }
            #endregion

        }
    }
}
