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
           var connectionString = "Server=localhost;Port=<your_port>;DataBase=<your_base>;Uid=root;Pwd=<your_password>";
           var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 11)));
           
           return new MyContext(optionsBuilder.Options);

        }
    }
}
