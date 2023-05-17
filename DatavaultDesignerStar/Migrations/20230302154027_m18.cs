using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class m18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "meta",
                table: "Tbls");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "meta",
                table: "Cols");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "meta",
                table: "Tbls",
                type: "bit",
                nullable: false,
                defaultValueSql: "(CONVERT([bit],(0)))");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "meta",
                table: "Cols",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
