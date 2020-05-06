using DotnetForum.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetForum.WebApi.Database
{
    public class ForumDatabaseContext : DbContext
    {
        public ForumDatabaseContext(DbContextOptions<ForumDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Attachment> Attachments { get; set; }

        public DbSet<PostTag> PostTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasIndex(e => e.Name).IsUnique();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.UserName).IsUnique();
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.Property(e => e.Body).HasColumnType("text");
            });
            
            modelBuilder.Entity<PostTag>()
                .HasKey(pt => new { pt.PostId, pt.TagName });

            modelBuilder.Entity<PostTag>()
                .HasOne(pt => pt.Post)
                .WithMany(p => p.PostTags)
                .HasForeignKey(pt => pt.PostId);

            modelBuilder.Entity<PostTag>()
                .HasOne(pt => pt.Tag)
                .WithMany(t => t.PostTags)
                .HasForeignKey(pt => pt.TagName);
        }
    }
}
