using Dominio.AtendimentoModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Interface
{
    public interface IAtendimentoRepositorio
    {
        Task<Atendimento> AddAsync(Atendimento obj);
        Task<IEnumerable<Atendimento>> GetAllAsync(params string[] includeProperties);
    }
}
