using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorio.Migrations
{
    public partial class v_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO TipoPlano (id, descricao) VALUES (1,'Individual')");
            migrationBuilder.Sql("INSERT INTO TipoPlano (id, descricao) VALUES (2,'Empresarial')");

            migrationBuilder.Sql("INSERT INTO CategoriaPlano (id, descricao) VALUES (1,'Enfermaria')");
            migrationBuilder.Sql("INSERT INTO CategoriaPlano (id, descricao) VALUES (2,'Apartamento')");
            migrationBuilder.Sql("INSERT INTO CategoriaPlano (id, descricao) VALUES (3,'Vip')");

            migrationBuilder.Sql("INSERT INTO Plano " +
                "(tipoPlanoId, categoriaPlanoId, descricao, valorBase, porcentagemDesconto) " +
                "VALUES (1, 1, 'Individual Enfermaria', 100, 10)");

            migrationBuilder.Sql("INSERT INTO Plano " +
                "(tipoPlanoId, categoriaPlanoId, descricao, valorBase, porcentagemDesconto) " +
                "VALUES (1, 2, 'Individual Apartamento', 200, 20)");

            migrationBuilder.Sql("INSERT INTO Plano " +
                "(tipoPlanoId, categoriaPlanoId, descricao, valorBase, porcentagemDesconto) " +
                "VALUES (1, 3, 'Individual Vip', 350, 30)");

            migrationBuilder.Sql("INSERT INTO Plano " +
                "(tipoPlanoId, categoriaPlanoId, descricao, valorBase, porcentagemDesconto) " +
                "VALUES (2, 1, 'Empresarial Enfermaria', 80, 10)");

            migrationBuilder.Sql("INSERT INTO Plano " +
                "(tipoPlanoId, categoriaPlanoId, descricao, valorBase, porcentagemDesconto) " +
                "VALUES (2, 2, 'Empresarial Apartamento', 180, 20)");

            migrationBuilder.Sql("INSERT INTO Plano " +
                "(tipoPlanoId, categoriaPlanoId, descricao, valorBase, porcentagemDesconto) " +
                "VALUES (2, 3, 'Empresarial Vip', 330, 30)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
