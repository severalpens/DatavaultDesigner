using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class _22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColId",
                schema: "meta",
                table: "Props");

            migrationBuilder.DropColumn(
                name: "ReleaseId",
                schema: "meta",
                table: "Props");

            migrationBuilder.RenameColumn(
                name: "TblId",
                schema: "meta",
                table: "Props",
                newName: "TblColReleaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Props_TblColReleaseId",
                schema: "meta",
                table: "Props",
                column: "TblColReleaseId");

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

            migrationBuilder.RenameColumn(
                name: "TblColReleaseId",
                schema: "meta",
                table: "Props",
                newName: "TblId");

            migrationBuilder.AddColumn<int>(
                name: "ColId",
                schema: "meta",
                table: "Props",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReleaseId",
                schema: "meta",
                table: "Props",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
