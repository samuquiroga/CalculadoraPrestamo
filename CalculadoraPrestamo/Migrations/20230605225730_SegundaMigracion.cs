using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalculadoraPrestamo.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdTipo",
                table: "Interes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdTipo",
                table: "Interes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
