using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace campanhabrinquedo.repository.Migrations
{
    public partial class relationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuario",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Usuario",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuario",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RG",
                table: "Responsavel",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Responsavel",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Padrinho",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Padrinho",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Crianca",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Idade",
                table: "Crianca",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Comunidade",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Comunidade",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Campanha",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CampanhaCrianca",
                columns: table => new
                {
                    CampanhaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CriancaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampanhaCrianca", x => new { x.CampanhaId, x.CriancaId });
                    table.ForeignKey(
                        name: "FK_CampanhaCrianca_Campanha_CampanhaId",
                        column: x => x.CampanhaId,
                        principalTable: "Campanha",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampanhaCrianca_Crianca_CriancaId",
                        column: x => x.CriancaId,
                        principalTable: "Crianca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampanhaPadrinho",
                columns: table => new
                {
                    CampanhaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PadrinhoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampanhaPadrinho", x => new { x.CampanhaId, x.PadrinhoId });
                    table.ForeignKey(
                        name: "FK_CampanhaPadrinho_Campanha_CampanhaId",
                        column: x => x.CampanhaId,
                        principalTable: "Campanha",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampanhaPadrinho_Padrinho_PadrinhoId",
                        column: x => x.PadrinhoId,
                        principalTable: "Padrinho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampanhaResponsavel",
                columns: table => new
                {
                    CampanhaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResponsavelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampanhaResponsavel", x => new { x.CampanhaId, x.ResponsavelId });
                    table.ForeignKey(
                        name: "FK_CampanhaResponsavel_Campanha_CampanhaId",
                        column: x => x.CampanhaId,
                        principalTable: "Campanha",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampanhaResponsavel_Responsavel_ResponsavelId",
                        column: x => x.ResponsavelId,
                        principalTable: "Responsavel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComunidadeCrianca",
                columns: table => new
                {
                    ComunidadeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CriancaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComunidadeCrianca", x => new { x.ComunidadeId, x.CriancaId });
                    table.ForeignKey(
                        name: "FK_ComunidadeCrianca_Comunidade_ComunidadeId",
                        column: x => x.ComunidadeId,
                        principalTable: "Comunidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComunidadeCrianca_Crianca_CriancaId",
                        column: x => x.CriancaId,
                        principalTable: "Crianca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComunidadePadrinho",
                columns: table => new
                {
                    ComunidadeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PadrinhoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComunidadePadrinho", x => new { x.ComunidadeId, x.PadrinhoId });
                    table.ForeignKey(
                        name: "FK_ComunidadePadrinho_Comunidade_ComunidadeId",
                        column: x => x.ComunidadeId,
                        principalTable: "Comunidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComunidadePadrinho_Padrinho_PadrinhoId",
                        column: x => x.PadrinhoId,
                        principalTable: "Padrinho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResponsavelCrianca",
                columns: table => new
                {
                    ResponsavelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CriancaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponsavelCrianca", x => new { x.ResponsavelId, x.CriancaId });
                    table.ForeignKey(
                        name: "FK_ResponsavelCrianca_Crianca_CriancaId",
                        column: x => x.CriancaId,
                        principalTable: "Crianca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResponsavelCrianca_Responsavel_ResponsavelId",
                        column: x => x.ResponsavelId,
                        principalTable: "Responsavel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CampanhaCrianca_CriancaId",
                table: "CampanhaCrianca",
                column: "CriancaId");

            migrationBuilder.CreateIndex(
                name: "IX_CampanhaPadrinho_PadrinhoId",
                table: "CampanhaPadrinho",
                column: "PadrinhoId");

            migrationBuilder.CreateIndex(
                name: "IX_CampanhaResponsavel_ResponsavelId",
                table: "CampanhaResponsavel",
                column: "ResponsavelId");

            migrationBuilder.CreateIndex(
                name: "IX_ComunidadeCrianca_CriancaId",
                table: "ComunidadeCrianca",
                column: "CriancaId");

            migrationBuilder.CreateIndex(
                name: "IX_ComunidadePadrinho_PadrinhoId",
                table: "ComunidadePadrinho",
                column: "PadrinhoId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponsavelCrianca_CriancaId",
                table: "ResponsavelCrianca",
                column: "CriancaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampanhaCrianca");

            migrationBuilder.DropTable(
                name: "CampanhaPadrinho");

            migrationBuilder.DropTable(
                name: "CampanhaResponsavel");

            migrationBuilder.DropTable(
                name: "ComunidadeCrianca");

            migrationBuilder.DropTable(
                name: "ComunidadePadrinho");

            migrationBuilder.DropTable(
                name: "ResponsavelCrianca");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuario",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Usuario",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuario",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "RG",
                table: "Responsavel",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Responsavel",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Padrinho",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Padrinho",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Crianca",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Idade",
                table: "Crianca",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Comunidade",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Comunidade",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Campanha",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);
        }
    }
}
