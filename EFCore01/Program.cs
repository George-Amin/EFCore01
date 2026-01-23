using EFCore01.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace EFCore01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *EFcore is (ORM) object relational mapper  
             *support with any databases engin
             */
            // open a connection to database
            // CompanyDbContext dbContext = new CompanyDbContext();
            // database connection is opened but EF Core Can not close it [ UNmanage Resource ]
            #region close the connection 
            #region try{}finally{}

            //try
            //{
            //    // some code
            //}
            //finally
            //{
            //    // close the database connection
            //    // from CompanyDbContext : DbContext Dispose is Method on it 
            //    // Releases the allocated resources for this context.
            //    dbContext.Dispose();
            //}


            #endregion
             
            #region Using()
            //using (CompanyDbContext dbContext = new CompanyDbContext())
            //{
            //    // some code
            //}

            // syntax sugar for the above code
            // can manage resource and close the database connection
            using CompanyDbContext dbContext = new CompanyDbContext();


            // automatically update database schema
            // apply any pending migration for the database
            // or use Update-Database in Package Manager Console
            //dbContext.Database.Migrate();
            // some code 
            #endregion

            #endregion
        }
    }
}
