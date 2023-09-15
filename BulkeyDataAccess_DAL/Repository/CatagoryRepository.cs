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
    public class CatagoryRepository:ICatagoryRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CatagoryRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<Catagory> CreateAsync(Catagory catagory)
        {
            await _applicationDbContext.Catagories.AddAsync(catagory);
            await _applicationDbContext.SaveChangesAsync();
            return catagory;
        }

        public async Task<Catagory?> DeleteAsync(Guid id)
        {
            var catagory = await _applicationDbContext.Catagories.FirstOrDefaultAsync(x => x.ID == id);
            if (catagory != null)
            {
                _applicationDbContext.Catagories.Remove(catagory);
                await _applicationDbContext.SaveChangesAsync();
                return catagory;
            }
            return null;
        }

        public async Task<List<Catagory>> GetAllAsync()
        {
            return await _applicationDbContext.Catagories.ToListAsync();
        }

        public async Task<Catagory?> GetAsync(Guid id)
        {
            var existing_category = await _applicationDbContext.Catagories.FirstOrDefaultAsync(x => x.ID == id);
            if (existing_category != null)
            {
                return existing_category;
            }
            return null;
        }

        public async Task<Catagory?> UpdateAsync(Catagory catagory)
        {
            var existing_category = await _applicationDbContext.Catagories.FirstOrDefaultAsync(x => x.ID == catagory.ID);
            if (existing_category != null)
            {
                existing_category.Name = catagory.Name;
                existing_category.DisplayOrder = catagory.DisplayOrder;
                await _applicationDbContext.SaveChangesAsync();
                return existing_category;
            }
            return null;
        }
    }
}

