using Dominio.GeotecnologiaModel;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Implementacao
{
    public class CidadeRepositorio : RepositorioBase<Cidade>, ICidadeRepositorio
    {
        public CidadeRepositorio(DataContext dbContext) : base(dbContext)
        { }
    }
}
