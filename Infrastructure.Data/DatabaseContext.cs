using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Data.Mapping;

namespace Infrastructure.Data
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DatabaseContext() : base("name=DatabaseContext")
        {
            Database.SetInitializer<DatabaseContext>(null);
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeMap());
        }
    }
}
