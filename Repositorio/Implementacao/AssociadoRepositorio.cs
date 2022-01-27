using Dominio.UsuarioModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repositorio
{
    public class AssociadoRepositorio : RepositorioBase<Associado>, IAssociadoRepositorio
    {
        public AssociadoRepositorio(DataContext dbContext) : base(dbContext)
        { }

        public async Task<IEnumerable<Associado>> BuscarAssociadosAtivos()
        {
            Expression<Func<Associado, bool>> funcao = 
                (associado) => associado.Status == StatusAssociadoEnum.Ativo;

            var query = this.dbSet.Where(funcao);

            return await query.ToListAsync();
        }
    }
}
