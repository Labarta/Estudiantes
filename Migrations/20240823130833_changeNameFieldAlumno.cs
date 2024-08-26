using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estudiantes.Migrations
{
    /// <inheritdoc />
    public partial class changeNameFieldAlumno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Género",
                table: "Alumno",
                newName: "Genero");

            migrationBuilder.RenameColumn(
                name: "Apellidos",
                table: "Alumno",
                newName: "Apellido");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Genero",
                table: "Alumno",
                newName: "Género");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "Alumno",
                newName: "Apellidos");
        }
    }
}
