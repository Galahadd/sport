using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sport.Domain.Entities;
using Sport.Repository.Abstract;
using Sport.Service.Abstract;
using Sport.WebUI.Models;

namespace Sport.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFoodRepository _foodService;

        public HomeController(ILogger<HomeController> logger, IFoodRepository foodService)
        {
            _logger = logger;
            _foodService = foodService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        /*public IActionResult AddFood()
        {
            return View(new Food());
        }
        [HttpPost]
        public async Task<IActionResult> AddFood(Food entity)
        {
            //await _dataContext.Foods.AddAsync(entity);
            await _foodService.Add(entity);
            int success = await _foodService.SaveChangesAsync();

            return View(new Food());
        }*/
    }
}
