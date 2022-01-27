using Dominio.UsuarioModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.PlanoModel
{
    public class Plano : IClasseBase
    {
        public Plano(
            int tipoPlanoId,
            int categoriaPlanoId)
        {
            TipoPlanoId = tipoPlanoId;
            CategoriaPlanoId = categoriaPlanoId;
        }

        public int Id { get; set; }
        public string Descricao { get; private set; }
        public decimal ValorBase { get; private set; }
        public decimal PorcentagemDesconto { get; private set; }
        public int TipoPlanoId { get; private set; }
        public int CategoriaPlanoId { get; private set; }
        public TipoPlano TipoPlano { get; private set; }
        public CategoriaPlano CategoriaPlano { get; private set; }
        public virtual List<Associado> Associados { get; set; }
    }
}
