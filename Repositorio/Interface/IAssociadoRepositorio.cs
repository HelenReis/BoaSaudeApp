using Dominio.UsuarioModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositorio
{
    public interface IAssociadoRepositorio
    {
        Task<IEnumerable<Associado>> BuscarAssociadosAtivos();
    }
}
