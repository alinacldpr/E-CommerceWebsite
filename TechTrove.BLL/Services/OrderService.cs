using TechTrove.BLL.Interfaces;
using TechTrove.DAL.Entities;
using TechTrove.DAL.Repositories;

namespace TechTrove.BLL.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<IEnumerable<TechTroveOrder>> GetAllOrdersAsync()
        {
            return await _orderRepository.GetAllAsync();
        }

        public async Task<TechTroveOrder> GetOrderByIdAsync(int id)
        {
            return await _orderRepository.GetByIdAsync(id);
        }

        public async Task CreateOrderAsync(TechTroveOrder order)
        {
            await _orderRepository.AddAsync(order);
        }

        public async Task UpdateOrderAsync(TechTroveOrder order)
        {
            await _orderRepository.UpdateAsync(order);
        }

        public async Task DeleteOrderAsync(int id)
        {
            await _orderRepository.DeleteAsync(id);
        }
    }
}
