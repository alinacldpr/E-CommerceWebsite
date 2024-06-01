using TechTrove.DAL.Entities;
using TechTrove.DAL.Repositories;

namespace TechTrove.BLL.Services
{
    public class CartItemService : ICartItemService
    {
        private readonly ICartItemRepository _cartItemRepository;

        public CartItemService(ICartItemRepository cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }

        public async Task<IEnumerable<TechTroveCartItem>> GetAllCartItemsAsync()
        {
            return await _cartItemRepository.GetAllAsync();
        }

        public async Task<TechTroveCartItem> GetCartItemByIdAsync(int id)
        {
            return await _cartItemRepository.GetByIdAsync(id);
        }

        public async Task CreateCartItemAsync(TechTroveCartItem cartItem)
        {
            await _cartItemRepository.AddAsync(cartItem);
        }

        public async Task UpdateCartItemAsync(TechTroveCartItem cartItem)
        {
            await _cartItemRepository.UpdateAsync(cartItem);
        }

        public async Task DeleteCartItemAsync(int id)
        {
            await _cartItemRepository.DeleteAsync(id);
        }
    }
}
