using Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public interface IUsuarioRepositorio
    {
        Task<Usuario> GetByIdAsync(int id);
    }
}
