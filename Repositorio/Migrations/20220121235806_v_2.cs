using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorio.Migrations
{
    public partial class v_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Usuarios (id, nome) VALUES (1,'Teste nome')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
