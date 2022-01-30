using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Endereco
    {
        [JsonProperty("data")]
        public IEnumerable<EnderecoDetalhes> Data { get; set; }
    }

    public class EnderecoDetalhes
    {
        [JsonProperty("region_code")]
        public string CodigoEstado { get; set; }

        [JsonProperty("administrative_area")]
        public string Cidade { get; set; }
    }
}
