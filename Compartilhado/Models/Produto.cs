using System.Text.Json.Serialization;

namespace Compartilhado.Models
{
  public class Produto
  {
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("nome")]
    public string? Nome { get; set; }
    [JsonPropertyName("valor")]
    public decimal Valor { get; set; }
    [JsonPropertyName("quantidade")]
    public int Quantidade { get; set; }
    [JsonPropertyName("reservado")]
    public bool Reservado { get; set; }
  }
}
