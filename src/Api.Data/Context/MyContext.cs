using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Api.Data.Context
{
    public class MyContext: DbContext  //Para poder usar o EntityFrameworkCore
    {
        public DbSet<UserEntity> Users { get; set; }

        public MyContext(DbContextOptions<MyContext> options): base(options){}  //Config padrao
    }
}