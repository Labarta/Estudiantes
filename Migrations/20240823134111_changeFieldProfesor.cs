using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estudiantes.Migrations
{
    /// <inheritdoc />
    public partial class changeFieldProfesor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Género",
                table: "Profesor",
                newName: "Genero");

            migrationBuilder.RenameColumn(
                name: "Apellidos",
                table: "Profesor",
                newName: "Apellido");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Genero",
                table: "Profesor",
                newName: "Género");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "Profesor",
                newName: "Apellidos");
        }
    }
}
