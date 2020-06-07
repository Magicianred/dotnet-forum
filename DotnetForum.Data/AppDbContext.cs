using DotnetForum.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace DotnetForum.Data
{
    public class AppDbContext : IdentityDbContext<Member, IdentityRole<int>, int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Agreement> Agreements { get; set; }

        public DbSet<Attachment> Attachments { get; set; }

        public DbSet<Forum> Forums { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<PostTag> PostTags { get; set; }

        public DbSet<Reply> Replies { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<MemberAgreement> MemberAgreements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Forum>(entity =>
            {
                entity.HasIndex(e => e.Name).IsUnique();
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

            modelBuilder.Entity<Member>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AccessFailedCount);

                entity.Property(e => e.ConcurrencyStamp).IsConcurrencyToken();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.EmailConfirmed);

                entity.Property(e => e.IsActive);

                entity.Property(e => e.IsAdmin);

                entity.Property(e => e.LockoutEnabled);

                entity.Property(e => e.LockoutEnd);

                entity.Property(e => e.MemberSince);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.PasswordHash);

                entity.Property(e => e.PhoneNumber);

                entity.Property(e => e.PhoneNumberConfirmed);

                entity.Property(e => e.ProfileImageUrl);

                entity.Property(e => e.Rating);

                entity.Property(e => e.SecurityStamp);

                entity.Property(e => e.TwoFactorEnabled);

                entity.Property(e => e.MemberDescription);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasKey(e => e.Id);

                entity.HasIndex(e => e.NormalizedEmail).HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .IsUnique()
                    .HasName("UserNameIndex")
                    .HasFilter("[NormalizedUserName] IS NOT NULL");

                entity.ToTable("AspNetUsers");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
