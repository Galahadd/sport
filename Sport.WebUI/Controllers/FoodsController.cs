﻿using Microsoft.AspNetCore.Mvc;
using Sport.Domain.Entities;
using Sport.Service.Abstract;
using System.Threading.Tasks;

namespace Sport.WebUI.Controllers
{
    public class FoodsController : Controller
    {
        private readonly IFoodService _foodService;

        public FoodsController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _foodService.GetAllFoodAsync());
        }

        public IActionResult Create()
        {
            return View(new Food());
        }
        [HttpPost]
        public async Task<IActionResult> Create(Food food)
        {
            int success = await _foodService.AddFoodAsync(food);

            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public async Task<IActionResult> Edit(Food food)
        //{
        //    int success = await _foodService.EditFoodAsync(food);

        //    return RedirectToAction("Index");
        //}

        public async Task<IActionResult> Delete(Food food)
        {
            int succes = await _foodService.DeleteFoodAsync(food);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(Food food, int Id)
        {
            food = _foodService.FoodById(Id);
            return View(food);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Food food)
        {
            int succes= await _foodService.EditFoodAsync(food);
            return RedirectToAction("Index");
        }


        public IActionResult Details(Food food, int Id)
        {
            food = _foodService.FoodById(Id);
            return View(food);
        }




        #region AllClosed
        /*
        // GET: Foods/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = await _context.Foods
                .FirstOrDefaultAsync(m => m.Id == id);
            if (food == null)
            {
                return NotFound();
            }

            return View(food);
        }

        // GET: Foods/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Foods/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ProteinValue,CarbohydrateValue,OilValue,FiberValue,FoodPhoto,EnumFoodType")] Food food)
        {
            if (ModelState.IsValid)
            {
                _context.Add(food);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(food);
        }

        // GET: Foods/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = await _context.Foods.FindAsync(id);
            if (food == null)
            {
                return NotFound();
            }
            return View(food);
        }

        // POST: Foods/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ProteinValue,CarbohydrateValue,OilValue,FiberValue,FoodPhoto,EnumFoodType")] Food food)
        {
            if (id != food.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(food);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FoodExists(food.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(food);
        }

        // GET: Foods/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = await _context.Foods
                .FirstOrDefaultAsync(m => m.Id == id);
            if (food == null)
            {
                return NotFound();
            }

            return View(food);
        }

        // POST: Foods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var food = await _context.Foods.FindAsync(id);
            _context.Foods.Remove(food);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FoodExists(int id)
        {
            return _context.Foods.Any(e => e.Id == id);
        }
        */
        #endregion
    }
}