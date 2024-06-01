using Microsoft.EntityFrameworkCore;
using TechTrove.DAL.Entities;

namespace TechTrove.DAL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly TechTroveContext _context;

        public OrderRepository(TechTroveContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TechTroveOrder>> GetAllAsync()
        {
            return await _context.TechTroveOrders.Include(o => o.TechTroveOrderLines).ToListAsync();
        }

        public async Task<TechTroveOrder> GetByIdAsync(int id)
        {
            return await _context.TechTroveOrders.Include(o => o.TechTroveOrderLines).FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task AddAsync(TechTroveOrder order)
        {
            _context.TechTroveOrders.Add(order);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TechTroveOrder order)
        {
            _context.Entry(order).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var order = await _context.TechTroveOrders.FindAsync(id);
            if (order != null)
            {
                _context.TechTroveOrders.Remove(order);
                await _context.SaveChangesAsync();
            }
        }
    }
}
