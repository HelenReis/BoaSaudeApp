using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.GeotecnologiaModel
{
    public class Localizacao
    {
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string País { get; set; }
    }
}
