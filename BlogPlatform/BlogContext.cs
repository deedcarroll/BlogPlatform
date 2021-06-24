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
                new Post(1,"The Vibe On Air Ep 1", "https://youtu.be/VkdND06ZY4k", "body1", "Author1", new DateTime(2021,03,01)),
                new Post(2,"THe Vibe On Air Ep 2", "https://www.youtube.com","body2", "Author2", new DateTime(2021,03,02)),
                new Post(3,"The Vibe On air Ep 3", "https://www.youtube.com","body3", "Author3", new DateTime(2021,03,03))

                );

            modelBuilder.Entity<Comment>().HasData(
                new Comment(1, 2, "TOM", "stuff")
                );
        }

    }
}
