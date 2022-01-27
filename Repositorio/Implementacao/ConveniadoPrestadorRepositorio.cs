using Dominio.UsuarioModel;
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
    public class ConveniadoPrestadorRepositorio : RepositorioBase<ConveniadoPrestador>, IConveniadoPrestadorRepositorio
    {
        public ConveniadoPrestadorRepositorio(DataContext dbContext) : base(dbContext)
        { }

        public async Task<IEnumerable<ConveniadoPrestador>> BuscarConveniadorPorPrestador(int prestadorId)
        {
            Expression<Func<ConveniadoPrestador, bool>> funcao = (associado) => associado.PrestadorId == prestadorId;

            var query = this.dbSet.Where(funcao).Include("Conveniado");

            return await query.ToListAsync();
        }
    }
}
