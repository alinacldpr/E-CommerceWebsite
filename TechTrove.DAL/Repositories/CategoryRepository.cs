using Microsoft.EntityFrameworkCore;
using TechTrove.DAL.Entities;
using TechTrove.DAL.Repositories.Interfaces;

namespace TechTrove.DAL.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly TechTroveContext _context;

        public CategoryRepository(TechTroveContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TechTroveCategory>> GetAllAsync()
        {
            return await _context.TechTroveCategories.ToListAsync();
        }

        public async Task<TechTroveCategory> GetByIdAsync(int id)
        {
            return await _context.TechTroveCategories.FindAsync(id);
        }

        public async Task AddAsync(TechTroveCategory category)
        {
            _context.TechTroveCategories.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TechTroveCategory category)
        {
            _context.Entry(category).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var category = await _context.TechTroveCategories.FindAsync(id);
            if (category != null)
            {
                _context.TechTroveCategories.Remove(category);
                await _context.SaveChangesAsync();
            }
        }
    }
}
