using TechTrove.BLL.Interfaces;
using TechTrove.DAL.Entities;
using TechTrove.DAL.Repositories;

namespace TechTrove.BLL.Services
{
    public class OrderLineService : IOrderLineService
    {
        private readonly IOrderLineRepository _orderLineRepository;

        public OrderLineService(IOrderLineRepository orderLineRepository)
        {
            _orderLineRepository = orderLineRepository;
        }

        public async Task<IEnumerable<TechTroveOrderLine>> GetAllOrderLinesAsync()
        {
            return await _orderLineRepository.GetAllAsync();
        }

        public async Task<TechTroveOrderLine> GetOrderLineByIdAsync(int id)
        {
            return await _orderLineRepository.GetByIdAsync(id);
        }

        public async Task CreateOrderLineAsync(TechTroveOrderLine orderLine)
        {
            await _orderLineRepository.AddAsync(orderLine);
        }

        public async Task UpdateOrderLineAsync(TechTroveOrderLine orderLine)
        {
            await _orderLineRepository.UpdateAsync(orderLine);
        }

        public async Task DeleteOrderLineAsync(int id)
        {
            await _orderLineRepository.DeleteAsync(id);
        }
    }
}
