using TechTrove.DAL.Entities;

namespace TechTrove.DAL.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<TechTroveUser>> GetAllAsync();
        Task<TechTroveUser> GetByIdAsync(int id);
        Task AddAsync(TechTroveUser user);
        Task UpdateAsync(TechTroveUser user);
        Task DeleteAsync(int id);
    }
}