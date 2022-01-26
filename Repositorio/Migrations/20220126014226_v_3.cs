using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorio.Migrations
{
    public partial class v_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.CreateTable(
                name: "Associado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeUsuario = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    PlanoId = table.Column<int>(nullable: false),
                    QuantidadeExamesAno = table.Column<int>(nullable: false),
                    PossuiOdontologico = table.Column<bool>(nullable: false),
                    ValorPlanoAdicional = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Associado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Atendimento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Valor = table.Column<decimal>(nullable: false),
                    DataHorarioAgendamento = table.Column<DateTime>(nullable: false),
                    AssociadoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atendimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atendimento_Associado_AssociadoId",
                        column: x => x.AssociadoId,
                        principalTable: "Associado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_AssociadoId",
                table: "Atendimento",
                column: "AssociadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atendimento");

            migrationBuilder.DropTable(
                name: "Associado");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }
    }
}
