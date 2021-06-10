using System;
using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Api.Data.Context
{
    public class MyContext: DbContext  //Comando para gerenciar tipos DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public MyContext(DbContextOptions<MyContext> options): base(options){}  //Config padrao

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<UserEntity> (new UserMap().Configure);
        }
    }
}