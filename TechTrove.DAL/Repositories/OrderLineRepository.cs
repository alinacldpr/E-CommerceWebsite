using Microsoft.EntityFrameworkCore;
using TechTrove.DAL.Entities;

namespace TechTrove.DAL.Repositories
{
    public class OrderLineRepository : IOrderLineRepository
    {
        private readonly TechTroveContext _context;

        public OrderLineRepository(TechTroveContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TechTroveOrderLine>> GetAllAsync()
        {
            return await _context.TechTroveOrderLines.ToListAsync();
        }

        public async Task<TechTroveOrderLine> GetByIdAsync(int id)
        {
            return await _context.TechTroveOrderLines.FindAsync(id);
        }

        public async Task AddAsync(TechTroveOrderLine orderLine)
        {
            _context.TechTroveOrderLines.Add(orderLine);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TechTroveOrderLine orderLine)
        {
            _context.Entry(orderLine).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var orderLine = await _context.TechTroveOrderLines.FindAsync(id);
            if (orderLine != null)
            {
                _context.TechTroveOrderLines.Remove(orderLine);
                await _context.SaveChangesAsync();
            }
        }
    }
}
