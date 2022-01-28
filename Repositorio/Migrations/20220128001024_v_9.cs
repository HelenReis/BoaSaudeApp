using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorio.Migrations
{
    public partial class v_9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Atendimento (valor, statusProcesso, prestadorId, conveniadoId, dataHorarioAgendamento, associadoId, cidadeId) VALUES " +
                "(100, 0, 1, 1, '18-06-12 08:30:00', 1, 1)");
            migrationBuilder.Sql("INSERT INTO Atendimento (valor, statusProcesso, prestadorId, conveniadoId, dataHorarioAgendamento, associadoId, cidadeId) VALUES " +
                "(150, 1, 1, 1, '18-06-12 09:00:00', 2, 1)");
            migrationBuilder.Sql("INSERT INTO Atendimento (valor, statusProcesso, prestadorId, conveniadoId, dataHorarioAgendamento, associadoId, cidadeId) VALUES " +
                "(150, 1, 1, 1, '18-06-12 11:00:00', 3, 1)");
            migrationBuilder.Sql("INSERT INTO Atendimento (valor, statusProcesso, prestadorId, conveniadoId, dataHorarioAgendamento, associadoId, cidadeId) VALUES " +
                "(150, 1, 1, 1, '18-06-12 10:30:00', 4, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
