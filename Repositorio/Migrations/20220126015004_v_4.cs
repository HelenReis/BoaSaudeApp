using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorio.Migrations
{
    public partial class v_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConveniadoId",
                table: "Atendimento",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrestadorId",
                table: "Atendimento",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Conveniado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeUsuario = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    NomeFantasia = table.Column<string>(nullable: true),
                    Cnpj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conveniado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prestador",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeUsuario = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    CRM = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConveniadoPrestador",
                columns: table => new
                {
                    ConveniadoId = table.Column<int>(nullable: false),
                    PrestadorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConveniadoPrestador", x => new { x.ConveniadoId, x.PrestadorId });
                    table.ForeignKey(
                        name: "FK_ConveniadoPrestador_Conveniado_ConveniadoId",
                        column: x => x.ConveniadoId,
                        principalTable: "Conveniado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConveniadoPrestador_Prestador_PrestadorId",
                        column: x => x.PrestadorId,
                        principalTable: "Prestador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_ConveniadoId",
                table: "Atendimento",
                column: "ConveniadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_PrestadorId",
                table: "Atendimento",
                column: "PrestadorId");

            migrationBuilder.CreateIndex(
                name: "IX_ConveniadoPrestador_PrestadorId",
                table: "ConveniadoPrestador",
                column: "PrestadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Conveniado_ConveniadoId",
                table: "Atendimento",
                column: "ConveniadoId",
                principalTable: "Conveniado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Prestador_PrestadorId",
                table: "Atendimento",
                column: "PrestadorId",
                principalTable: "Prestador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Conveniado_ConveniadoId",
                table: "Atendimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Prestador_PrestadorId",
                table: "Atendimento");

            migrationBuilder.DropTable(
                name: "ConveniadoPrestador");

            migrationBuilder.DropTable(
                name: "Conveniado");

            migrationBuilder.DropTable(
                name: "Prestador");

            migrationBuilder.DropIndex(
                name: "IX_Atendimento_ConveniadoId",
                table: "Atendimento");

            migrationBuilder.DropIndex(
                name: "IX_Atendimento_PrestadorId",
                table: "Atendimento");

            migrationBuilder.DropColumn(
                name: "ConveniadoId",
                table: "Atendimento");

            migrationBuilder.DropColumn(
                name: "PrestadorId",
                table: "Atendimento");
        }
    }
}
