using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class _45t43 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_TblCollReleases_Cols",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropTable(
                name: "TblCols",
                schema: "meta");

            migrationBuilder.DropTable(
                name: "TblReleases",
                schema: "meta");

            migrationBuilder.DropTable(
                name: "Cols",
                schema: "meta");

            migrationBuilder.DropIndex(
                name: "IX_TblColReleases_ColId",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "Architecture",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "Branch",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "ColId",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "DbName",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "IsIncluded",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "IsReleased",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "Keep",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "Notebook",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "Pattern",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "Pipeline",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "SchemaName",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "Source",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "Trigger",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.AddColumn<string>(
                name: "Architecture",
                schema: "meta",
                table: "Releases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pattern",
                schema: "meta",
                table: "Releases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Source",
                schema: "meta",
                table: "Releases",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Architecture",
                schema: "meta",
                table: "Releases");

            migrationBuilder.DropColumn(
                name: "Pattern",
                schema: "meta",
                table: "Releases");

            migrationBuilder.DropColumn(
                name: "Source",
                schema: "meta",
                table: "Releases");

            migrationBuilder.AddColumn<string>(
                name: "Architecture",
                schema: "meta",
                table: "TblColReleases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Branch",
                schema: "meta",
                table: "TblColReleases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ColId",
                schema: "meta",
                table: "TblColReleases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DbName",
                schema: "meta",
                table: "TblColReleases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsIncluded",
                schema: "meta",
                table: "TblColReleases",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsReleased",
                schema: "meta",
                table: "TblColReleases",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Keep",
                schema: "meta",
                table: "TblColReleases",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Notebook",
                schema: "meta",
                table: "TblColReleases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pattern",
                schema: "meta",
                table: "TblColReleases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pipeline",
                schema: "meta",
                table: "TblColReleases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SchemaName",
                schema: "meta",
                table: "TblColReleases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Source",
                schema: "meta",
                table: "TblColReleases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Trigger",
                schema: "meta",
                table: "TblColReleases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cols",
                schema: "meta",
                columns: table => new
                {
                    ColId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatatypeDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cols", x => x.ColId);
                });

            migrationBuilder.CreateTable(
                name: "TblReleases",
                schema: "meta",
                columns: table => new
                {
                    TblReleaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReleaseId = table.Column<int>(type: "int", nullable: true),
                    TblId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ReleaseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TblName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblReleases", x => x.TblReleaseId);
                    table.ForeignKey(
                        name: "fk_TblReleases_Releases",
                        column: x => x.ReleaseId,
                        principalSchema: "meta",
                        principalTable: "Releases",
                        principalColumn: "ReleaseId");
                    table.ForeignKey(
                        name: "fk_TblReleases_Tbls",
                        column: x => x.TblId,
                        principalSchema: "meta",
                        principalTable: "Tbls",
                        principalColumn: "TblId");
                });

            migrationBuilder.CreateTable(
                name: "TblCols",
                schema: "meta",
                columns: table => new
                {
                    TblColId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColId = table.Column<int>(type: "int", nullable: true),
                    TblId = table.Column<int>(type: "int", nullable: true),
                    ColName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    TblName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCols", x => x.TblColId);
                    table.ForeignKey(
                        name: "fk_TblCols_Cols",
                        column: x => x.ColId,
                        principalSchema: "meta",
                        principalTable: "Cols",
                        principalColumn: "ColId");
                    table.ForeignKey(
                        name: "fk_TblCols_Tbls",
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
                name: "IX_TblCols_ColId",
                schema: "meta",
                table: "TblCols",
                column: "ColId");

            migrationBuilder.CreateIndex(
                name: "IX_TblCols_TblId",
                schema: "meta",
                table: "TblCols",
                column: "TblId");

            migrationBuilder.CreateIndex(
                name: "IX_TblReleases_ReleaseId",
                schema: "meta",
                table: "TblReleases",
                column: "ReleaseId");

            migrationBuilder.CreateIndex(
                name: "IX_TblReleases_TblId",
                schema: "meta",
                table: "TblReleases",
                column: "TblId");

            migrationBuilder.AddForeignKey(
                name: "fk_TblCollReleases_Cols",
                schema: "meta",
                table: "TblColReleases",
                column: "ColId",
                principalSchema: "meta",
                principalTable: "Cols",
                principalColumn: "ColId");
        }
    }
}
