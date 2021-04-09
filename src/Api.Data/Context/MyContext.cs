using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Api.Data.Context
{
    public class MyContext: DbContext  //Para poder u
    {
        public DbSet<UserEntity> Users { get; set; }
    }
}