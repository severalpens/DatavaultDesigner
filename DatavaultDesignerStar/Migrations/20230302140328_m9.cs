using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class m9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                schema: "meta",
                table: "Tbls",
                type: "bit",
                nullable: false,
                defaultValueSql: "(CONVERT([bit],(0)))",
                oldClrType: typeof(bool),
                oldType: "bit");

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

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_TblCols_Cols",
                schema: "meta",
                table: "TblCols");

            migrationBuilder.DropForeignKey(
                name: "fk_TblCols_Tbls",
                schema: "meta",
                table: "TblCols");

            migrationBuilder.DropForeignKey(
                name: "fk_TblReleases_Releases",
                schema: "meta",
                table: "TblReleases");

            migrationBuilder.DropForeignKey(
                name: "fk_TblReleases_Tbls",
                schema: "meta",
                table: "TblReleases");

            migrationBuilder.DropIndex(
                name: "IX_TblReleases_ReleaseId",
                schema: "meta",
                table: "TblReleases");

            migrationBuilder.DropIndex(
                name: "IX_TblReleases_TblId",
                schema: "meta",
                table: "TblReleases");

            migrationBuilder.DropIndex(
                name: "IX_TblCols_ColId",
                schema: "meta",
                table: "TblCols");

            migrationBuilder.DropIndex(
                name: "IX_TblCols_TblId",
                schema: "meta",
                table: "TblCols");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                schema: "meta",
                table: "Tbls",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "(CONVERT([bit],(0)))");

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

            migrationBuilder.AddForeignKey(
                name: "fk_Facts_Cols",
                schema: "meta",
                table: "Props",
                column: "ColId",
                principalSchema: "meta",
                principalTable: "Cols",
                principalColumn: "ColId");

            migrationBuilder.AddForeignKey(
                name: "fk_Facts_Releases",
                schema: "meta",
                table: "Props",
                column: "ReleaseId",
                principalSchema: "meta",
                principalTable: "Releases",
                principalColumn: "ReleaseId");

            migrationBuilder.AddForeignKey(
                name: "fk_Facts_Tbls",
                schema: "meta",
                table: "Props",
                column: "TblId",
                principalSchema: "meta",
                principalTable: "Tbls",
                principalColumn: "TblId");
        }
    }
}
