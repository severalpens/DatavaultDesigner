using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class _264f : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "DbName",
                schema: "meta",
                table: "TblColReleases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Fk",
                schema: "meta",
                table: "TblColReleases",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FkCol",
                schema: "meta",
                table: "TblColReleases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FkColId",
                schema: "meta",
                table: "TblColReleases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FkTbl",
                schema: "meta",
                table: "TblColReleases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FkTblId",
                schema: "meta",
                table: "TblColReleases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HshDiff",
                schema: "meta",
                table: "TblColReleases",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HshDiffMember",
                schema: "meta",
                table: "TblColReleases",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HshKy",
                schema: "meta",
                table: "TblColReleases",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HshKyMember",
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

            migrationBuilder.AddColumn<bool>(
                name: "Pk",
                schema: "meta",
                table: "TblColReleases",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Architecture",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "Branch",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "DbName",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "Fk",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "FkCol",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "FkColId",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "FkTbl",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "FkTblId",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "HshDiff",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "HshDiffMember",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "HshKy",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "HshKyMember",
                schema: "meta",
                table: "TblColReleases");

            migrationBuilder.DropColumn(
                name: "IsReleased",
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
                name: "Pk",
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
        }
    }
}
