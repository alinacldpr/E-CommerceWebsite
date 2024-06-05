using TechTrove.DAL.Entities;

namespace TechTrove.BLL.Services
{
    public interface IUserService
    {
        Task<IEnumerable<TechTroveUser>> GetAllUsersAsync();
        Task<TechTroveUser> GetUserByIdAsync(int id);
        Task CreateUserAsync(TechTroveUser user);
        Task UpdateUserAsync(TechTroveUser user);
        Task DeleteUserAsync(int id);
        Task<TechTroveUser> ValidateUserAsync(string email, string password);
    }
}
