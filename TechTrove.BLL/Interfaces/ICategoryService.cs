using TechTrove.DAL.Entities;

namespace TechTrove.BLL.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<TechTroveCategory>> GetAllCategoriesAsync();
        Task<TechTroveCategory> GetCategoryByIdAsync(int id);
        Task CreateCategoryAsync(TechTroveCategory category);
        Task UpdateCategoryAsync(TechTroveCategory category);
        Task DeleteCategoryAsync(int id);
    }
}
