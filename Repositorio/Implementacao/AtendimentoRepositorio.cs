using Dominio.AtendimentoModel;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Implementacao
{
    public class AtendimentoRepositorio : RepositorioBase<Atendimento>, IAtendimentoRepositorio
    {
        public AtendimentoRepositorio(DataContext dbContext) : base(dbContext)
        {
        }
    }
}
