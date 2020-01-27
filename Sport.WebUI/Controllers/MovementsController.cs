using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sport.Domain.Entities;
using Sport.Service.Abstract;

namespace Sport.WebUI.Controllers
{
    public class MovementsController : Controller
    {
        private readonly IMovementService _movementService;
        public MovementsController(IMovementService movementService)
        {
            _movementService = movementService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _movementService.GetAllMovementAsync());
        }

        public IActionResult Create()
        {
            return View(new Movement());
        }
        [HttpPost]
        public async Task<IActionResult> Create(Movement movement)
        {
            int success = await _movementService.AddMovementAsync(movement);

            if (success < 0)
            {
                return NotFound();
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Movement movement)
        {
            int success = await _movementService.DeleteMovementAsync(movement);
            if (success < 0)
            {
                return NotFound();
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int Id)
        {
            Movement movement = await _movementService.MovementById(Id);
            return View(movement);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Movement movement)
        {
            int success = await _movementService.EditMovementAsync(movement);
            if (success < 0)
            {
                return NotFound();
            }
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Details(int Id)
        {
            Movement movement = await _movementService.MovementById(Id);
            return View(movement);
        }
    }
}