using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sport.Domain.Entities;
using Sport.Service.Abstract;
using Sport.WebUI.ViewModels;

namespace Sport.WebUI.Controllers
{
    public class SportListController : Controller
    {
        private readonly ISportListService _sportListService;
        private readonly ISportDayService _sportDayService;
        private readonly IAreaService _areaService;
        private readonly IMovementService _movementService;



        public SportListController(ISportListService sportListService,
            ISportDayService sportDayService,
            IAreaService areaService,
            IMovementService movementService)
        {
            _sportListService = sportListService;
            _sportDayService = sportDayService;
            _areaService = areaService;
            _movementService = movementService;
        }
        public async Task<IActionResult> GetAllSportList()
        {
            IEnumerable<SportList> alLSportList = await _sportListService.GetAllSportListAsync();
            return View(alLSportList);
        }
        public IActionResult CreateSportList()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateSportList(SportList newList)
        {
            try
            {
                int success = await _sportListService.AddSportListAsync(newList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return RedirectToAction("GetAllSportList");
        }
        public async Task<IActionResult> EditSportList(int Id)
        {
            SportList sportList = await _sportListService.SportListById(Id);
            return View(sportList);
        }

        [HttpPost]
        public async Task<IActionResult> EditSportList(SportList sportList)
        {
            int success = await _sportListService.EditSportListAsync(sportList);
            if (success < 0)
            {
                return NotFound();
            }
            return RedirectToAction("GetAllSportList");
        }

        public async Task<IActionResult> DetailsSportList(int Id)
        {
            SportList sportList = await _sportListService.SportListById(Id);
            return View(sportList);
        }
        public async Task<IActionResult> DeleteSportList(SportList newList)
        {
            int success = await _sportListService.DeleteSportListAsync(newList);
            if (success < 0)
            {
                return NotFound();
            }
            return RedirectToAction("GetAllSportList");
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public async Task<IActionResult> AddMovements(int Id)
        {
            SportList nList = await _sportListService.SportListById(Id); 
            return View(nList);
        }
        [HttpPost]
        public async Task<IActionResult> AddMovementForArea(int bolgeGun, int sportListId)
        {
            int sayi = bolgeGun;
            int hangiOgun = (bolgeGun / 10);
            int hangiOgun1 = hangiOgun;
            hangiOgun--;
            sayi = sayi - (hangiOgun1 * 10);
            int hangiGun = sayi;
            hangiGun--;


            List<SportDay> getSDays = await _sportDayService.GetSportDaysBySportListId(sportListId);
            SportDay selectedDay = getSDays[hangiGun];

            List<Area> getDayAreas = await _areaService.GetAreasBySportDayId(selectedDay.Id);

            Area selectedArea = getDayAreas[hangiOgun];

            return RedirectToAction("Movements", "SportList", (new { @id = selectedArea.Id }, hangiOgun));


        }
        public async Task<IActionResult> Movements(int id,int hangiOgun)
        {

            SelectMovementAndAreaViewModel vm = new SelectMovementAndAreaViewModel();
            IEnumerable<Movement> areaForMovementList = await _movementService.GetAllMovementAsync();
            if (hangiOgun == 0)
            {
                vm.allMovements = areaForMovementList.Where(x => x.EnumMovementType == Domain.Enums.AllEnums.EnumMovementType.Breast).ToList();
            }
            else if (hangiOgun == 1)
            {
                vm.allMovements = areaForMovementList.Where(x => x.EnumMovementType == Domain.Enums.AllEnums.EnumMovementType.Back).ToList();
            }
            else if(hangiOgun == 2)
            {
                vm.allMovements = areaForMovementList.Where(x => x.EnumMovementType == Domain.Enums.AllEnums.EnumMovementType.Shoulder).ToList();
            }
            else if(hangiOgun == 3)
            {
                vm.allMovements = areaForMovementList.Where(x => x.EnumMovementType == Domain.Enums.AllEnums.EnumMovementType.Biceps).ToList();
            }
            else if(hangiOgun == 4)
            {
                vm.allMovements = areaForMovementList.Where(x => x.EnumMovementType == Domain.Enums.AllEnums.EnumMovementType.Triceps).ToList();
            }
            else if(hangiOgun == 5)
            {
                vm.allMovements = areaForMovementList.Where(x => x.EnumMovementType == Domain.Enums.AllEnums.EnumMovementType.Leg).ToList();
            }
            else if(hangiOgun == 6)
            {
                vm.allMovements = areaForMovementList.Where(x => x.EnumMovementType == Domain.Enums.AllEnums.EnumMovementType.Cardio).ToList();
            }
            else if(hangiOgun == 7)
            {
                vm.allMovements = areaForMovementList.Where(x => x.EnumMovementType == Domain.Enums.AllEnums.EnumMovementType.Abdomen).ToList();
            }
            vm.areaId = id;
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Movements(SelectMovementAndAreaViewModel foodsAndArea)
        {
            await _sportListService.AddAreaMovements(foodsAndArea.selectedMovementIdArray, foodsAndArea.areaId);
            return RedirectToAction("GetAllSportList", "SportList");
        }

    }
}










