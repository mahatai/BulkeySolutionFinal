using CloudinaryDotNet;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkeyDataAccess_DAL.Repository
{
    public class ImageRepository : IImageRepository
    {
        private readonly IConfiguration _configuration;
        private readonly Account account;
        public ImageRepository(IConfiguration configuration)
        { 
            _configuration = configuration;
            account = new Account();
        }
        public async Task<string> UploadAsync(IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}
