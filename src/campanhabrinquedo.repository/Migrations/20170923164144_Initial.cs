using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace campanhabrinquedo.repositorio.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campanha",
                columns: table => new
                {
                    CampanhaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtdeCriancas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campanha", x => x.CampanhaId);
                });

            migrationBuilder.CreateTable(
                name: "Comunidade",
                columns: table => new
                {
                    ComunidadeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comunidade", x => x.ComunidadeId);
                });

            migrationBuilder.CreateTable(
                name: "Responsavel",
                columns: table => new
                {
                    ResponsavelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsavel", x => x.ResponsavelId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Padrinho",
                columns: table => new
                {
                    PadrinhoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComunidadeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Padrinho", x => x.PadrinhoId);
                    table.ForeignKey(
                        name: "FK_Padrinho_Comunidade_ComunidadeId",
                        column: x => x.ComunidadeId,
                        principalTable: "Comunidade",
                        principalColumn: "ComunidadeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Crianca",
                columns: table => new
                {
                    CriancaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComunidadeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Especial = table.Column<bool>(type: "bit", nullable: false),
                    Idade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Impresso = table.Column<bool>(type: "bit", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsavelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Sexo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crianca", x => x.CriancaId);
                    table.ForeignKey(
                        name: "FK_Crianca_Comunidade_ComunidadeId",
                        column: x => x.ComunidadeId,
                        principalTable: "Comunidade",
                        principalColumn: "ComunidadeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Crianca_Responsavel_ResponsavelId",
                        column: x => x.ResponsavelId,
                        principalTable: "Responsavel",
                        principalColumn: "ResponsavelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Crianca_ComunidadeId",
                table: "Crianca",
                column: "ComunidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Crianca_ResponsavelId",
                table: "Crianca",
                column: "ResponsavelId");

            migrationBuilder.CreateIndex(
                name: "IX_Padrinho_ComunidadeId",
                table: "Padrinho",
                column: "ComunidadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Campanha");

            migrationBuilder.DropTable(
                name: "Crianca");

            migrationBuilder.DropTable(
                name: "Padrinho");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Responsavel");

            migrationBuilder.DropTable(
                name: "Comunidade");
        }
    }
}
