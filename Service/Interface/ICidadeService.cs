using Dominio.GeotecnologiaModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ICidadeService
    {
        Task<IEnumerable<Cidade>> ListarCidades();
    }
}
