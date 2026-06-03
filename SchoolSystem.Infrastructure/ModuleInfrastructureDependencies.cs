using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SchoolSystem.Infrastructure.Data;
using SchoolSystem.Infrastructure.Interfaces;
using SchoolSystem.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services,
           IConfiguration configuration)
        {
            services.AddTransient<IStudentRepo, StudentRepo>();
            services.AddTransient<IDepartmentRepo, DepartmentRepo>();
            services.AddTransient(typeof(IGenericRepo<>), typeof(GenericRepo<>));


            //Connect To DB
            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


            return services;
        }
    }
}
