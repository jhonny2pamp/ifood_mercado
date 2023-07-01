using System.Text.Json.Serialization;

namespace IfoodMercado.Models
{
    public class ProductResponse
    {
        [JsonPropertyName("idLoja")]
        public int IdLoja { get; set; }

        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("error")]
        public ProductIfoodResponseError Error { get; set; }
    }

    public class ProductIfoodResponseError
    {
        [JsonPropertyName("codigo")]
        public string Code { get; set; }

        [JsonPropertyName("descricao")]
        public string Description { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
