using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class m34353 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TblName",
                schema: "meta",
                table: "TblReleaseCols",
                newName: "ColType");

            migrationBuilder.AddColumn<int>(
                name: "ColTypeLen",
                schema: "meta",
                table: "TblReleaseCols",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColTypeLen",
                schema: "meta",
                table: "TblReleaseCols");

            migrationBuilder.RenameColumn(
                name: "ColType",
                schema: "meta",
                table: "TblReleaseCols",
                newName: "TblName");
        }
    }
}
