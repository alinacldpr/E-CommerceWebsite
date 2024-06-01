using Microsoft.EntityFrameworkCore;
using TechTrove.DAL.Entities;

namespace TechTrove.DAL.Repositories
{
    public class CartItemRepository : ICartItemRepository
    {
        private readonly TechTroveContext _context;

        public CartItemRepository(TechTroveContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TechTroveCartItem>> GetAllAsync()
        {
            return await _context.TechTroveCartItems.ToListAsync();
        }

        public async Task<TechTroveCartItem> GetByIdAsync(int id)
        {
            return await _context.TechTroveCartItems.FindAsync(id);
        }

        public async Task AddAsync(TechTroveCartItem cartItem)
        {
            _context.TechTroveCartItems.Add(cartItem);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TechTroveCartItem cartItem)
        {
            _context.Entry(cartItem).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var cartItem = await _context.TechTroveCartItems.FindAsync(id);
            if (cartItem != null)
            {
                _context.TechTroveCartItems.Remove(cartItem);
                await _context.SaveChangesAsync();
            }
        }
    }
}
