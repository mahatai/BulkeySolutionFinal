using BulkeyDataAccess_DAL.Data;
using BulkeyModels.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkeyDataAccess_DAL.Repository
{
    public class ProductRepository:IProductRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProductRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


        public async Task<Product> CreateAsync(Product product)
        {
            await _applicationDbContext.Products.AddAsync(product);
            await _applicationDbContext.SaveChangesAsync();
            return product;
        }

        public async Task<Product?> DeleteAsync(Guid id)
        {
            var product = await _applicationDbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product != null)
            {
                _applicationDbContext.Products.Remove(product);
                await _applicationDbContext.SaveChangesAsync();
                return product;
            }
            return null;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _applicationDbContext.Products.Include(x=>x.Catagory).
                ToListAsync();
        }

        public async Task<Product?> GetAsync(Guid id)
        {
            return await _applicationDbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Product?> UpdateAsync(Product product)
        {
            var existing_product = await _applicationDbContext.Products.FirstOrDefaultAsync(x => x.Id == product.Id);
            if (existing_product != null)
            {
                existing_product.Title = product.Title;
                existing_product.Description = product.Description;
                existing_product.ISBN = product.ISBN;
                existing_product.Author = product.Author;
                existing_product.ListPrice = product.ListPrice;
                existing_product.Price = product.Price;
                existing_product.Price50 = product.Price50;
                existing_product.Price100 = product.Price100;
                await _applicationDbContext.SaveChangesAsync();
                return existing_product;
            }
            return null;

        }
    }
}
