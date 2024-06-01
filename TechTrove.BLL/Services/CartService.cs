using TechTrove.DAL.Entities;
using TechTrove.DAL.Repositories;

namespace TechTrove.BLL.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;

        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public async Task<IEnumerable<TechTroveCart>> GetAllCartsAsync()
        {
            return await _cartRepository.GetAllAsync();
        }

        public async Task<TechTroveCart> GetCartByIdAsync(int id)
        {
            return await _cartRepository.GetByIdAsync(id);
        }

        public async Task CreateCartAsync(TechTroveCart cart)
        {
            await _cartRepository.AddAsync(cart);
        }

        public async Task UpdateCartAsync(TechTroveCart cart)
        {
            await _cartRepository.UpdateAsync(cart);
        }

        public async Task DeleteCartAsync(int id)
        {
            await _cartRepository.DeleteAsync(id);
        }
    }
}
