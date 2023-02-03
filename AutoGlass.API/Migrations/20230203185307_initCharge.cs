using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoGlass.API.Migrations
{
    public partial class initCharge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Fornecedor",
                columns: new[] { "Id", "Cnpj", "Descricao", "SituacaoFornecedor" },
                values: new object[,]
                {
                    { 1, "43336155000106", "Mil e uma peças", true },
                    { 2, "82824469000100", "Felicidade em Fornecer", true },
                    { 3, "45315523000165", "Uma noite na oficina", true },
                    { 4, "02770479000170", "A peça filosofal", true },
                    { 5, "27580353000164", "Um desejo, uma peça", true },
                    { 6, "44732984000170", "Peças e Morty", true },
                    { 7, "08884481000157", "The big bang peças", true },
                    { 8, "71151701000170", "Fornecedor do Norte", true }
                });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "DataFabricacao", "DataValidade", "DescricaoProduto", "FornecedorId", "SituacaoProduto" },
                values: new object[,]
                {
                    { 1, null, null, "Retrovisor Civic", 1, true },
                    { 2, new DateTime(2022, 9, 22, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(2802), new DateTime(2024, 5, 20, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6923), "Parachoque Corsa", 2, true },
                    { 3, new DateTime(2021, 2, 13, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6939), new DateTime(2024, 1, 14, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6940), "Lanterna Fiorino", 2, true },
                    { 4, null, null, "Retrovisor Tucson", 3, true },
                    { 11, new DateTime(2020, 5, 9, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6994), new DateTime(2024, 11, 12, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6995), "Porta Fusca", 3, true },
                    { 5, new DateTime(2021, 4, 27, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6943), new DateTime(2023, 12, 21, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6943), "Parachoque Palio", 4, true },
                    { 6, new DateTime(2023, 2, 3, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6951), new DateTime(2042, 8, 27, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6952), "Radiador Citroen", 5, true },
                    { 7, new DateTime(2023, 2, 3, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6953), new DateTime(2024, 5, 22, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6954), "Ventoinha Onix", 6, true },
                    { 8, new DateTime(2023, 2, 3, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6955), new DateTime(2025, 7, 19, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6956), "Grade Ford Ka", 6, true },
                    { 9, new DateTime(2023, 2, 3, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6957), new DateTime(2025, 10, 17, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6958), "Reservatorio de Agua Kwid", 6, true },
                    { 10, new DateTime(2023, 2, 3, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6990), new DateTime(2024, 11, 12, 15, 53, 7, 593, DateTimeKind.Local).AddTicks(6992), "Radiador Ford", 8, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fornecedor",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Fornecedor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fornecedor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fornecedor",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fornecedor",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fornecedor",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Fornecedor",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Fornecedor",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
