using TechTrove.DAL.Entities;

namespace TechTrove.DAL.Repositories
{
    public interface ICartItemRepository
    {
        Task<IEnumerable<TechTroveCartItem>> GetAllAsync();
        Task<TechTroveCartItem> GetByIdAsync(int id);
        Task AddAsync(TechTroveCartItem cartItem);
        Task UpdateAsync(TechTroveCartItem cartItem);
        Task DeleteAsync(int id);
    }
}
