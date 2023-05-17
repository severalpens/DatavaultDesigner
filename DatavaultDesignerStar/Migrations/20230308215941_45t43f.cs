using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class _45t43f : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ColTypes",
                schema: "meta",
                columns: table => new
                {
                    ColTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatabricksName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AzureSqlName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsChar = table.Column<bool>(type: "bit", nullable: false),
                    CharLen = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColTypes", x => x.ColTypeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColTypes",
                schema: "meta");
        }
    }
}
