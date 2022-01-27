using Dominio.UsuarioModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IAssociadoService
    {
        Task<IEnumerable<Associado>> BuscarAssociadosAtivos();
    }
}
