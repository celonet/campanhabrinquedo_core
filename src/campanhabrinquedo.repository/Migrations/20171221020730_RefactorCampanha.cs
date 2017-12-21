using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace campanhabrinquedo.repository.Migrations
{
    public partial class RefactorCampanha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QtdeCriancas",
                table: "Campanha");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QtdeCriancas",
                table: "Campanha",
                nullable: false,
                defaultValue: 0);
        }
    }
}
