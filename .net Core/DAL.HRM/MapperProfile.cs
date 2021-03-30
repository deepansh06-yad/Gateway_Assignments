using AutoMapper;
using DAL.HRM.Database;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.HRM
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<Departments, DepartmentModel>();
            CreateMap<Employees, EmployeeModel>();
            CreateMap<Managers, ManagerModel>();
        }
    }
}
