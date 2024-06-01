using TechTrove.DAL.Entities;

namespace TechTrove.BLL.Services
{
    public interface ICartItemService
    {
        Task<IEnumerable<TechTroveCartItem>> GetAllCartItemsAsync();
        Task<TechTroveCartItem> GetCartItemByIdAsync(int id);
        Task CreateCartItemAsync(TechTroveCartItem cartItem);
        Task UpdateCartItemAsync(TechTroveCartItem cartItem);
        Task DeleteCartItemAsync(int id);
    }
}
