using Dominio.GeotecnologiaModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Interface
{
    public interface ICidadeRepositorio
    {
        Task<IEnumerable<Cidade>> GetAllAsync(params string[] includeProperties);
    }
}
