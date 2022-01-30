using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
         Task<IReadOnlyList<Product>> GetProductsAsync();
         Task<Product> GetProductByIdAsync(int id);
          Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
           Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
    }
}