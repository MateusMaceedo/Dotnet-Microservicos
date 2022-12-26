using System.Text.Json.Serialization;

namespace Compartilhado.Models
{
  public class Pagamento
    {
      [JsonPropertyName("numero_do_contrato")]
      public string?  NumeroDoCartao { get; set; }
      [JsonPropertyName("validade")]
      public string? Validade { get; set; }
      [JsonPropertyName("cvv")]
      public string? CVV { get; set; }
    }
}
