using TechTrove.DAL.Entities;

namespace TechTrove.DAL.Repositories
{
    public interface IOrderRepository
    {
        Task<IEnumerable<TechTroveOrder>> GetAllAsync();
        Task<TechTroveOrder> GetByIdAsync(int id);
        Task AddAsync(TechTroveOrder order);
        Task UpdateAsync(TechTroveOrder order);
        Task DeleteAsync(int id);
    }
}
