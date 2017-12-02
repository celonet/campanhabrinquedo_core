﻿// <auto-generated />
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace campanhabrinquedo.repository.Migrations
{
    [DbContext(typeof(CampanhaBrinquedoContext))]
    partial class CampanhaBrinquedoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.Campanha", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Ano");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("QtdeCriancas");

                    b.HasKey("Id");

                    b.ToTable("Campanha");
                });

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.Comunidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Comunidade");
                });

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.Crianca", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Calcado");

                    b.Property<Guid?>("ComunidadeId");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<bool>("Especial");

                    b.Property<string>("Idade")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<bool>("Impresso");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<Guid?>("ResponsavelId");

                    b.Property<string>("Roupa")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<int>("Sexo");

                    b.HasKey("Id");

                    b.HasIndex("ComunidadeId");

                    b.HasIndex("ResponsavelId");

                    b.ToTable("Crianca");
                });

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.Padrinho", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Celular");

                    b.Property<Guid?>("ComunidadeId");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("ComunidadeId");

                    b.ToTable("Padrinho");
                });

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.PadrinhoCrianca", b =>
                {
                    b.Property<Guid>("PadrinhoId");

                    b.Property<Guid>("CriancaId");

                    b.HasKey("PadrinhoId", "CriancaId");

                    b.HasIndex("CriancaId");

                    b.ToTable("PadrinhoCrianca");
                });

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.Relationships.CampanhaCrianca", b =>
                {
                    b.Property<Guid>("CampanhaId");

                    b.Property<Guid>("CriancaId");

                    b.HasKey("CampanhaId", "CriancaId");

                    b.HasIndex("CriancaId");

                    b.ToTable("CampanhaCrianca");
                });

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.Relationships.CampanhaPadrinho", b =>
                {
                    b.Property<Guid>("CampanhaId");

                    b.Property<Guid>("PadrinhoId");

                    b.HasKey("CampanhaId", "PadrinhoId");

                    b.HasIndex("PadrinhoId");

                    b.ToTable("CampanhaPadrinho");
                });

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.Relationships.CampanhaResponsavel", b =>
                {
                    b.Property<Guid>("CampanhaId");

                    b.Property<Guid>("ResponsavelId");

                    b.HasKey("CampanhaId", "ResponsavelId");

                    b.HasIndex("ResponsavelId");

                    b.ToTable("CampanhaResponsavel");
                });

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.Relationships.ComunidadeCrianca", b =>
                {
                    b.Property<Guid>("ComunidadeId");

                    b.Property<Guid>("CriancaId");

                    b.HasKey("ComunidadeId", "CriancaId");

                    b.HasIndex("CriancaId");

                    b.ToTable("ComunidadeCrianca");
                });

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.Relationships.ComunidadePadrinho", b =>
                {
                    b.Property<Guid>("ComunidadeId");

                    b.Property<Guid>("PadrinhoId");

                    b.HasKey("ComunidadeId", "PadrinhoId");

                    b.HasIndex("PadrinhoId");

                    b.ToTable("ComunidadePadrinho");
                });

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.Relationships.ResponsavelCrianca", b =>
                {
                    b.Property<Guid>("ResponsavelId");

                    b.Property<Guid>("CriancaId");

                    b.HasKey("ResponsavelId", "CriancaId");

                    b.HasIndex("CriancaId");

                    b.ToTable("ResponsavelCrianca");
                });

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.Responsavel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Responsavel");
                });

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.Crianca", b =>
                {
                    b.HasOne("campanhabrinquedo.domain.Entities.Comunidade", "Comunidade")
                        .WithMany()
                        .HasForeignKey("ComunidadeId");

                    b.HasOne("campanhabrinquedo.domain.Entities.Responsavel", "Responsavel")
                        .WithMany()
                        .HasForeignKey("ResponsavelId");
                });

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.Padrinho", b =>
                {
                    b.HasOne("campanhabrinquedo.domain.Entities.Comunidade", "Comunidade")
                        .WithMany()
                        .HasForeignKey("ComunidadeId");
                });

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.PadrinhoCrianca", b =>
                {
                    b.HasOne("campanhabrinquedo.domain.Entities.Crianca", "Crianca")
                        .WithMany()
                        .HasForeignKey("CriancaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("campanhabrinquedo.domain.Entities.Padrinho", "Responsavel")
                        .WithMany("Criancas")
                        .HasForeignKey("PadrinhoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.Relationships.CampanhaCrianca", b =>
                {
                    b.HasOne("campanhabrinquedo.domain.Entities.Campanha", "Campanha")
                        .WithMany("Criancas")
                        .HasForeignKey("CampanhaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("campanhabrinquedo.domain.Entities.Crianca", "Crianca")
                        .WithMany()
                        .HasForeignKey("CriancaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.Relationships.CampanhaPadrinho", b =>
                {
                    b.HasOne("campanhabrinquedo.domain.Entities.Campanha", "Campanha")
                        .WithMany("Padrinhos")
                        .HasForeignKey("CampanhaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("campanhabrinquedo.domain.Entities.Padrinho", "Padrinho")
                        .WithMany()
                        .HasForeignKey("PadrinhoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.Relationships.CampanhaResponsavel", b =>
                {
                    b.HasOne("campanhabrinquedo.domain.Entities.Campanha", "Campanha")
                        .WithMany("Responsaveis")
                        .HasForeignKey("CampanhaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("campanhabrinquedo.domain.Entities.Responsavel", "Responsavel")
                        .WithMany()
                        .HasForeignKey("ResponsavelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.Relationships.ComunidadeCrianca", b =>
                {
                    b.HasOne("campanhabrinquedo.domain.Entities.Comunidade", "Comunidade")
                        .WithMany("Criancas")
                        .HasForeignKey("ComunidadeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("campanhabrinquedo.domain.Entities.Crianca", "Crianca")
                        .WithMany()
                        .HasForeignKey("CriancaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.Relationships.ComunidadePadrinho", b =>
                {
                    b.HasOne("campanhabrinquedo.domain.Entities.Comunidade", "Comunidade")
                        .WithMany("Padrinhos")
                        .HasForeignKey("ComunidadeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("campanhabrinquedo.domain.Entities.Padrinho", "Padrinho")
                        .WithMany()
                        .HasForeignKey("PadrinhoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("campanhabrinquedo.domain.Entities.Relationships.ResponsavelCrianca", b =>
                {
                    b.HasOne("campanhabrinquedo.domain.Entities.Crianca", "Crianca")
                        .WithMany()
                        .HasForeignKey("CriancaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("campanhabrinquedo.domain.Entities.Responsavel", "Responsavel")
                        .WithMany("Criancas")
                        .HasForeignKey("ResponsavelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
