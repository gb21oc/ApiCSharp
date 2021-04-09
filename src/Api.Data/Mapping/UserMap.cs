using System;
using Microsoft.EntityFrameworkCore;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("User");
            builder.HasKey(b => b.Id);
            builder.HasIndex(b => b.Email).IsUnique();
            builder.Property(b => b.Name).IsRequired().HasMaxLength(60);
            builder.Property(b => b.Email).HasMaxLength(100);

        }
    }
}