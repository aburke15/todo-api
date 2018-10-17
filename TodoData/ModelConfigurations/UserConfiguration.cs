using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoData.Models;

namespace TodoData.ModelConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CreatedOn)
                .IsRequired()
                .HasColumnType("datetime2(7)");

            builder.Property(x => x.LastUpdatedOn)
                .HasColumnType("datetime2(7)");

            builder.Property(x => x.DeprecatedOn)
                .HasColumnType("datetime2(7)");

            builder.Property(x => x.Firstname)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(x => x.Lastname)
                .HasMaxLength(25)
                .IsRequired();
            
            builder.Property(x => x.Username)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Email)
                .HasMaxLength(50)
                .IsRequired();
            
            builder.Property(x => x.Phone)
                .HasMaxLength(10);
        }
    }
}