using Microsoft.EntityFrameworkCore;
using TechTrove.DAL.Entities;

namespace TechTrove.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly TechTroveContext _context;

        public ProductRepository(TechTroveContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TechTroveProduct>> GetAllAsync()
        {
            return await _context.TechTroveProducts.ToListAsync();
        }

        public async Task<TechTroveProduct> GetByIdAsync(int id)
        {
            return await _context.TechTroveProducts.FindAsync(id);
        }

        public async Task AddAsync(TechTroveProduct product)
        {
            _context.TechTroveProducts.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TechTroveProduct product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _context.TechTroveProducts.FindAsync(id);
            if (product != null)
            {
                _context.TechTroveProducts.Remove(product);
                await _context.SaveChangesAsync();
            }
        }
    }
}
