using Dominio.UsuarioModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Interface
{
    public interface IConveniadoPrestadorRepositorio 
    {
        Task<IEnumerable<ConveniadoPrestador>> BuscarConveniadorPorPrestador(int prestadorId);
    }
}
