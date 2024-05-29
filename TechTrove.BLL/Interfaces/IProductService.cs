using TechTrove.DAL.Entities;

namespace TechTrove.BLL.Services
{
    public interface IProductService
    {
        Task<IEnumerable<TechTroveProduct>> GetAllProductsAsync();
        Task<TechTroveProduct> GetProductByIdAsync(int id);
        Task CreateProductAsync(TechTroveProduct product);
        Task UpdateProductAsync(TechTroveProduct product);
        Task DeleteProductAsync(int id);
    }
}
