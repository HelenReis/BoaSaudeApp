using Dominio.UsuarioModel;
using Repositorio;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementacao
{
    public class AssociadoService : IAssociadoService
    {
        private readonly IAssociadoRepositorio _repositorio;

        public AssociadoService(IAssociadoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<IEnumerable<Associado>> BuscarAssociadosAtivos()
        {
            return await _repositorio.BuscarAssociadosAtivos();
        }
    }
}
