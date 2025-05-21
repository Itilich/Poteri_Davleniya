using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Poteri_Davleniya.Migrations
{
    /// <inheritdoc />
    public partial class Variants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Variants",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    pipe_lenght = table.Column<double>(type: "REAL", nullable: false),
                    pipe_quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    rows_along = table.Column<int>(type: "INTEGER", nullable: false),
                    rows_across = table.Column<int>(type: "INTEGER", nullable: false),
                    step_along = table.Column<double>(type: "REAL", nullable: false),
                    step_across = table.Column<double>(type: "REAL", nullable: false),
                    pipe_diameter = table.Column<double>(type: "REAL", nullable: false),
                    pipe_thickness = table.Column<double>(type: "REAL", nullable: false),
                    smoke_temp = table.Column<double>(type: "REAL", nullable: false),
                    heating_air_temp = table.Column<double>(type: "REAL", nullable: false),
                    air_temp = table.Column<double>(type: "REAL", nullable: false),
                    heating_air_outgo = table.Column<double>(type: "REAL", nullable: false),
                    space_air_pass = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variants", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Variants");
        }
    }
}
