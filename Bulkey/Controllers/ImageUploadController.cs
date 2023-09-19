using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BulkeyWEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageUploadController : ControllerBase
    {
        public async Task<IActionResult> UploadAsync(IFormFile file)
        {

        }
    }
}
