using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class _45t43fff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CharLen",
                schema: "meta",
                table: "ColTypes",
                newName: "DefaultLen");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DefaultLen",
                schema: "meta",
                table: "ColTypes",
                newName: "CharLen");
        }
    }
}
