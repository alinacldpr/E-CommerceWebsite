using TechTrove.DAL.Entities;

namespace TechTrove.DAL.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<TechTroveCategory>> GetAllAsync();
        Task<TechTroveCategory> GetByIdAsync(int id);
        Task AddAsync(TechTroveCategory category);
        Task UpdateAsync(TechTroveCategory category);
        Task DeleteAsync(int id);
    }
}
