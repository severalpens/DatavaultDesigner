using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class erwr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Props",
                schema: "meta");

            migrationBuilder.AddColumn<bool>(
                name: "Keep",
                schema: "meta",
                table: "TblColReleases",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Keep",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.CreateTable(
                name: "Props",
                schema: "meta",
                columns: table => new
                {
                    PropId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TblColReleaseId = table.Column<int>(type: "int", nullable: false),
                    Architecture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DbName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fk = table.Column<bool>(type: "bit", nullable: false),
                    FkCol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FkColId = table.Column<int>(type: "int", nullable: true),
                    FkTbl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FkTblId = table.Column<int>(type: "int", nullable: true),
                    HshDiff = table.Column<bool>(type: "bit", nullable: false),
                    HshDiffMember = table.Column<bool>(type: "bit", nullable: false),
                    HshKy = table.Column<bool>(type: "bit", nullable: false),
                    HshKyMember = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsReleased = table.Column<bool>(type: "bit", nullable: true),
                    Notebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pattern = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pipeline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pk = table.Column<bool>(type: "bit", nullable: false),
                    SchemaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trigger = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Props", x => x.PropId);
                    table.ForeignKey(
                        name: "FK_Props_TblColReleases_TblColReleaseId",
                        column: x => x.TblColReleaseId,
                        principalSchema: "meta",
                        principalTable: "TblColReleases",
                        principalColumn: "TblColReleaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Props_TblColReleaseId",
                schema: "meta",
                table: "Props",
                column: "TblColReleaseId",
                unique: true);
        }
    }
}
