using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>  //Serving to create tables and databases
    {
        public MyContext CreateDbContext(string[] args)
        {
           //Used to create migrations
           var connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CSharpApi;Data Source=LAPTOP-BQIMSF2O\\SQLEXPRESS";
           var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer(connectionString); //, new MySqlServerVersion(new Version(8, 0, 11))
           
           return new MyContext(optionsBuilder.Options);

        }
    }
}
