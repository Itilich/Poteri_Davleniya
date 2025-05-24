using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Poteri_Davleniya.Migrations
{
    /// <inheritdoc />
    public partial class New123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "smoke_temp_2",
                table: "Variants",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "smoke_temp_2",
                table: "Variants");
        }
    }
}
