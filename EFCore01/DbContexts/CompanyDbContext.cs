using EFCore01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore01.DbContexts
{
    internal class CompanyDbContext : DbContext
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
            //1.name of server  server =GEORGE-AMIN\\MS2025;
            //2.name of database   database=CompanyDb;
            //3. authentication method Trusted_Connection=True; 
            //4. server certificate TrustServerCertificate=True;
            //optionsBuilder.UseSqlServer("Data Source = GEORGE-AMIN\\MS2025; initial Catalog = CompanyDb; Integrated Security = true");
            optionsBuilder.UseSqlServer("server =GEORGE-AMIN\\MS2025; database=CompanyDb; Trusted_Connection=True; TrustServerCertificate=True;");


        }
        //  this is represent the class as a table in database 
        // by convention 
        public DbSet<Employee>? Employees { get; set; }
    }
}
