using Dominio.UsuarioModel;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Implementacao
{
    public class ConveniadoRepositorio : RepositorioBase<Conveniado>, IConveniadoRepositorio
    {
        public ConveniadoRepositorio(DataContext dbContext) : base(dbContext)
        {
        }
    }
}
