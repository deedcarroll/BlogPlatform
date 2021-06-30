using BlogPlatform.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform
{
    public class BlogContext : DbContext
    {

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb; Database=BlogPlatformDB_072021; Trusted_Connection=True";
            
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post(1,"The Vibe On Air Ep 1", "https://youtube.com/embed/VkdND06ZY4k", "body1", "Pearl De'Chef", new DateTime(2021,04,29)),
                new Post(2,"The Vibe On Air Ep 2", "https://youtube.com/embed/zTF7LcpWhkI", "body2", "Ritchie Carlyle", new DateTime(2021,04,22)),
                new Post(3,"The Vibe On Air Ep 3", "https://www.youtube.com/embed/Kh8-ekuRmoI", "body3", "R&B GroupTwice", new DateTime(2021,03,04))

                );

            modelBuilder.Entity<Comment>().HasData(
                new Comment(1, 2, "TOM", "stuff")
                );
        }

    }
}
