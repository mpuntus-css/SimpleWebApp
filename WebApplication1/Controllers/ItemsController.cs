using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class ItemsController : Controller
    {


        private readonly IDataService _dataService;


        public ItemsController(IDataService dataService)
        {
            _dataService = dataService;
        }


        public async Task<IActionResult> Index()
        {
            var data = await _dataService.GetDataAsync();
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Add(string itemName)
        {
            var data = await _dataService.GetDataAsync();
            data.Add(itemName);
            await _dataService.SaveDataAsync(data);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string itemName)
        {
            var data = await _dataService.GetDataAsync();
            data.Remove(itemName); 
            await _dataService.SaveDataAsync(data);

            return RedirectToAction("Index");
        }

    }
}
