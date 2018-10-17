using System;
using Microsoft.EntityFrameworkCore;
using TodoData.ModelConfigurations;
using TodoData.Models;

namespace TodoData
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions options) 
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
        }

        public DbSet<User> User { get; set; } // get this to be plural but not when it reaches out to the db
    }
}