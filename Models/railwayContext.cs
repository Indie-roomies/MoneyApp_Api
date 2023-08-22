using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MoneyApp_Api.Models
{
    public partial class railwayContext : DbContext
    {
        public railwayContext()
        {
        }

        public railwayContext(DbContextOptions<railwayContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Job> Jobs { get; set; } = null!;
        public virtual DbSet<Taxis> Taxes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("name=ConnectionStrings:Db", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.1.0-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Job>(entity =>
            {
                entity.HasKey(e => e.IdTask)
                    .HasName("PRIMARY");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Taxis>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
