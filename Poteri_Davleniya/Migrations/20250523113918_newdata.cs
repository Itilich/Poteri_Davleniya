using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Poteri_Davleniya.Migrations
{
    /// <inheritdoc />
    public partial class newdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Cd",
                table: "Variants",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Cs",
                table: "Variants",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "delta_h",
                table: "Variants",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "poteri1",
                table: "Variants",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "poteri2",
                table: "Variants",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "z2",
                table: "Variants",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cd",
                table: "Variants");

            migrationBuilder.DropColumn(
                name: "Cs",
                table: "Variants");

            migrationBuilder.DropColumn(
                name: "delta_h",
                table: "Variants");

            migrationBuilder.DropColumn(
                name: "poteri1",
                table: "Variants");

            migrationBuilder.DropColumn(
                name: "poteri2",
                table: "Variants");

            migrationBuilder.DropColumn(
                name: "z2",
                table: "Variants");
        }
    }
}
