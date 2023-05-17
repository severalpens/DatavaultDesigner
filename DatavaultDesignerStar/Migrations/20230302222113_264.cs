using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class _264 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Props_TblColReleases_TblColReleaseId",
                schema: "meta",
                table: "Props");

            migrationBuilder.DropIndex(
                name: "IX_Props_TblColReleaseId",
                schema: "meta",
                table: "Props");

            migrationBuilder.AlterColumn<int>(
                name: "TblColReleaseId",
                schema: "meta",
                table: "Props",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Props_TblColReleaseId",
                schema: "meta",
                table: "Props",
                column: "TblColReleaseId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Props_TblColReleases_TblColReleaseId",
                schema: "meta",
                table: "Props",
                column: "TblColReleaseId",
                principalSchema: "meta",
                principalTable: "TblColReleases",
                principalColumn: "TblColReleaseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Props_TblColReleases_TblColReleaseId",
                schema: "meta",
                table: "Props");

            migrationBuilder.DropIndex(
                name: "IX_Props_TblColReleaseId",
                schema: "meta",
                table: "Props");

            migrationBuilder.AlterColumn<int>(
                name: "TblColReleaseId",
                schema: "meta",
                table: "Props",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Props_TblColReleaseId",
                schema: "meta",
                table: "Props",
                column: "TblColReleaseId",
                unique: true,
                filter: "[TblColReleaseId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Props_TblColReleases_TblColReleaseId",
                schema: "meta",
                table: "Props",
                column: "TblColReleaseId",
                principalSchema: "meta",
                principalTable: "TblColReleases",
                principalColumn: "TblColReleaseId");
        }
    }
}
