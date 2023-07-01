using System.Text.Json.Serialization;

namespace IfoodMercado.Models
{
    public class Product
    {
        [JsonPropertyName("idLoja")]
        public int IdLoja { get; set; }

        [JsonPropertyName("departamento")]
        public string Departamento { get; set; }

        [JsonPropertyName("categoria")]
        public string Categoria { get; set; }

        [JsonPropertyName("subCategoria")]
        public string SubCategoria { get; set; }

        [JsonPropertyName("marca")]
        public string Marca { get; set; }

        [JsonPropertyName("unidade")]
        public string Unidade { get; set; }

        [JsonPropertyName("volume")]
        public string Volume { get; set; }

        [JsonPropertyName("codigoBarra")]
        public string CodigoBarra { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("valor")]
        public decimal Valor { get; set; }

        [JsonPropertyName("valorPromocao")]
        public decimal ValorPromocao { get; set; }

        [JsonPropertyName("valorAtacado")]
        public decimal ValorAtacado { get; set; }

        [JsonPropertyName("valorCompra")]
        public decimal ValorCompra { get; set; }

        [JsonPropertyName("quantidadeEstoqueAtual")]
        public int QuantidadeEstoqueAtual { get; set; }

        [JsonPropertyName("quantidadeEstoqueMinimo")]
        public int QuantidadeEstoqueMinimo { get; set; }

        [JsonPropertyName("quantidadeAtacado")]
        public int QuantidadeAtacado { get; set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }

        [JsonPropertyName("ativo")]
        public bool Ativo { get; set; }

        [JsonPropertyName("plu")]
        public string Plu { get; set; }

        [JsonPropertyName("validadeProxima")]
        public bool ValidadeProxima { get; set; }

        [JsonPropertyName("imageURL")]
        public string ImageURL { get; set; }
    }
}