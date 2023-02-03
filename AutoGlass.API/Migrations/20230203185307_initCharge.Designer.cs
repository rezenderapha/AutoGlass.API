﻿// <auto-generated />
using System;
using AutoGlass.API.Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AutoGlass.API.Migrations
{
    [DbContext(typeof(AutoGlassContext))]
    [Migration("20230203185307_initCharge")]
    partial class initCharge
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("AutoGlass.API.Domain.Entities.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("character varying(14)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("SituacaoFornecedor")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cnpj = "43336155000106",
                            Descricao = "Mil e uma peças",
                            SituacaoFornecedor = true
                        },
                        new
                        {
                            Id = 2,
                            Cnpj = "82824469000100",
                            Descricao = "Felicidade em Fornecer",
                            SituacaoFornecedor = true
                        },
                        new
                        {
                            Id = 3,
                            Cnpj = "45315523000165",
                            Descricao = "Uma noite na oficina",
                            SituacaoFornecedor = true
                        },
                        new
                        {
                            Id = 4,
                            Cnpj = "02770479000170",
                            Descricao = "A peça filosofal",
                            SituacaoFornecedor = true
                        },
                        new
                        {
                            Id = 5,
                            Cnpj = "27580353000164",
                            Descricao = "Um desejo, uma peça",
                            SituacaoFornecedor = true
                        },
                        new
                        {
                            Id = 6,
                            Cnpj = "44732984000170",
                            Descricao = "Peças e Morty",
                            SituacaoFornecedor = true
                        },
                        new
                        {
                            Id = 7,
                            Cnpj = "08884481000157",
                            Descricao = "The big bang peças",
                            SituacaoFornecedor = true
                        },
                        new
                        {
                            Id = 8,
                            Cnpj = "71151701000170",
                            Descricao = "Fornecedor do Norte",
                            SituacaoFornecedor = true
                        });
                });

            modelBuilder.Entity("AutoGlass.API.Domain.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("DataFabricacao")
                        .HasColumnType("Date");

                    b.Property<DateTime?>("DataValidade")
                        .HasColumnType("Date");

                    b.Property<string>("DescricaoProduto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("FornecedorId")
                        .HasColumnType("integer");

                    b.Property<bool>("SituacaoProduto")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Produto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DescricaoProduto = "Retrovisor Civic",
                            FornecedorId = 1,
                            SituacaoProduto = true
                        },
                        new
                        {
                            Id = 2,
                            DataFabricacao = new DateTime(2022, 9, 22, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(2802),
                            DataValidade = new DateTime(2024, 5, 20, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6923),
                            DescricaoProduto = "Parachoque Corsa",
                            FornecedorId = 2,
                            SituacaoProduto = true
                        },
                        new
                        {
                            Id = 3,
                            DataFabricacao = new DateTime(2021, 2, 13, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6939),
                            DataValidade = new DateTime(2024, 1, 14, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6940),
                            DescricaoProduto = "Lanterna Fiorino",
                            FornecedorId = 2,
                            SituacaoProduto = true
                        },
                        new
                        {
                            Id = 4,
                            DescricaoProduto = "Retrovisor Tucson",
                            FornecedorId = 3,
                            SituacaoProduto = true
                        },
                        new
                        {
                            Id = 5,
                            DataFabricacao = new DateTime(2021, 4, 27, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6943),
                            DataValidade = new DateTime(2023, 12, 21, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6943),
                            DescricaoProduto = "Parachoque Palio",
                            FornecedorId = 4,
                            SituacaoProduto = true
                        },
                        new
                        {
                            Id = 6,
                            DataFabricacao = new DateTime(2023, 2, 3, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6951),
                            DataValidade = new DateTime(2042, 8, 27, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6952),
                            DescricaoProduto = "Radiador Citroen",
                            FornecedorId = 5,
                            SituacaoProduto = true
                        },
                        new
                        {
                            Id = 7,
                            DataFabricacao = new DateTime(2023, 2, 3, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6953),
                            DataValidade = new DateTime(2024, 5, 22, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6954),
                            DescricaoProduto = "Ventoinha Onix",
                            FornecedorId = 6,
                            SituacaoProduto = true
                        },
                        new
                        {
                            Id = 8,
                            DataFabricacao = new DateTime(2023, 2, 3, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6955),
                            DataValidade = new DateTime(2025, 7, 19, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6956),
                            DescricaoProduto = "Grade Ford Ka",
                            FornecedorId = 6,
                            SituacaoProduto = true
                        },
                        new
                        {
                            Id = 9,
                            DataFabricacao = new DateTime(2023, 2, 3, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6957),
                            DataValidade = new DateTime(2025, 10, 17, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6958),
                            DescricaoProduto = "Reservatorio de Agua Kwid",
                            FornecedorId = 6,
                            SituacaoProduto = true
                        },
                        new
                        {
                            Id = 10,
                            DataFabricacao = new DateTime(2023, 2, 3, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6990),
                            DataValidade = new DateTime(2024, 11, 12, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6992),
                            DescricaoProduto = "Radiador Ford",
                            FornecedorId = 8,
                            SituacaoProduto = true
                        },
                        new
                        {
                            Id = 11,
                            DataFabricacao = new DateTime(2020, 5, 9, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6994),
                            DataValidade = new DateTime(2024, 11, 12, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6995),
                            DescricaoProduto = "Porta Fusca",
                            FornecedorId = 3,
                            SituacaoProduto = true
                        });
                });

            modelBuilder.Entity("AutoGlass.API.Domain.Entities.Produto", b =>
                {
                    b.HasOne("AutoGlass.API.Domain.Entities.Fornecedor", "Fornecedor")
                        .WithMany("Produto")
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("AutoGlass.API.Domain.Entities.Fornecedor", b =>
                {
                    b.Navigation("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}
