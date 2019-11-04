using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace bisk.model
{
    class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions options) : base(options){}

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }


        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Blog>()
        //         .Property(b => b.Url)
        //         .IsRequired();
        // }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        [Required,MaxLength(500)]
        public string Url { get; set; }
        [Timestamp]
        public byte[] Timestamp { get; set; }
        public List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        [Required,MaxLength(25)]
        public string ShortTitle { get; set; }
        [Required,MaxLength(255),MinLength(20)]
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}