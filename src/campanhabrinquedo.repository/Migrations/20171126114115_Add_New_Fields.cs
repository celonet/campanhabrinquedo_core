using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace campanhabrinquedo.repository.Migrations
{
    public partial class Add_New_Fields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Calcado",
                table: "Crianca",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Roupa",
                table: "Crianca",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calcado",
                table: "Crianca");

            migrationBuilder.DropColumn(
                name: "Roupa",
                table: "Crianca");
        }
    }
}
