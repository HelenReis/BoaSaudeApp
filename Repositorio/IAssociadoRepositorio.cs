using Dominio.UsuarioModel;
using System.Threading.Tasks;

namespace Repositorio
{
    public interface IAssociadoRepositorio
    {
        Task<Associado> GetByIdAsync(int id);
    }
}
