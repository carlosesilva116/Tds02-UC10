using ControleEstoque.API.Data;
using ControleEstoque.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleEstoque.API.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly AppDbContext _context;

        public PedidoService(AppDbContext context)
        {
            _context = context;
        }

        public Task<Pedido> CriarPedidoAsync(int clienteId, List<ItemPedido> itens)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pedido>> ListaPedidosDoClienteAsync(int clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<Pedido?> ObterPedidoComDetalhesAsync(int pedidoId)
        {
            //esta retornando apenas o pedido, sem os itens relacionados
           return _context.Pedidos.FirstOrDefaultAsync(p => p.Id == pedidoId);
        }
    }
}
