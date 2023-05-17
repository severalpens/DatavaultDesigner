using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class mweffffd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KeyMappingValueId",
                schema: "adfc",
                table: "KeyMappings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KeyMappingValueId",
                schema: "adfc",
                table: "KeyMappings",
                type: "int",
                nullable: true);
        }
    }
}
