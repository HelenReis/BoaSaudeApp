using Newtonsoft.Json;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Dominio
{
    public class Coordenadas
    {
        [JsonProperty("latitude")]
        public float Latitude { get; set; }

        [JsonProperty("longitude")]
        public float Longitude { get; set; }

        public string ParaString()
        {
            var latitude = Regex.Replace(Latitude.ToString(), ",", ".");
            var longitude = Regex.Replace(Longitude.ToString(), ",", ".");
            var coordenadasFormatadas = $"{latitude},{longitude}";

            return coordenadasFormatadas;
        }
    }
}
