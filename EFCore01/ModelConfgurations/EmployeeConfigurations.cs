using EFCore01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace EFCore01.ModelConfgurations
{
    public class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(Id => Id.EmpId);
       
            builder.Property<string>("Name");//"Name" is not a prop in my class  will define "Name" as a shadow Prop [only in database]

            
            builder.Property(Name => Name.EmpName)
                .HasColumnName("EmploeeName").HasColumnType("varchar").HasMaxLength(50)
                .IsRequired(false); // .IsRequired(false) IsRequired() by default is true that will be can not be null

        }
    }
}
