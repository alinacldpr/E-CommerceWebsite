using Microsoft.EntityFrameworkCore;
using TechTrove.DAL.Entities;

namespace TechTrove.DAL.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly TechTroveContext _context;

        public CartRepository(TechTroveContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TechTroveCart>> GetAllAsync()
        {
            return await _context.TechTroveCarts.Include(c => c.TechTroveCartItems).ToListAsync();
        }

        public async Task<TechTroveCart> GetByIdAsync(int id)
        {
            return await _context.TechTroveCarts.Include(c => c.TechTroveCartItems).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task AddAsync(TechTroveCart cart)
        {
            _context.TechTroveCarts.Add(cart);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TechTroveCart cart)
        {
            _context.Entry(cart).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var cart = await _context.TechTroveCarts.FindAsync(id);
            if (cart != null)
            {
                _context.TechTroveCarts.Remove(cart);
                await _context.SaveChangesAsync();
            }
        }
    }
}
