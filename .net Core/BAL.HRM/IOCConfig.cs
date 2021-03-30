using AutoMapper;
using BAL.HRM.Managers;
using DAL.HRM;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.HRM
{
    public static class IOCConfig
    {
        public static void ConfigureServices(ref IServiceCollection services)
        {
            DAL.HRM.IOCConfig.ConfigureServices(ref services);
            services.AddAutoMapper(typeof(MapperProfile));
            services.AddScoped<IDepartmentManager, DepartmentManager>();
            services.AddTransient(typeof(IDepartmentManager), typeof(DepartmentManager));
            services.AddScoped<IManger, Manager>();
            services.AddScoped<IEmployeeManager, EmployeeManager>();
        }
    }
}
