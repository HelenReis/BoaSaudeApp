using Dominio.UsuarioModel;
using Repositorio.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementacao
{
    public class PrestadorService : IPrestadorService
    {
        private readonly IPrestadorRepositorio _repositorio;

        public PrestadorService(IPrestadorRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<Prestador> Adicionar(Prestador obj)
        {
            return await _repositorio.AddAsync(obj); 
        }

        public async Task<Prestador> BuscarPrestador(string email)
        {
            return await _repositorio.BuscarPrestador(email);
        }
    }
}
