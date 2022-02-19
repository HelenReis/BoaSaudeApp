using Newtonsoft.Json;

namespace Dominio
{
    public class Endereco
    {
        [JsonProperty("address")]
        public EnderecoDetalhes Localizacao { get; set; }
    }

    public class EnderecoDetalhes
    {
        [JsonProperty("state")]
        public string Estado { get; set; }

        [JsonProperty("city")]
        public string Cidade { get; set; }
    }
}
