using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorio.Migrations
{
    public partial class v_8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Cidade (descricao, codigoEstado) VALUES ('Nova Serrana', 'MG')");
            migrationBuilder.Sql("INSERT INTO Cidade (descricao, codigoEstado) VALUES ('Divinópolis', 'MG')");
            migrationBuilder.Sql("INSERT INTO Cidade (descricao, codigoEstado) VALUES ('Diamantina', 'MG')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
