using TechTrove.BLL.Services;
using TechTrove.DAL.Entities;
using TechTrove.DAL.Repositories;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<IEnumerable<TechTroveUser>> GetAllUsersAsync()
    {
        return await _userRepository.GetAllAsync();
    }

    public async Task<TechTroveUser> GetUserByIdAsync(int id)
    {
        return await _userRepository.GetByIdAsync(id);
    }

    public async Task<TechTroveUser> ValidateUserAsync(string email, string password)
    {
        var users = await _userRepository.GetAllAsync();
        return users.FirstOrDefault(u => u.Email == email && u.Password == password);
    }

    public async Task CreateUserAsync(TechTroveUser user)
    {
        await _userRepository.AddAsync(user);
    }

    public async Task UpdateUserAsync(TechTroveUser user)
    {
        await _userRepository.UpdateAsync(user);
    }

    public async Task DeleteUserAsync(int id)
    {
        await _userRepository.DeleteAsync(id);
    }
}
