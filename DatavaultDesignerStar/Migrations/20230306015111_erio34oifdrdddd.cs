using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class erio34oifdrdddd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CandidateField",
                schema: "meta",
                table: "TblColReleases",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IncludedField",
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
                name: "CandidateField",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "IncludedField",
                schema: "meta",
                table: "TblColReleases");
        }
    }
}
