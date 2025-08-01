﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using myfinance_web_netcore.Data;

#nullable disable

namespace myfinance_web_netcore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250705154656_UpdatedSeedData")]
    partial class UpdatedSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

            modelBuilder.Entity("myfinance_web_netcore.Models.PlanoContas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Codigo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("datetime('now')");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("Tipo")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Codigo")
                        .IsUnique()
                        .HasDatabaseName("IX_PlanoContas_Codigo");

                    b.ToTable("PlanoContas", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Codigo = 1,
                            DataCriacao = new DateTime(2025, 7, 5, 12, 46, 56, 146, DateTimeKind.Local).AddTicks(5325),
                            Descricao = "Combustível",
                            Tipo = 0
                        },
                        new
                        {
                            Id = 2,
                            Codigo = 2,
                            DataCriacao = new DateTime(2025, 7, 5, 12, 46, 56, 146, DateTimeKind.Local).AddTicks(5326),
                            Descricao = "Supermercado",
                            Tipo = 0
                        },
                        new
                        {
                            Id = 3,
                            Codigo = 3,
                            DataCriacao = new DateTime(2025, 7, 5, 12, 46, 56, 146, DateTimeKind.Local).AddTicks(5328),
                            Descricao = "Alimentação",
                            Tipo = 0
                        },
                        new
                        {
                            Id = 4,
                            Codigo = 4,
                            DataCriacao = new DateTime(2025, 7, 5, 12, 46, 56, 146, DateTimeKind.Local).AddTicks(5329),
                            Descricao = "IPTU",
                            Tipo = 0
                        },
                        new
                        {
                            Id = 5,
                            Codigo = 5,
                            DataCriacao = new DateTime(2025, 7, 5, 12, 46, 56, 146, DateTimeKind.Local).AddTicks(5330),
                            Descricao = "IPVA",
                            Tipo = 0
                        },
                        new
                        {
                            Id = 6,
                            Codigo = 6,
                            DataCriacao = new DateTime(2025, 7, 5, 12, 46, 56, 146, DateTimeKind.Local).AddTicks(5331),
                            Descricao = "Salário",
                            Tipo = 1
                        },
                        new
                        {
                            Id = 7,
                            Codigo = 7,
                            DataCriacao = new DateTime(2025, 7, 5, 12, 46, 56, 146, DateTimeKind.Local).AddTicks(5332),
                            Descricao = "Escola",
                            Tipo = 0
                        },
                        new
                        {
                            Id = 8,
                            Codigo = 8,
                            DataCriacao = new DateTime(2025, 7, 5, 12, 46, 56, 146, DateTimeKind.Local).AddTicks(5333),
                            Descricao = "Financiamento de Carro",
                            Tipo = 0
                        });
                });

            modelBuilder.Entity("myfinance_web_netcore.Models.Transacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("datetime('now')");

                    b.Property<string>("Historico")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<int>("PlanoContasId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("PlanoContasId");

                    b.ToTable("Transacoes", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Data = new DateTime(2025, 7, 5, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(2025, 7, 5, 12, 46, 56, 146, DateTimeKind.Local).AddTicks(5437),
                            Historico = "Supermercado",
                            PlanoContasId = 2,
                            Valor = 450.00m
                        },
                        new
                        {
                            Id = 2,
                            Data = new DateTime(2025, 6, 23, 20, 30, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(2025, 7, 5, 12, 46, 56, 146, DateTimeKind.Local).AddTicks(5440),
                            Historico = "Jantar",
                            PlanoContasId = 3,
                            Valor = 250.00m
                        },
                        new
                        {
                            Id = 3,
                            Data = new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(2025, 7, 5, 12, 46, 56, 146, DateTimeKind.Local).AddTicks(5441),
                            Historico = "Salário",
                            PlanoContasId = 6,
                            Valor = 2000.00m
                        },
                        new
                        {
                            Id = 4,
                            Data = new DateTime(2025, 7, 1, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(2025, 7, 5, 12, 46, 56, 146, DateTimeKind.Local).AddTicks(5443),
                            Historico = "Mensalidade Escola",
                            PlanoContasId = 7,
                            Valor = 870.00m
                        });
                });

            modelBuilder.Entity("myfinance_web_netcore.Models.Transacao", b =>
                {
                    b.HasOne("myfinance_web_netcore.Models.PlanoContas", "PlanoContas")
                        .WithMany()
                        .HasForeignKey("PlanoContasId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("PlanoContas");
                });
#pragma warning restore 612, 618
        }
    }
}
