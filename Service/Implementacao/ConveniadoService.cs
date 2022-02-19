using Dominio.UsuarioModel;
using Repositorio.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementacao
{
    public class ConveniadoService : IConveniadoService
    {
        private readonly IConveniadoRepositorio _repositorio;

        public ConveniadoService(IConveniadoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<IEnumerable<Conveniado>> ListarConveniados()
        {
            return await _repositorio.GetAllAsync();
        }
    }
}
