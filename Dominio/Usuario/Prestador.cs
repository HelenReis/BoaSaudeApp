using Dominio.AtendimentoModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Usuario
{
    public class Prestador : UsuarioBase, IClasseBase
    {
        public string Nome { get; set; }
        public string CRM { get; set; }
        public virtual List<Atendimento> Atendimentos { get; set; }
        public ICollection<ConveniadoPrestador> ConveniadosPrestadores { get; set; }
    }
}
