using TechTrove.DAL.Entities;

namespace TechTrove.DAL.Repositories
{
    public interface IOrderLineRepository
    {
        Task<IEnumerable<TechTroveOrderLine>> GetAllAsync();
        Task<TechTroveOrderLine> GetByIdAsync(int id);
        Task AddAsync(TechTroveOrderLine orderLine);
        Task UpdateAsync(TechTroveOrderLine orderLine);
        Task DeleteAsync(int id);
    }
}
