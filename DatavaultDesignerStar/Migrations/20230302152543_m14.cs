using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class m14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TblNameV2",
                schema: "meta",
                table: "Tbls");

            migrationBuilder.DropColumn(
                name: "TblOrderId",
                schema: "meta",
                table: "Tbls");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TblNameV2",
                schema: "meta",
                table: "Tbls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TblOrderId",
                schema: "meta",
                table: "Tbls",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
