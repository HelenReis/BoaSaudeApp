using Dominio;
using Dominio.Usuario;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public interface IAssociadoRepositorio
    {
        Task<Associado> GetByIdAsync(int id);
    }
}
