namespace Dominio.GeotecnologiaModel
{
    public class Cidade
    {
        public Cidade(string descricao, string codigoEstado)
        {
            Descricao = descricao;
            CodigoEstado = codigoEstado;
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string CodigoEstado { get; set; }
    }
}
