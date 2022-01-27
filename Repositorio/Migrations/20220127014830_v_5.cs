using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorio.Migrations
{
    public partial class v_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CidadeId",
                table: "Atendimento",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusProcesso",
                table: "Atendimento",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CategoriaPlano",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaPlano", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    CodigoEstado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPlano",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPlano", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plano",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    ValorBase = table.Column<decimal>(nullable: false),
                    PorcentagemDesconto = table.Column<decimal>(nullable: false),
                    TipoPlanoId = table.Column<int>(nullable: false),
                    CategoriaPlanoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plano", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plano_CategoriaPlano_CategoriaPlanoId",
                        column: x => x.CategoriaPlanoId,
                        principalTable: "CategoriaPlano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plano_TipoPlano_TipoPlanoId",
                        column: x => x.TipoPlanoId,
                        principalTable: "TipoPlano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_CidadeId",
                table: "Atendimento",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Associado_PlanoId",
                table: "Associado",
                column: "PlanoId");

            migrationBuilder.CreateIndex(
                name: "IX_Plano_CategoriaPlanoId",
                table: "Plano",
                column: "CategoriaPlanoId");

            migrationBuilder.CreateIndex(
                name: "IX_Plano_TipoPlanoId",
                table: "Plano",
                column: "TipoPlanoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Associado_Plano_PlanoId",
                table: "Associado",
                column: "PlanoId",
                principalTable: "Plano",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Cidade_CidadeId",
                table: "Atendimento",
                column: "CidadeId",
                principalTable: "Cidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Associado_Plano_PlanoId",
                table: "Associado");

            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Cidade_CidadeId",
                table: "Atendimento");

            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "Plano");

            migrationBuilder.DropTable(
                name: "CategoriaPlano");

            migrationBuilder.DropTable(
                name: "TipoPlano");

            migrationBuilder.DropIndex(
                name: "IX_Atendimento_CidadeId",
                table: "Atendimento");

            migrationBuilder.DropIndex(
                name: "IX_Associado_PlanoId",
                table: "Associado");

            migrationBuilder.DropColumn(
                name: "CidadeId",
                table: "Atendimento");

            migrationBuilder.DropColumn(
                name: "StatusProcesso",
                table: "Atendimento");
        }
    }
}
