using ControleEstoque.API.Models;

namespace ControleEstoque.API.Services
{
    public interface IPedidoService
    {
        Task<Pedido?> ObterPedidoComDetalhesAsync(int pedidoId);
        Task<IEnumerable<Pedido>> ListaPedidosDoClienteAsync(int clienteId);
        Task<Pedido> CriarPedidoAsync(int clienteId, List<ItemPedido>itens );

    }
}
