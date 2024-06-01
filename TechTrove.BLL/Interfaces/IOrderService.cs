using TechTrove.DAL.Entities;

namespace TechTrove.BLL.Interfaces
{
    public interface IOrderService
    {
        Task<IEnumerable<TechTroveOrder>> GetAllOrdersAsync();
        Task<TechTroveOrder> GetOrderByIdAsync(int id);
        Task CreateOrderAsync(TechTroveOrder order);
        Task UpdateOrderAsync(TechTroveOrder order);
        Task DeleteOrderAsync(int id);

    }
}
