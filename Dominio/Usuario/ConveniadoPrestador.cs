using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Usuario
{
    public class ConveniadoPrestador
    {
        public int ConveniadoId { get; set; }
        public int PrestadorId { get; set; }
        public Conveniado Conveniado { get; set; }
        public Prestador Prestador { get; set; }
    }
}
