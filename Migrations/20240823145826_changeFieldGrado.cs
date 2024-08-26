using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estudiantes.Migrations
{
    /// <inheritdoc />
    public partial class changeFieldGrado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grado_Profesor_ProfesorId",
                table: "Grado");

            migrationBuilder.DropIndex(
                name: "IX_Grado_ProfesorId",
                table: "Grado");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Grado_ProfesorId",
                table: "Grado",
                column: "ProfesorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grado_Profesor_ProfesorId",
                table: "Grado",
                column: "ProfesorId",
                principalTable: "Profesor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
