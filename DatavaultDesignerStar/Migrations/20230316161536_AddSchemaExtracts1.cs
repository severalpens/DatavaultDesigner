using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class AddSchemaExtracts1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SchemaExtracts",
                schema: "adfc",
                columns: table => new
                {
                    SchemaExtractId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchemaExtracts", x => x.SchemaExtractId);
                    table.ForeignKey(
                        name: "FK_SchemaExtracts_SchemaExtracts_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "adfc",
                        principalTable: "SchemaExtracts",
                        principalColumn: "SchemaExtractId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SchemaExtracts_ParentId",
                schema: "adfc",
                table: "SchemaExtracts",
                column: "ParentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchemaExtracts",
                schema: "adfc");
        }
    }
}
