using Estudiantes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Estudiantes.Context
{
    public class EstudiantesDbContext : DbContext
    {
       
        public EstudiantesDbContext(DbContextOptions<EstudiantesDbContext> options)
            : base(options)
        {
        }

        public DbSet<Registro> Registros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registro>()
                .HasIndex(r => r.Matricula)
                .IsUnique();

            modelBuilder.Entity<Registro>()
                .HasIndex(r => new { r.Materia, r.Fecha, r.Profesor })
                .IsUnique();
            

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<obtenerGrado>(entity =>
            {
                entity.HasNoKey();
                entity.ToView(null); // Con esto evitamos que lo mapee comouna tabla
                entity.Property(e => e.GradoId).HasColumnName("gradoId");
                entity.Property(e => e.Grado).HasColumnName("Grado");
                entity.Property(e => e.Profesor).HasColumnName("Profesor");
            });
        }
        public DbSet<Estudiantes.Models.Alumno> Alumno { get; set; } = default!;
        public DbSet<Estudiantes.Models.Profesor> Profesor { get; set; } = default!;
        public DbSet<Estudiantes.Models.Grado> Grado { get; set; } = default!;
        public DbSet<Estudiantes.Models.AlumnoGrado> AlumnoGrado { get; set; } = default!;
        public DbSet<Estudiantes.Models.obtenerGrado> BobtenerGrado { get; set; } = default!;
    }
}
