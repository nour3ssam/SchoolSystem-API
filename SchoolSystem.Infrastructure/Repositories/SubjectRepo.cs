using Microsoft.EntityFrameworkCore;
using SchoolSystem.Domain.Entities;
using SchoolSystem.Infrastructure.Data;
using SchoolSystem.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.Infrastructure.Repositories
{
    public class SubjectRepo : GenericRepo<Subject>, ISubjectRepo
    {
        private readonly DbSet<Subject> _subjects;
        public SubjectRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
            _subjects = dbContext.Set<Subject>();
        }


    }
}
