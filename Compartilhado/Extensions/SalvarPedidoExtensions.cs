using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Compartilhado.Models;

namespace Compartilhado.Extensions
{
  public static class SalvarPedidoExtensions
  {
    public static async Task SalvarAsync(this Pedido pedido)
    {
      var client = new AmazonDynamoDBClient(RegionEndpoint.USEast1);
      var context = new DynamoDBContext(client);
      await context.SaveAsync(pedido);
    }
  }
}
