﻿using Dominio.UsuarioModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Interface
{
    public interface IPrestadorRepositorio
    {
        Task<Prestador> AddAsync(Prestador obj);

        Task<Prestador> BuscarPrestador(string email);
    }
}
