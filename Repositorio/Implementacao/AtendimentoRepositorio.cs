using Dominio.AtendimentoModel;
using Microsoft.EntityFrameworkCore;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Implementacao
{
    public class AtendimentoRepositorio : RepositorioBase<Atendimento>, IAtendimentoRepositorio
    {
        public AtendimentoRepositorio(DataContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Atendimento>> BuscarAtendimentosPorPrestador(
            int id,
            DateTime dataInicio,
            DateTime dataFim)
        {
            var query = this.dbSet
                .Where(a => a.PrestadorId == id)
                .Where(a =>
                    a.DataHorarioAgendamento.Date >= dataInicio.Date &&
                    a.DataHorarioAgendamento.Date <= dataFim.Date)
                .Include("Associado");

            return await query.ToListAsync();
        }
    }
}
