using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estudiantes.Migrations
{
    /// <inheritdoc />
    public partial class changeFieldAlumnoGrado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alumno",
                table: "AlumnoGrado");

            migrationBuilder.DropColumn(
                name: "Grado",
                table: "AlumnoGrado");

            migrationBuilder.RenameColumn(
                name: "Sección",
                table: "AlumnoGrado",
                newName: "Seccion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Seccion",
                table: "AlumnoGrado",
                newName: "Sección");

            migrationBuilder.AddColumn<string>(
                name: "Alumno",
                table: "AlumnoGrado",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Grado",
                table: "AlumnoGrado",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
