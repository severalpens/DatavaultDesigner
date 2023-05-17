using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class _45t43ffffd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ReleaseTblCols_ColTypeId",
                schema: "meta",
                table: "ReleaseTblCols",
                column: "ColTypeId");

            migrationBuilder.AddForeignKey(
                name: "fk_TblCollReleases_ColTypes",
                schema: "meta",
                table: "ReleaseTblCols",
                column: "ColTypeId",
                principalSchema: "meta",
                principalTable: "ColTypes",
                principalColumn: "ColTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_TblCollReleases_ColTypes",
                schema: "meta",
                table: "ReleaseTblCols");

            migrationBuilder.DropIndex(
                name: "IX_ReleaseTblCols_ColTypeId",
                schema: "meta",
                table: "ReleaseTblCols");
        }
    }
}
