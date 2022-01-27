using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.UsuarioModel
{
    public class ConveniadoPrestador : IClasseBaseSemId
    {
        public int ConveniadoId { get; set; }
        public int PrestadorId { get; set; }
        public Conveniado Conveniado { get; set; }
        public Prestador Prestador { get; set; }
    }
}
