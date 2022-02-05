using Dominio.UsuarioModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IPrestadorService
    {
        Task<Prestador> Adicionar(Prestador obj);
        Task<Prestador> BuscarPrestador(string email);
    }
}
