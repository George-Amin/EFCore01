using Commen;
using EFCore01.ModelConfgurations;
using EFCore01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
namespace EFCore01.DbContexts
{
    public class CompanyDbContext : DbContext
    {
        /*
         Add-Migration -Name "CreateEmployeeTable" -Context "CompanyDbContext" -OutputDir "DbContexts/Migrations"
         */
        public CompanyDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //..DbContextOptionsBuilder has function that can take ConnectionString that can open session with database
            //1 .name of server => server =GEORGE-AMIN\\MS2025;
            //2 .name of database => database=CompanyDb;
            //3 .authentication method => Trusted_Connection=True; 
            //4 .server certificate => TrustServerCertificate=True;
            //optionsBuilder.UseSqlServer("Data Source = GEORGE-AMIN\\MS2025; initial Catalog = CompanyDb; Integrated Security = true");
            optionsBuilder.UseSqlServer("server =GEORGE-AMIN\\MS2025; database=CompanyDb; Trusted_Connection=True; TrustServerCertificate=True;");


        }

        // use fluent api to OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region old way to build model with fluent api 
            /*
                modelBuilder.Entity<Employee>().HasKey(Id => Id.EmpId);
                // if the name of porp is wrong will throw Exception (UNsave)
                //modelBuilder.Entity<Employee>().Property("EmpName");
                // use generic version  
                modelBuilder.Entity<Employee>().Property<string>("Name");//"Name" is not a prop in my class  will define "Name" as a shadow Prop [only in database]

                //modelBuilder.Entity<Employee>().Property(nameof(Employee.EmpName));

                // most common use => lambda expression x=>x.name
                modelBuilder.Entity<Employee>().Property(Name => Name.EmpName)
                    .HasColumnName("EmploeeName").HasColumnType("varchar").HasMaxLength(50)
                    .IsRequired(false); // .IsRequired(false) IsRequired() by default is true that will be can not be null

                */
            #endregion

            #region Calling the configuration manually (old way)

            // after make the configuration in class just apply this configuration in OnModelCreating()

            // calling the Employee configuration  as a new object()
            //modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfigurations());


            // calling the Department configuration  as a new object() 
            //modelBuilder.ApplyConfiguration(new DepartmentConfigurations());


            #endregion
            #region Calling the configuration Automatically (new way) 
            /*..  Will apply all class [fluent APIs Configurations] that implement IEntityTypeConfiguration<> Automatically ..*/
            // .GetExecutingAssembly() right class in the same time
            // in run time will search in all class that implement the IEntityTypeConfiguration<> interface
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            #endregion

        }
        //  this is represent the class as a table in database 
        // by convention 
        public DbSet<Employee>? Employees { get; set; }


        /*
                public DbSet<Department>? Department { get; set; }
                //delete project table 
                // to drop the table from database delete the DbSet property and add a new migration and update database =>
                // An operation was scaffolded that may result in the loss of data. Please review the migration for accuracy.
                //public DbSet<Project> Projects { get; set; }
                public DbSet<Product> Products { get; set; }
        */


        //public DbSet<Department> Departments { get; set; }
    }
}
