using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sport.Domain.Entities;
using Sport.Service.Abstract;
using Sport.Service.Concrete.EntityFrameworkCore;

namespace Sport.WebUI.Controllers
{
    public class NutritionListController : Controller
    {
        private readonly IThatDayService _thatDayService;

        public NutritionListController(IThatDayService thatDayService)
        {
            _thatDayService = thatDayService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateNutritionList()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateNutritionList(NutritionList newList)
        {
            return View();
        }
        public IActionResult GetNutritionLists()
        {
            return View();
        }
        public IActionResult AddFoods()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddFoods(List<Food> thatFoods,int thatId)
        {

            return View();
        }
    }
}