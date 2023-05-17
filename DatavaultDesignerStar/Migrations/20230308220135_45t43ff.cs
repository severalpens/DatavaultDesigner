using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class _45t43ff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblColReleases",
                schema: "meta");

            migrationBuilder.CreateTable(
                name: "TblReleaseCols",
                schema: "meta",
                columns: table => new
                {
                    TblReleaseColId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TblId = table.Column<int>(type: "int", nullable: true),
                    ReleaseId = table.Column<int>(type: "int", nullable: true),
                    ColName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColTypeLen = table.Column<int>(type: "int", nullable: true),
                    Fk = table.Column<bool>(type: "bit", nullable: false),
                    FkCol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FkColId = table.Column<int>(type: "int", nullable: true),
                    FkTbl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FkTblId = table.Column<int>(type: "int", nullable: true),
                    HshDiff = table.Column<bool>(type: "bit", nullable: false),
                    HshDiffMember = table.Column<bool>(type: "bit", nullable: false),
                    HshKy = table.Column<bool>(type: "bit", nullable: false),
                    HshKyMember = table.Column<bool>(type: "bit", nullable: false),
                    Pk = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    CandidateField = table.Column<bool>(type: "bit", nullable: false),
                    IncludedField = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblReleaseCols", x => x.TblReleaseColId);
                    table.ForeignKey(
                        name: "fk_TblCollReleases_Tbls",
                        column: x => x.TblId,
                        principalSchema: "meta",
                        principalTable: "Tbls",
                        principalColumn: "TblId");
                    table.ForeignKey(
                        name: "fk_TblReleaseCols_Releases",
                        column: x => x.ReleaseId,
                        principalSchema: "meta",
                        principalTable: "Releases",
                        principalColumn: "ReleaseId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblReleaseCols_ReleaseId",
                schema: "meta",
                table: "TblReleaseCols",
                column: "ReleaseId");

            migrationBuilder.CreateIndex(
                name: "IX_TblReleaseCols_TblId",
                schema: "meta",
                table: "TblReleaseCols",
                column: "TblId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblReleaseCols",
                schema: "meta");

            migrationBuilder.CreateTable(
                name: "TblColReleases",
                schema: "meta",
                columns: table => new
                {
                    TblColReleaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReleaseId = table.Column<int>(type: "int", nullable: true),
                    TblId = table.Column<int>(type: "int", nullable: true),
                    CandidateField = table.Column<bool>(type: "bit", nullable: false),
                    ColName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColTypeLen = table.Column<int>(type: "int", nullable: true),
                    Fk = table.Column<bool>(type: "bit", nullable: false),
                    FkCol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FkColId = table.Column<int>(type: "int", nullable: true),
                    FkTbl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FkTblId = table.Column<int>(type: "int", nullable: true),
                    HshDiff = table.Column<bool>(type: "bit", nullable: false),
                    HshDiffMember = table.Column<bool>(type: "bit", nullable: false),
                    HshKy = table.Column<bool>(type: "bit", nullable: false),
                    HshKyMember = table.Column<bool>(type: "bit", nullable: false),
                    IncludedField = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    Pk = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblColReleases", x => x.TblColReleaseId);
                    table.ForeignKey(
                        name: "fk_TblColReleases_Releases",
                        column: x => x.ReleaseId,
                        principalSchema: "meta",
                        principalTable: "Releases",
                        principalColumn: "ReleaseId");
                    table.ForeignKey(
                        name: "fk_TblCollReleases_Tbls",
                        column: x => x.TblId,
                        principalSchema: "meta",
                        principalTable: "Tbls",
                        principalColumn: "TblId");
                });

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
    }
}
