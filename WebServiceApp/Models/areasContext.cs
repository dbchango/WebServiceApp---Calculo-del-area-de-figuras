using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebServiceApp.Models
{
    public partial class areasContext : DbContext
    {
        public areasContext()
        {
        }

        public areasContext(DbContextOptions<areasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Rectangle> Rectangle { get; set; }
        public virtual DbSet<Ring> Ring { get; set; }
        public virtual DbSet<Square> Square { get; set; }
        public virtual DbSet<Triangle> Triangle { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder
                    .UseSqlServer(
                    "Server=WIN-UCAFLUQQ626\\SQLEXPRESS; Database=areas; User ID=distdb; Password=David123"
                    );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rectangle>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Perimeter).HasColumnName("perimeter");

                entity.Property(e => e.Width).HasColumnName("width");
            });

            modelBuilder.Entity<Ring>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Perimeter).HasColumnName("perimeter");

                entity.Property(e => e.Radius).HasColumnName("radius");
            });

            modelBuilder.Entity<Square>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Perimeter).HasColumnName("perimeter");

                entity.Property(e => e.Side).HasColumnName("side");
            });

            modelBuilder.Entity<Triangle>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Perimeter).HasColumnName("perimeter");

                entity.Property(e => e.SideA).HasColumnName("sideA");

                entity.Property(e => e.SideB).HasColumnName("sideB");

                entity.Property(e => e.SideC).HasColumnName("sideC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
