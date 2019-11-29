using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookItem> BookItems { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<ReservationBook> ReservationBooks { get; set; }
        public DbSet<StateType> StateTypes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).IsRequired();
                entity.HasMany(d => d.Tags);
                entity.HasOne(d => d.BookType);
                entity.HasOne(d => d.Language);
            });

            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasKey(e => e.ID);
            });
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.ID);
            });
            modelBuilder.Entity<ReservationBook>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.HasOne(e => e.User)
                .WithMany(g => g.ReservationBooks);
            });
        }

    }
   
}
