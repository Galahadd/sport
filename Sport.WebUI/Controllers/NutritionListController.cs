using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sport.Domain;
using Sport.Domain.Entities;
using Sport.Service.Abstract;
using Sport.Service.Concrete.EntityFrameworkCore;
using Sport.WebUI.Models;
using Sport.WebUI.ViewModels;

namespace Sport.WebUI.Controllers
{
    public class NutritionListController : Controller
     {
        private readonly IThatDayService _thatDayService;
        private readonly INutritionListService _nutritionListService;
        private readonly INutritionDayService _nutritionDayService;
        private readonly IFoodService _foodService;


        public NutritionListController(IThatDayService thatDayService,
            INutritionListService nutritionListService,
            INutritionDayService nutritionDayService,
            IFoodService foodService)
        {
            _nutritionListService = nutritionListService;
            _nutritionDayService = nutritionDayService;
            _thatDayService = thatDayService;
            _foodService = foodService;
        }
        public async Task<IActionResult> GetAllNutritionList()
        {
            IEnumerable<NutritionList> allNutritionList = await _nutritionListService.GetAllNutritionListAsync();
            return View(allNutritionList);
        }
        public IActionResult CreateNutritionList()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateNutritionList(NutritionList newList)
        {
            try
            {
                int success = await _nutritionListService.AddNutritionListAsync(newList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return RedirectToAction("GetAllNutritionList");
        }
        public async Task<IActionResult> EditNutritionList(int Id)
        {
            NutritionList nutritionList = await _nutritionListService.NutritionListById(Id);
            return View(nutritionList);
        }

        [HttpPost]
        public async Task<IActionResult> EditNutritionList(NutritionList nutritionList)
        {
            int success = await _nutritionListService.EditNutritionListAsync(nutritionList);
            if (success < 0)
            {
                return NotFound();
            }
            return RedirectToAction("GetAllNutritionList");
        }

        public async Task<IActionResult> DetailsNutritionList(int Id)
        {
            NutritionList newList = await _nutritionListService.NutritionListById(Id);
            return View(newList);
        }
        public async Task<IActionResult> DeleteNutritionList(NutritionList newList)
        {
            int success = await _nutritionListService.DeleteNutritionListAsync(newList);
            if (success < 0)
            {
                return NotFound();
            }
            return RedirectToAction("GetAllNutritionList");
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public async Task<IActionResult> AddFoods(int Id)
        {
            NutritionList nList = await _nutritionListService.NutritionListById(Id);
            return View(nList);
        }
        [HttpPost]
        public async Task<IActionResult> AddFoodForThat(int ogunGun, int nutritionListId)
        {
            int sayi = ogunGun;
            int hangiOgun = (ogunGun / 10);
            int hangiOgun1 = hangiOgun;
            hangiOgun--;
            sayi = sayi - (hangiOgun1 * 10);
            int hangiGun = sayi;
            hangiGun--;


            List<NutritionDay> getNDays = await _nutritionDayService.GetNutritionDaysByNutritionListId(nutritionListId);
            NutritionDay selectedDay = getNDays[hangiGun];

            List<ThatDay> getDayThats = await _thatDayService.GetThatDaysByNutritionDayId(selectedDay.Id);

            ThatDay selectedThat = getDayThats[hangiOgun];

            return RedirectToAction("Foods", "NutritionList", new { @id = selectedThat.Id });

        }

        public async Task<IActionResult> Foods(int id)
        {
            SelectFoodsAndThatViewModel vm = new SelectFoodsAndThatViewModel();
            vm.allFoods = await _foodService.GetAllFoodAsync();
            vm.thatId = id;
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Foods(SelectFoodsAndThatViewModel foodsAndThat)
        {
             await _nutritionListService.AddThatFoods(foodsAndThat.selectedFoodIdArray, foodsAndThat.thatId);
            return RedirectToAction("GetAllNutritionList", "NutritionList");
        }

    }
}