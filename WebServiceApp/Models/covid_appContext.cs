using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebServiceApp.Models
{
    public partial class covid_appContext : DbContext
    {
        public covid_appContext()
        {
        }

        public covid_appContext(DbContextOptions<covid_appContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:dbchango.database.windows.net,1433;Initial Catalog=covid_app;Persist Security Info=False;User ID=dbchango;Password=##David##@1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.HasKey(e => e.IdPaciente);

                entity.ToTable("paciente");

                entity.Property(e => e.IdPaciente).HasColumnName("id_paciente");

                entity.Property(e => e.Altura).HasColumnName("altura");

                entity.Property(e => e.Cedula)
                    .HasColumnName("cedula")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnName("fecha_modificacion")
                    .HasColumnType("date");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Peso).HasColumnName("peso");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Contrasena)
                    .HasColumnName("contrasena")
                    .HasMaxLength(50);

                entity.Property(e => e.Correo)
                    .HasColumnName("correo")
                    .HasMaxLength(50);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnName("fecha_modificacion")
                    .HasColumnType("date");

                entity.Property(e => e.NombreUsuario)
                    .HasColumnName("nombre_usuario")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
