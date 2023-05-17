using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class m12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColNameV2",
                schema: "meta",
                table: "Cols");

            migrationBuilder.DropColumn(
                name: "ColOrderId",
                schema: "meta",
                table: "Cols");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "meta",
                table: "Cols");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ColNameV2",
                schema: "meta",
                table: "Cols",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ColOrderId",
                schema: "meta",
                table: "Cols",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "meta",
                table: "Cols",
                type: "bit",
                nullable: true);
        }
    }
}
