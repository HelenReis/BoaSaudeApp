using Dominio.UsuarioModel;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Repositorio
{
    public class AssociadoRepositorio : IAssociadoRepositorio
    {
        private readonly DbContext dbContext;
        private readonly DbSet<Associado> dbSet;

        public AssociadoRepositorio(DataContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = this.dbContext.Set<Associado>();
        }

        public virtual async Task<Associado> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

    }
}
