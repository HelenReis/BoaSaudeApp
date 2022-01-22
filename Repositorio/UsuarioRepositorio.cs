using Dominio;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly DbContext dbContext;
        private readonly DbSet<Usuario> dbSet;

        public UsuarioRepositorio(DataContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = this.dbContext.Set<Usuario>();
        }

        public virtual async Task<Usuario> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }
    }
}
