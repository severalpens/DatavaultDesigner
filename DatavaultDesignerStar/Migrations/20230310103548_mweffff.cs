using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class mweffff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdfConfigOriginalId",
                schema: "adfc",
                table: "AdfConfigs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OldId",
                schema: "adfc",
                table: "AdfConfigs",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdfConfigOriginalId",
                schema: "adfc",
                table: "AdfConfigs");

            migrationBuilder.DropColumn(
                name: "OldId",
                schema: "adfc",
                table: "AdfConfigs");
        }
    }
}
