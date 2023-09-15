using BulkeyDataAccess_DAL.Repository;
using BulkeyModels.Models.Domain;
using BulkeyModels.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BulkeyWEB.Controllers
{
    public class CatagoryController : Controller
    {
       
            private readonly ICatagoryRepository _catagoryRepository;

            public CatagoryController(ICatagoryRepository catagoryRepository)
            {
                _catagoryRepository = catagoryRepository;
            }
            [HttpGet]
            public async Task<IActionResult> Index()
            {
                var catagories = await _catagoryRepository.GetAllAsync();
                return View(catagories);
            }
            [HttpGet]
            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> Create(AddCatagoryRequest addCatagoryRequest)
            {
                if (ModelState.IsValid)
                {
                    var catagoryDomain = new Catagory
                    {
                        Name = addCatagoryRequest.Name,
                        DisplayOrder = addCatagoryRequest.DisplayOrder,
                    };
                    await _catagoryRepository.CreateAsync(catagoryDomain);
                    return RedirectToAction("Index");
                }
                return View();
            }
            [HttpGet]
            public async Task<IActionResult> Edit(Guid id)
            {
                var existing_catagoty = await _catagoryRepository.GetAsync(id);
                var editCatagory = new EditCatagoryRequest();
                if (existing_catagoty != null)
                {
                    editCatagory = new EditCatagoryRequest
                    {
                        ID = existing_catagoty.ID,
                        Name = existing_catagoty.Name,
                        DisplayOrder = existing_catagoty.DisplayOrder,
                    };
                }

                return View(editCatagory);
            }
            [HttpPost]
            public async Task<IActionResult> Edit(EditCatagoryRequest request)
            {
                var catagoryDomain = new Catagory
                {
                    ID = request.ID,
                    Name = request.Name,
                    DisplayOrder = request.DisplayOrder,
                };
                var catagory = await _catagoryRepository.UpdateAsync(catagoryDomain);
                if (catagory != null)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
            [HttpPost]
            public async Task<IActionResult> Delete(EditCatagoryRequest editCatagoryRequest)
            {
                var catagory = await _catagoryRepository.DeleteAsync(editCatagoryRequest.ID);
                if (catagory != null)
                {
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Edit", new { id = editCatagoryRequest.ID });
            }
        }
    }

