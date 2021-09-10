using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Livre>()
            //    .Property(b => b.Name).IsRequired();

            //modelBuilder.Entity<Livre>()
            //    .Property(b => b.Description).IsRequired();

            modelBuilder.Entity<Livre>().Property(p => p.DateDeCreation).HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
        public DbSet<Livre> books { get; set; }

    }
}
