using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClimaTempo.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cidades_Estados_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrevisoesClima",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clima = table.Column<int>(type: "int", nullable: false),
                    TemperaturaMinima = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    TemperaturaMaxima = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    DataPrevisao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrevisoesClima", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrevisoesClima_Cidades_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Estados",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { 1, "Rio de Jaineiro", "RJ" });

            migrationBuilder.InsertData(
                table: "Estados",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { 2, "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { 3, 1, "Rio de Janeiro" },
                    { 4, 1, "Barra Mansa" },
                    { 5, 1, "Volta Redonda" },
                    { 1, 2, "São Paulo" },
                    { 2, 2, "Campinas" }
                });

            migrationBuilder.InsertData(
                table: "PrevisoesClima",
                columns: new[] { "Id", "CidadeId", "Clima", "DataPrevisao", "TemperaturaMaxima", "TemperaturaMinima" },
                values: new object[,]
                {
                    { 15, 3, 0, new DateTime(2022, 9, 12, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(622), 30m, 20m },
                    { 34, 5, 3, new DateTime(2022, 9, 17, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(694), 22m, 14m },
                    { 35, 5, 1, new DateTime(2022, 9, 18, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(698), 24m, 19m },
                    { 1, 1, 0, new DateTime(2022, 9, 12, 7, 40, 57, 637, DateTimeKind.Local).AddTicks(3198), 34m, 24m },
                    { 2, 1, 0, new DateTime(2022, 9, 13, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(505), 30m, 20m },
                    { 3, 1, 1, new DateTime(2022, 9, 14, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(562), 26m, 16m },
                    { 4, 1, 1, new DateTime(2022, 9, 15, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(571), 25m, 14m },
                    { 33, 5, 0, new DateTime(2022, 9, 16, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(691), 21m, 13m },
                    { 5, 1, 2, new DateTime(2022, 9, 16, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(576), 24m, 14m },
                    { 7, 1, 1, new DateTime(2022, 9, 18, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(584), 26m, 20m },
                    { 8, 2, 2, new DateTime(2022, 9, 12, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(589), 32m, 22m },
                    { 9, 2, 0, new DateTime(2022, 9, 13, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(597), 33m, 20m },
                    { 10, 2, 3, new DateTime(2022, 9, 14, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(602), 26m, 16m },
                    { 11, 2, 1, new DateTime(2022, 9, 15, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(605), 25m, 14m },
                    { 12, 2, 2, new DateTime(2022, 9, 16, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(609), 23m, 14m },
                    { 6, 1, 3, new DateTime(2022, 9, 17, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(580), 25m, 15m },
                    { 13, 2, 3, new DateTime(2022, 9, 17, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(613), 25m, 15m },
                    { 32, 5, 1, new DateTime(2022, 9, 15, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(688), 22m, 14m },
                    { 30, 5, 1, new DateTime(2022, 9, 13, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(681), 30m, 22m },
                    { 16, 3, 0, new DateTime(2022, 9, 13, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(629), 30m, 20m },
                    { 17, 3, 1, new DateTime(2022, 9, 14, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(635), 26m, 16m },
                    { 18, 3, 1, new DateTime(2022, 9, 15, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(639), 25m, 14m },
                    { 19, 3, 2, new DateTime(2022, 9, 16, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(642), 24m, 14m },
                    { 20, 3, 3, new DateTime(2022, 9, 17, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(646), 25m, 15m },
                    { 21, 3, 1, new DateTime(2022, 9, 18, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(649), 26m, 20m },
                    { 31, 5, 1, new DateTime(2022, 9, 14, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(684), 27m, 18m },
                    { 22, 4, 0, new DateTime(2022, 9, 12, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(652), 28m, 18m },
                    { 24, 4, 1, new DateTime(2022, 9, 14, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(660), 26m, 16m },
                    { 25, 4, 1, new DateTime(2022, 9, 15, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(663), 25m, 14m },
                    { 26, 4, 2, new DateTime(2022, 9, 16, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(667), 24m, 14m },
                    { 27, 4, 3, new DateTime(2022, 9, 17, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(671), 25m, 15m },
                    { 28, 4, 1, new DateTime(2022, 9, 18, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(674), 26m, 20m },
                    { 29, 5, 3, new DateTime(2022, 9, 12, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(678), 26m, 16m },
                    { 23, 4, 0, new DateTime(2022, 9, 13, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(656), 30m, 20m },
                    { 14, 2, 1, new DateTime(2022, 9, 18, 7, 40, 57, 639, DateTimeKind.Local).AddTicks(618), 26m, 20m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cidades_EstadoId",
                table: "Cidades",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_PrevisoesClima_CidadeId",
                table: "PrevisoesClima",
                column: "CidadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrevisoesClima");

            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.DropTable(
                name: "Estados");
        }
    }
}
