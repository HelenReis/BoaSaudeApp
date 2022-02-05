using Dominio.PlanoModel;
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
    public class PrestadorRepositorio : RepositorioBase<Prestador>, IPrestadorRepositorio
    {
        public PrestadorRepositorio(DataContext dbContext) : base(dbContext)
        {
        }

        public async Task<Prestador> BuscarPrestador(string email)
        {
            Expression<Func<Prestador, bool>> funcao = (associado) => associado.Email.Equals(email);
            var query = this.dbSet.Where(funcao);
            return await query.SingleOrDefaultAsync();
        }
    }
}
