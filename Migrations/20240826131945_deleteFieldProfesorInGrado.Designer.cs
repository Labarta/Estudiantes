﻿// <auto-generated />
using System;
using Estudiantes.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Estudiantes.Migrations
{
    [DbContext(typeof(EstudiantesDbContext))]
    [Migration("20240826131945_deleteFieldProfesorInGrado")]
    partial class deleteFieldProfesorInGrado
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Estudiantes.Models.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Alumno");
                });

            modelBuilder.Entity("Estudiantes.Models.AlumnoGrado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AlumnoId")
                        .HasColumnType("int");

                    b.Property<int>("GradoId")
                        .HasColumnType("int");

                    b.Property<string>("Seccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AlumnoGrado");
                });

            modelBuilder.Entity("Estudiantes.Models.Grado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfesorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Grado");
                });

            modelBuilder.Entity("Estudiantes.Models.Profesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profesor");
                });

            modelBuilder.Entity("Estudiantes.Models.Registro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Curso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Horario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Materia")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profesor")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Matricula")
                        .IsUnique();

                    b.HasIndex("Materia", "Fecha", "Profesor")
                        .IsUnique()
                        .HasFilter("[Materia] IS NOT NULL AND [Fecha] IS NOT NULL AND [Profesor] IS NOT NULL");

                    b.ToTable("Registros");
                });

            modelBuilder.Entity("Estudiantes.Models.obtenerGrado", b =>
                {
                    b.Property<string>("Grado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Grado");

                    b.Property<int>("GradoId")
                        .HasColumnType("int")
                        .HasColumnName("gradoId");

                    b.Property<string>("Profesor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Profesor");

                    b.ToTable((string)null);

                    b.ToView(null, (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
