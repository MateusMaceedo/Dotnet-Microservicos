using Amazon.Lambda.Core;
using Amazon.Lambda.DynamoDBEvents;
using Amazon.DynamoDBv2.Model;
using Amazon;
using Amazon.DynamoDBv2;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Coletor;

public class Function
{
  public void FunctionHandler(DynamoDBEvent dynamoEvent, ILambdaContext context)
  {
    context.Logger.LogInformation($"Beginning to process {dynamoEvent.Records.Count} records...");

    foreach (var record in dynamoEvent.Records)
    {
      if (record.EventName == "INSERT")
      {
        var pedido = record.Dynamodb.ToObject<Pedido>();
      }
    }

    context.Logger.LogInformation("Stream processing complete.");
  }

  private async Task ProcessarValorDoPedido(Pedido pedido)
  {
    foreach (var produto in pedido.Produtos)
    {
      var produtoDoEstoque = await ObterProdutoDoDynamoDBAsync(produto.Id);
      if (produtoDoEstoque == null) throw new InvalidOperationException($"Produto não encontrado na tabela estoque: {produto.Id}");
      produto.Valor = produtoDoEstoque.Valor;
      produto.Nome = produtoDoEstoque.Nome;
    }

    var valorTotal = pedido.Produtos.Sum(x => x.Valor * x.Quantidade);
    if (pedido.valorTotal != 0 && pedido.valorTotal != valorTotal)
      throw new InvalidOperationException($"O valor esperado do pedido é de R$: {pedido.valorTotal} e o valor verdadeiro é R$: ");
  }

  private async Task<Produto> ObterProdutoDoDynamoDBAsync(string id)
  {
    var client = new AmazonDynamoDBClient(RegionEndpoint.SAEast1);
    var request = new QueryRequest
    {
      TableName = "estoque",
      KeyConditionExpression = "Id = :v_id",
      ExpressionAttributeValues = new Dictionary<string, AttributeValue> { { "v_id", new AttributeValue { S = id } } }
    };

    var response = await client.QueryAsync(request);
    var item = response.Items.FirstOrDefault();
    if (item == null) return null;
    return item.ToObject<Produto>();
  }
}
