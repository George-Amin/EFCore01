using Commen;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace EFCore01.ModelConfgurations
{
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
      
                builder.ToTable("Departments", "Sales");
                builder.HasKey(D => D.DeptId);
                builder.Property(D => D.DeptId).UseIdentityColumn(10, 10);

                //builder.Property(D => builder.DeptId).HasDefaultValueSql("NewGuid()");

                builder.Property(D => D.DeptName)
                            .HasColumnName("DepartmenName")
                            .HasColumnType("varchar").HasMaxLength(20).IsRequired(false)
                            .HasDefaultValue("HR");


                builder.Property(D => D.DataOfCreation)
                            .HasAnnotation("DataType", "Date")
                            .HasDefaultValueSql("GetDate()")/*.IsRequired(false)*/;

                builder.Ignore(D => D.Serial);
        
        }
    }
    }
}
