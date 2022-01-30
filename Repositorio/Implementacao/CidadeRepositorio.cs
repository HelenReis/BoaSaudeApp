using Dominio.GeotecnologiaModel;
using Microsoft.EntityFrameworkCore;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Implementacao
{
    public class CidadeRepositorio : RepositorioBase<Cidade>, ICidadeRepositorio
    {
        public CidadeRepositorio(DataContext dbContext) : base(dbContext)
        { }

        public async Task<Cidade> BuscarCidadeIdPorDescricao(string descricao)
        {
            Expression<Func<Cidade, bool>> funcao = (associado) =>
                associado.Descricao.Contains(descricao);

            var query = this.dbSet.Where(funcao);

            return await query.FirstOrDefaultAsync();
        }
    }
}
