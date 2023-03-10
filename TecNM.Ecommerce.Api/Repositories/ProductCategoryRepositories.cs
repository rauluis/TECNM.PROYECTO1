using TecNM.Ecommerce.Api.Repositories.Interfaces;
using TecNM.Ecommerce.Core.Entities;

namespace TecNM.Ecommerce.Api.Repositories;

public class ProductCategoryRepositories : IProductCategoryRepository
{
    
    public Task<ProductCategory> SaveAsync(ProductCategory category)
    {
        throw new NotImplementedException();
    }

    public Task<ProductCategory> UpdateAsync(ProductCategory category)
    {
        throw new NotImplementedException();
    }

    public Task<List<ProductCategory>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ProductCategory> GetById(int id)
    {
        throw new NotImplementedException();
    }
}