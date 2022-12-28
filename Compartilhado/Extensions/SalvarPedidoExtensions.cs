using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
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

    public static T ToObject<T>(this Dictionary<string, AttributeValue> dictionary)
    {
      var client = new AmazonDynamoDBClient(RegionEndpoint.USEast1);
      var context = new DynamoDBContext(client);
      var document = Document.FromAttributeMap(dictionary);

      return context.FromDocument<T>(document);
    }
  }
}
