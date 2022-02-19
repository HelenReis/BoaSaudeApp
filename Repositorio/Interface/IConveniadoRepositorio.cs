using Dominio.UsuarioModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Interface
{
    public interface IConveniadoRepositorio
    {
        Task<IEnumerable<Conveniado>> GetAllAsync(params string[] includeProperties);
    }
}
