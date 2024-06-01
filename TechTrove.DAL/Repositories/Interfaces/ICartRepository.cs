using TechTrove.DAL.Entities;

namespace TechTrove.DAL.Repositories
{
    public interface ICartRepository
    {
        Task<IEnumerable<TechTroveCart>> GetAllAsync();
        Task<TechTroveCart> GetByIdAsync(int id);
        Task AddAsync(TechTroveCart cart);
        Task UpdateAsync(TechTroveCart cart);
        Task DeleteAsync(int id);
    }
}
