using System.Text.Json.Serialization;

namespace IfoodMercado.Models
{
    public class IfoodEvent
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("codigoPedido")]
        public string CodigoPedido { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("idLoja")]
        public int IdLoja { get; set; }
    }
}