using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demos_EF_core.ModelsConfigration
{
    // fluent APIS inside another class
    // you must implement built-in interface IEntityTypeConfiguration<T>
    internal class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            // assign fluent APIS

            builder.HasKey(e => e.Id); // primary key
            builder.Property(e => e.Id)
                .UseIdentityColumn(1,1);

            // builder.Property(e => e.Name)
            builder.Property(e => e.Name)
                .HasColumnName("EmployeeName")
                .HasColumnType("varchar(50)")
                .HasMaxLength(40)
                .IsRequired(false);

            // one to one [total - total]
            builder.OwnsOne(e => e.empaddress , Address => Address.WithOwner();
        }
    }
}
