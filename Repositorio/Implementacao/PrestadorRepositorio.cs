using Dominio.PlanoModel;
using Dominio.UsuarioModel;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Implementacao
{
    public class PrestadorRepositorio : RepositorioBase<Prestador>, IConveniadoRepositorio
    {
        public PrestadorRepositorio(DataContext dbContext) : base(dbContext)
        {
        }
    }
}
