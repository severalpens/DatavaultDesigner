using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class m5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TblCol",
                schema: "meta",
                table: "TblCol");

            migrationBuilder.RenameTable(
                name: "TblCol",
                schema: "meta",
                newName: "TblCols",
                newSchema: "meta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblCols",
                schema: "meta",
                table: "TblCols",
                column: "TblColId");

            migrationBuilder.CreateTable(
                name: "TblReleases",
                schema: "meta",
                columns: table => new
                {
                    TblReleaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TblId = table.Column<int>(type: "int", nullable: true),
                    ReleaseId = table.Column<int>(type: "int", nullable: true),
                    TblName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblReleases", x => x.TblReleaseId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblReleases",
                schema: "meta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblCols",
                schema: "meta",
                table: "TblCols");

            migrationBuilder.RenameTable(
                name: "TblCols",
                schema: "meta",
                newName: "TblCol",
                newSchema: "meta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblCol",
                schema: "meta",
                table: "TblCol",
                column: "TblColId");
        }
    }
}
