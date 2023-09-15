using BulkeyDataAccess_DAL.Repository;
using BulkeyModels.Models.Domain;
using BulkeyModels.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BulkeyWEB.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var products = await _productRepository.GetAllAsync();
            return View(products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(AddProductRequest request)
        {

            var productDomain = new Product
            {
                Title = request.Title,
                Description = request.Description,
                ISBN = request.ISBN,
                Author = request.Author,
                ListPrice = request.ListPrice,
                Price = request.Price,
                Price50 = request.Price50,
                Price100 = request.Price100,
            };
            var product = await _productRepository.CreateAsync(productDomain);
            if (product != null)
            {

                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var product = await _productRepository.GetAsync(id);
            var editProduct = new EditProductRequest();
            if (product != null)
            {
                editProduct = new EditProductRequest()
                {
                    Id = product.Id,
                    Title = product.Title,
                    Description = product.Description,
                    ISBN = product.ISBN,
                    Author = product.Author,
                    Price = product.Price,
                    ListPrice = product.ListPrice,
                    Price50 = product.Price50,
                    Price100 = product.Price100,
                };
                return View(editProduct);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditProductRequest request)
        {
            var productDomain = new Product
            {
                Id = request.Id,
                Title = request.Title,
                Description = request.Description,
                ISBN = request.ISBN,
                Author = request.Author,
                Price = request.Price,
                ListPrice = request.ListPrice,
                Price50 = request.Price50,
                Price100 = request.Price100,
            };
            var product = await _productRepository.UpdateAsync(productDomain);
            if (product != null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(EditProductRequest request)
        {
            var product = await _productRepository.DeleteAsync(request.Id);
            if (product != null)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Edit", new { id = request.Id });
        }
    }
}

