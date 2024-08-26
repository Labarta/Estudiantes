using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estudiantes.Migrations
{
    /// <inheritdoc />
    public partial class deleteFieldProfesorInGrado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "profesor",
                table: "Grado");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "profesor",
                table: "Grado",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
