using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Mapping
{
    public sealed class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            HasKey(x => x.Id);
            // Properties
            // Table & Columns Mappings
            ToTable("Employee", "dbo");
            // Relationships
        }
    }
}
