using TechTrove.DAL.Entities;

namespace TechTrove.DAL.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<TechTroveProduct>> GetAllAsync();
        Task<TechTroveProduct> GetByIdAsync(int id);
        Task AddAsync(TechTroveProduct product);
        Task UpdateAsync(TechTroveProduct product);
        Task DeleteAsync(int id);
    }
}
