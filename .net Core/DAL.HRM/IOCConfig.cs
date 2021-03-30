using DAL.HRM.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.HRM
{
    public static class IOCConfig
    {
        public static void ConfigureServices(ref IServiceCollection services)
        {
            services.AddScoped<IDepartment, DepartmentRepo>();
            services.AddScoped<IEmployeeRepo, EmployeeRepo>();
            services.AddScoped<IManagerRepo, ManagerRepo>();
        }
    }
}
