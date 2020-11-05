using System;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Value>()
                .HasData(
                    new Value{Id=1,Name="Value 101"},
                    new Value{Id=2,Name="Value 102"},
                    new Value{Id=3,Name="Value 103"},
                    new Value{Id=4,Name="Value 104"});
        }

        public DbSet<Value> Values { get; set; }
        public DbSet<Activity> Activities {get; set; }
    }
}
