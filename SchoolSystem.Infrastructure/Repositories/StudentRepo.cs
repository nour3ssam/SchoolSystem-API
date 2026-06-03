using Microsoft.EntityFrameworkCore;
using SchoolSystem.Domain.Entities;
using SchoolSystem.Infrastructure.Data;
using SchoolSystem.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.Infrastructure.Repositories
{
    public class StudentRepo : GenericRepo<Student>, IStudentRepo
    {
        private readonly DbSet<Student> _students;
        public StudentRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
            _students = dbContext.Set<Student>();
        }

        public override async Task DeleteRangeAsync(ICollection<Student> entities)
        {
            foreach (var entity in entities)
            {
                _dbContext.Entry(entity).State = EntityState.Deleted;
            }
            await SaveChangesAsync();
        }


    }
}
