using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class mwef : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "adfc");

            migrationBuilder.CreateTable(
                name: "AdfConfigs",
                schema: "adfc",
                columns: table => new
                {
                    AdfConfigId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParameterCodeId = table.Column<int>(type: "int", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pattern = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdfConfigs", x => x.AdfConfigId);
                });

            migrationBuilder.CreateTable(
                name: "HubInfoHubKeys",
                schema: "adfc",
                columns: table => new
                {
                    HubInfoHubKeyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HubInfoHubId = table.Column<int>(type: "int", nullable: true),
                    HubKeyName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HubInfoHubKeys", x => x.HubInfoHubKeyId);
                });

            migrationBuilder.CreateTable(
                name: "HubInfoHubs",
                schema: "adfc",
                columns: table => new
                {
                    HubInfoHubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HubInfoId = table.Column<int>(type: "int", nullable: true),
                    HubName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HubInfoHubs", x => x.HubInfoHubId);
                });

            migrationBuilder.CreateTable(
                name: "HubInfos",
                schema: "adfc",
                columns: table => new
                {
                    HubInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdfConfigId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HubInfos", x => x.HubInfoId);
                });

            migrationBuilder.CreateTable(
                name: "KeyMappings",
                schema: "adfc",
                columns: table => new
                {
                    KeyMappingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HubInfoId = table.Column<int>(type: "int", nullable: true),
                    KeyMappingValueId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyMappings", x => x.KeyMappingId);
                });

            migrationBuilder.CreateTable(
                name: "KeyMappingValues",
                schema: "adfc",
                columns: table => new
                {
                    KeyMappingValueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyMappingId = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyMappingValues", x => x.KeyMappingValueId);
                });

            migrationBuilder.CreateTable(
                name: "ParameterCodes",
                schema: "adfc",
                columns: table => new
                {
                    ParameterCodeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterCodes", x => x.ParameterCodeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdfConfigs",
                schema: "adfc");

            migrationBuilder.DropTable(
                name: "HubInfoHubKeys",
                schema: "adfc");

            migrationBuilder.DropTable(
                name: "HubInfoHubs",
                schema: "adfc");

            migrationBuilder.DropTable(
                name: "HubInfos",
                schema: "adfc");

            migrationBuilder.DropTable(
                name: "KeyMappings",
                schema: "adfc");

            migrationBuilder.DropTable(
                name: "KeyMappingValues",
                schema: "adfc");

            migrationBuilder.DropTable(
                name: "ParameterCodes",
                schema: "adfc");
        }
    }
}
