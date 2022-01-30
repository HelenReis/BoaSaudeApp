using Dominio.GeotecnologiaModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ICidadeService
    {
        Task<Cidade> BuscarCidadePorDescricao(string descricao);
        Task<Cidade> CadastrarCidade(Cidade cidade);
        Task<IEnumerable<Cidade>> ListarCidades();
    }
}
