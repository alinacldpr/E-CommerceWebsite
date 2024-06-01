using TechTrove.DAL.Entities;

namespace TechTrove.BLL.Interfaces
{
    public interface IOrderLineService
    {
        Task<IEnumerable<TechTroveOrderLine>> GetAllOrderLinesAsync();
        Task<TechTroveOrderLine> GetOrderLineByIdAsync(int id);
        Task CreateOrderLineAsync(TechTroveOrderLine orderLine);
        Task UpdateOrderLineAsync(TechTroveOrderLine orderLine);
        Task DeleteOrderLineAsync(int id);
    }
}
