using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.PlanoModel
{
    public class CategoriaPlano
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual List<Plano> Planos { get; set; }
    }
}
