using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace campanhabrinquedo.repository.Migrations
{
    public partial class relationship_padrinho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PadrinhoCrianca",
                columns: table => new
                {
                    PadrinhoId = table.Column<Guid>(nullable: false),
                    CriancaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PadrinhoCrianca", x => new { x.PadrinhoId, x.CriancaId });
                    table.ForeignKey(
                        name: "FK_PadrinhoCrianca_Crianca_CriancaId",
                        column: x => x.CriancaId,
                        principalTable: "Crianca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PadrinhoCrianca_Padrinho_PadrinhoId",
                        column: x => x.PadrinhoId,
                        principalTable: "Padrinho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PadrinhoCrianca_CriancaId",
                table: "PadrinhoCrianca",
                column: "CriancaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PadrinhoCrianca");
        }
    }
}
