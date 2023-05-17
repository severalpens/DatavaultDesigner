using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class _21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblColReleases",
                schema: "meta",
                columns: table => new
                {
                    TblColId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TblId = table.Column<int>(type: "int", nullable: true),
                    ColId = table.Column<int>(type: "int", nullable: true),
                    ReleaseId = table.Column<int>(type: "int", nullable: true),
                    TblName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblColReleases", x => x.TblColId);
                    table.ForeignKey(
                        name: "fk_TblColReleases_Releases",
                        column: x => x.ReleaseId,
                        principalSchema: "meta",
                        principalTable: "Releases",
                        principalColumn: "ReleaseId");
                    table.ForeignKey(
                        name: "fk_TblCollReleases_Cols",
                        column: x => x.ColId,
                        principalSchema: "meta",
                        principalTable: "Cols",
                        principalColumn: "ColId");
                    table.ForeignKey(
                        name: "fk_TblCollReleases_Tbls",
                        column: x => x.TblId,
                        principalSchema: "meta",
                        principalTable: "Tbls",
                        principalColumn: "TblId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblColReleases_ColId",
                schema: "meta",
                table: "TblColReleases",
                column: "ColId");

            migrationBuilder.CreateIndex(
                name: "IX_TblColReleases_ReleaseId",
                schema: "meta",
                table: "TblColReleases",
                column: "ReleaseId");

            migrationBuilder.CreateIndex(
                name: "IX_TblColReleases_TblId",
                schema: "meta",
                table: "TblColReleases",
                column: "TblId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblColReleases",
                schema: "meta");
        }
    }
}
