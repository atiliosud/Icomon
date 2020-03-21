using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Icomon.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Icomon.Infra.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(b => b.Boss)
                .IsRequired();
        }

        public DbSet<User> Users { get; set; }
    }
}
