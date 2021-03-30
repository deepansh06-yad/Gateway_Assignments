using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.HRM.Database
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Managers> Managers { get; set; }
    }
}
