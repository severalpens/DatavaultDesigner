﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    /// <inheritdoc />
    public partial class erio34oifdrdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                schema: "meta",
                table: "Tbls",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderId",
                schema: "meta",
                table: "Tbls");
        }
    }
}
