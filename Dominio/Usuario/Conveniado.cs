using Dominio.AtendimentoModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Usuario
{
    public class Conveniado : UsuarioBase, IClasseBase
    {
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public virtual List<Atendimento> Atendimentos { get; set; }
        public ICollection<ConveniadoPrestador> ConveniadosPrestadores { get; set; }
    }
}
