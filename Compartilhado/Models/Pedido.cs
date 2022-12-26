using Amazon.DynamoDBv2.DataModel;

namespace Compartilhado.Models
{
    [DynamoDBTable("pedidos")]
    public class Pedido
    {
        [DynamoDBHashKey("id")]
        public string? Id { get; set; }
        [DynamoDBProperty("valor_total")]
        public decimal ValorTotal { get; set; }
        [DynamoDBProperty("data_de_criacao")]
        public DateTime DataDeCriacao { get; set; }
        [DynamoDBProperty("produtos")]
        public List<Produto>? Produtos { get; set; }
        [DynamoDBProperty("cliente")]
        public Cliente? Cliente { get; set; }
        [DynamoDBProperty("pagamento")]
        public Pagamento? Pagamento { get; set; }
        [DynamoDBProperty("justificativa")]
        public string? Justificativa { get; set; }
        [DynamoDBProperty("status")]
        public string? Status { get; set; }
        [DynamoDBProperty("pago")]
        public bool Pago { get; set; }
        [DynamoDBProperty("faturado")]
        public bool Faturado { get; set; }
    }
}
