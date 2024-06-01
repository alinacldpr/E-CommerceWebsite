using Microsoft.EntityFrameworkCore;
using TechTrove.DAL.Entities;

namespace TechTrove.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TechTroveContext _context;

        public UserRepository(TechTroveContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TechTroveUser>> GetAllAsync()
        {
            return await _context.TechTroveUsers.ToListAsync();
        }

        public async Task<TechTroveUser> GetByIdAsync(int id)
        {
            return await _context.TechTroveUsers.FindAsync(id);
        }

        public async Task AddAsync(TechTroveUser user)
        {
            _context.TechTroveUsers.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TechTroveUser user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var user = await _context.TechTroveUsers.FindAsync(id);
            if (user != null)
            {
                _context.TechTroveUsers.Remove(user);
                await _context.SaveChangesAsync();
            }
        }
    }
}
