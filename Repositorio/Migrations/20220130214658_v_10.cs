using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorio.Migrations
{
    public partial class v_10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO ConveniadoPrestador (conveniadoId, prestadorId) VALUES " +
                "(1, 1)");

            migrationBuilder.Sql("INSERT INTO ConveniadoPrestador (conveniadoId, prestadorId) VALUES " +
                "(1, 2)");

            migrationBuilder.Sql("INSERT INTO ConveniadoPrestador (conveniadoId, prestadorId) VALUES " +
                "(1, 3)");

            migrationBuilder.Sql("INSERT INTO ConveniadoPrestador (conveniadoId, prestadorId) VALUES " +
                "(2, 1)");

            migrationBuilder.Sql("INSERT INTO ConveniadoPrestador (conveniadoId, prestadorId) VALUES " +
                "(2, 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
