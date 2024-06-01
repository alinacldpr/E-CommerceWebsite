using TechTrove.DAL.Entities;

namespace TechTrove.BLL.Services
{
    public interface ICartService
    {
        Task<IEnumerable<TechTroveCart>> GetAllCartsAsync();
        Task<TechTroveCart> GetCartByIdAsync(int id);
        Task CreateCartAsync(TechTroveCart cart);
        Task UpdateCartAsync(TechTroveCart cart);
        Task DeleteCartAsync(int id);
    }
}
