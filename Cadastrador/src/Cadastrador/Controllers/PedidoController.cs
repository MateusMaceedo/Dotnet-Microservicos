using Microsoft.AspNetCore.Mvc;

namespace Cadastrador.Controllers
{
  [Route("[controller]")]
    public class PedidoController : Controller
    {
        [HttpPost]
        public async Task PostAsync([FromBody] Pedido pedido)
        {
            pedido.Id = Guid.NewGuid().ToString();
            pedido.DataDeCriacao = DateTime.Now;

            await pedido.SalvarAsync();

            Console.WriteLine($"Pedido salvo com sucesso: id {pedido.Id}");
        }
    }
}
