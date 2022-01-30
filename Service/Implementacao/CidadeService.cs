using Dominio.GeotecnologiaModel;
using Repositorio.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementacao
{
    public class CidadeService : ICidadeService
    {
        private readonly ICidadeRepositorio _repositorio;

        public CidadeService(ICidadeRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<Cidade> BuscarCidadePorDescricao(string descricao)
        {
            return await _repositorio.BuscarCidadeIdPorDescricao(descricao);
        }

        public async Task<Cidade> CadastrarCidade(Cidade cidade)
        {
            return await _repositorio.AddAsync(cidade);
        }

        public async Task<IEnumerable<Cidade>> ListarCidades()
        {
            return await _repositorio.GetAllAsync();
        }
    }
}
