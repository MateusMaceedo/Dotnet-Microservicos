using System.Text.Json.Serialization;
using Amazon.DynamoDBv2.DataModel;

namespace Compartilhado.Models
{
  [DynamoDBTable("pedidos")]
    public class Pedido
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        [JsonPropertyName("valor_total")]
        public decimal ValorTotal { get; set; }
        [JsonPropertyName("data_de_criacao")]
        public DateTime DataDeCriacao { get; set; }
        [JsonPropertyName("produtos")]
        public List<Produto>? Produtos { get; set; }
        [JsonPropertyName("cliente")]
        public Cliente? Cliente { get; set; }
        [JsonPropertyName("pagamento")]
        public Pagamento? Pagamento { get; set; }
        [JsonPropertyName("justificativa")]
        public string? Justificativa { get; set; }
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        [JsonPropertyName("pago")]
        public bool Pago { get; set; }
        [JsonPropertyName("faturado")]
        public bool Faturado { get; set; }
    }
}
