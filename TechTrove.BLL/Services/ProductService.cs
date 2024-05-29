using TechTrove.DAL.Entities;
using TechTrove.DAL.Repositories;

namespace TechTrove.BLL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<TechTroveProduct>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<TechTroveProduct> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task CreateProductAsync(TechTroveProduct product)
        {
            await _productRepository.AddAsync(product);
        }

        public async Task UpdateProductAsync(TechTroveProduct product)
        {
            await _productRepository.UpdateAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
        }
    }
}
