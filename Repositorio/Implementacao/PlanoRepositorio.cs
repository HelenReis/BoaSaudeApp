using Dominio.PlanoModel;
using Dominio.UsuarioModel;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Implementacao
{
    public class PlanoRepositorio : RepositorioBase<Plano>, IConveniadoRepositorio
    {
        public PlanoRepositorio(DataContext dbContext) : base(dbContext)
        {
        }
    }
}
