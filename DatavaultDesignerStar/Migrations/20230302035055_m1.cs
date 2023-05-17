using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "meta");

            migrationBuilder.CreateTable(
                name: "Cols",
                schema: "meta",
                columns: table => new
                {
                    ColId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatatypeDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColOrderId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ColNameV2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cols", x => x.ColId);
                });

            migrationBuilder.CreateTable(
                name: "Releases",
                schema: "meta",
                columns: table => new
                {
                    ReleaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReleaseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseOrderId = table.Column<int>(type: "int", nullable: false),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatabricksNotebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pipeline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PipelineTrigger = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Releases", x => x.ReleaseId);
                });

            migrationBuilder.CreateTable(
                name: "Tbls",
                schema: "meta",
                columns: table => new
                {
                    TblId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DbName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchemaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TblName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TblOrderId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    TblNameV2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbls", x => x.TblId);
                });

            migrationBuilder.CreateTable(
                name: "Props",
                schema: "meta",
                columns: table => new
                {
                    PropId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TblId = table.Column<int>(type: "int", nullable: false),
                    ColId = table.Column<int>(type: "int", nullable: false),
                    ReleaseId = table.Column<int>(type: "int", nullable: false),
                    DbName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchemaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pattern = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Architecture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pipeline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trigger = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsReleased = table.Column<bool>(type: "bit", nullable: true),
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
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Props", x => x.PropId);
                    table.ForeignKey(
                        name: "fk_Facts_Cols",
                        column: x => x.ColId,
                        principalSchema: "meta",
                        principalTable: "Cols",
                        principalColumn: "ColId");
                    table.ForeignKey(
                        name: "fk_Facts_Releases",
                        column: x => x.ReleaseId,
                        principalSchema: "meta",
                        principalTable: "Releases",
                        principalColumn: "ReleaseId");
                    table.ForeignKey(
                        name: "fk_Facts_Tbls",
                        column: x => x.TblId,
                        principalSchema: "meta",
                        principalTable: "Tbls",
                        principalColumn: "TblId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Props_ColId",
                schema: "meta",
                table: "Props",
                column: "ColId");

            migrationBuilder.CreateIndex(
                name: "IX_Props_ReleaseId",
                schema: "meta",
                table: "Props",
                column: "ReleaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Props_TblId",
                schema: "meta",
                table: "Props",
                column: "TblId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Props",
                schema: "meta");

            migrationBuilder.DropTable(
                name: "Cols",
                schema: "meta");

            migrationBuilder.DropTable(
                name: "Releases",
                schema: "meta");

            migrationBuilder.DropTable(
                name: "Tbls",
                schema: "meta");
        }
    }
}
