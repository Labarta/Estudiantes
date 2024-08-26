using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estudiantes.Migrations
{
    /// <inheritdoc />
    public partial class agregarCampos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlumnoGrado_Alumno_AlumnoId",
                table: "AlumnoGrado");

            migrationBuilder.DropForeignKey(
                name: "FK_AlumnoGrado_Grado_GradoId",
                table: "AlumnoGrado");

            migrationBuilder.DropIndex(
                name: "IX_AlumnoGrado_AlumnoId",
                table: "AlumnoGrado");

            migrationBuilder.DropIndex(
                name: "IX_AlumnoGrado_GradoId",
                table: "AlumnoGrado");

            migrationBuilder.AddColumn<string>(
                name: "profesor",
                table: "Grado",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "profesor",
                table: "Grado");

            migrationBuilder.DropColumn(
                name: "Alumno",
                table: "AlumnoGrado");

            migrationBuilder.DropColumn(
                name: "Grado",
                table: "AlumnoGrado");

            migrationBuilder.CreateIndex(
                name: "IX_AlumnoGrado_AlumnoId",
                table: "AlumnoGrado",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlumnoGrado_GradoId",
                table: "AlumnoGrado",
                column: "GradoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AlumnoGrado_Alumno_AlumnoId",
                table: "AlumnoGrado",
                column: "AlumnoId",
                principalTable: "Alumno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AlumnoGrado_Grado_GradoId",
                table: "AlumnoGrado",
                column: "GradoId",
                principalTable: "Grado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
