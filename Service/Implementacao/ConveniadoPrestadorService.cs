using Dominio.UsuarioModel;
using Repositorio.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementacao
{
    public class ConveniadoPrestadorService : IConveniadoPrestadorService
    {
        private readonly IConveniadoPrestadorRepositorio _repositorio;

        public ConveniadoPrestadorService(IConveniadoPrestadorRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<IEnumerable<ConveniadoPrestador>> BuscarConveniadosPorPrestador(int prestadorId)
        {
            return await _repositorio.BuscarConveniadorPorPrestador(prestadorId);
        }
    }
}
