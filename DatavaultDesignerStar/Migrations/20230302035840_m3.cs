using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ColName",
                schema: "meta",
                table: "TblCol",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TblName",
                schema: "meta",
                table: "TblCol",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColName",
                schema: "meta",
                table: "TblCol");

            migrationBuilder.DropColumn(
                name: "TblName",
                schema: "meta",
                table: "TblCol");
        }
    }
}
