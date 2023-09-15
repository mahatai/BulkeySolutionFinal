using BulkeyModels.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkeyDataAccess_DAL.Repository
{
    public interface ICatagoryRepository
    {

        Task<Catagory> CreateAsync(Catagory catagory);
        Task<List<Catagory>> GetAllAsync();
        Task<Catagory?> GetAsync(Guid id);
        Task<Catagory?> UpdateAsync(Catagory catagory);
        Task<Catagory?> DeleteAsync(Guid id);
    }
}
