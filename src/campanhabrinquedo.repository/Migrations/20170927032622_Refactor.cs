using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace campanhabrinquedo.repositorio.Migrations
{
    public partial class Refactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crianca_Comunidade_ComunidadeId",
                table: "Crianca");

            migrationBuilder.DropForeignKey(
                name: "FK_Crianca_Responsavel_ResponsavelId",
                table: "Crianca");

            migrationBuilder.DropForeignKey(
                name: "FK_Padrinho_Comunidade_ComunidadeId",
                table: "Padrinho");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Responsavel",
                table: "Responsavel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Padrinho",
                table: "Padrinho");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Crianca",
                table: "Crianca");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comunidade",
                table: "Comunidade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Campanha",
                table: "Campanha");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "ResponsavelId",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "PadrinhoId",
                table: "Padrinho");

            migrationBuilder.DropColumn(
                name: "CriancaId",
                table: "Crianca");

            migrationBuilder.DropColumn(
                name: "ComunidadeId",
                table: "Comunidade");

            migrationBuilder.DropColumn(
                name: "CampanhaId",
                table: "Campanha");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Usuario",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Responsavel",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Padrinho",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Crianca",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Comunidade",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Campanha",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Responsavel",
                table: "Responsavel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Padrinho",
                table: "Padrinho",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Crianca",
                table: "Crianca",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comunidade",
                table: "Comunidade",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Campanha",
                table: "Campanha",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Crianca_Comunidade_ComunidadeId",
                table: "Crianca",
                column: "ComunidadeId",
                principalTable: "Comunidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Crianca_Responsavel_ResponsavelId",
                table: "Crianca",
                column: "ResponsavelId",
                principalTable: "Responsavel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Padrinho_Comunidade_ComunidadeId",
                table: "Padrinho",
                column: "ComunidadeId",
                principalTable: "Comunidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crianca_Comunidade_ComunidadeId",
                table: "Crianca");

            migrationBuilder.DropForeignKey(
                name: "FK_Crianca_Responsavel_ResponsavelId",
                table: "Crianca");

            migrationBuilder.DropForeignKey(
                name: "FK_Padrinho_Comunidade_ComunidadeId",
                table: "Padrinho");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Responsavel",
                table: "Responsavel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Padrinho",
                table: "Padrinho");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Crianca",
                table: "Crianca");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comunidade",
                table: "Comunidade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Campanha",
                table: "Campanha");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Padrinho");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Crianca");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Comunidade");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Campanha");

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "Usuario",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ResponsavelId",
                table: "Responsavel",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PadrinhoId",
                table: "Padrinho",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CriancaId",
                table: "Crianca",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ComunidadeId",
                table: "Comunidade",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CampanhaId",
                table: "Campanha",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Responsavel",
                table: "Responsavel",
                column: "ResponsavelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Padrinho",
                table: "Padrinho",
                column: "PadrinhoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Crianca",
                table: "Crianca",
                column: "CriancaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comunidade",
                table: "Comunidade",
                column: "ComunidadeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Campanha",
                table: "Campanha",
                column: "CampanhaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Crianca_Comunidade_ComunidadeId",
                table: "Crianca",
                column: "ComunidadeId",
                principalTable: "Comunidade",
                principalColumn: "ComunidadeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Crianca_Responsavel_ResponsavelId",
                table: "Crianca",
                column: "ResponsavelId",
                principalTable: "Responsavel",
                principalColumn: "ResponsavelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Padrinho_Comunidade_ComunidadeId",
                table: "Padrinho",
                column: "ComunidadeId",
                principalTable: "Comunidade",
                principalColumn: "ComunidadeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
