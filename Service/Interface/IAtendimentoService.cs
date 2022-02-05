using Dominio.AtendimentoModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IAtendimentoService
    {
        Task NovoAtendimento(Atendimento atendimento);
        Task<IEnumerable<Atendimento>> ListarAtendimentos();
        Task<IEnumerable<Atendimento>> ListarAtendimentosPorPrestador(
            int id, DateTime dataInicio, DateTime dataFim);
    }
}
