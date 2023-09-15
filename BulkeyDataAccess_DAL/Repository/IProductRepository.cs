using BulkeyModels.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkeyDataAccess_DAL.Repository
{
    public interface IProductRepository
    {
        Task<Product> CreateAsync(Product product);
        Task<List<Product>> GetAllAsync();
        Task<Product?> GetAsync(Guid id);
        Task<Product?> UpdateAsync(Product product);
        Task<Product?> DeleteAsync(Guid id);
    }
}
