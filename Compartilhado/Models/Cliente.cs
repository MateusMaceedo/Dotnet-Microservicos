using System.Text.Json.Serialization;

namespace Compartilhado.Models
{
  public class Cliente
  {
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("cpf")]
    public string? CPF { get; set; }
    [JsonPropertyName("nome")]
    public string? Nome { get; set; }
    [JsonPropertyName("email")]
    public string? Email { get; set; }
  }
}
