using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using A1_200412952.Data;
using A1_200412952.Models;

namespace A1_200412952.Controllers
{
    public class PetFoodsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PetFoodsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PetFoods
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PetFood.Include(p => p.TypeOfAnimal);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PetFoods/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var petFood = await _context.PetFood
                .Include(p => p.TypeOfAnimal)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (petFood == null)
            {
                return NotFound();
            }

            return View(petFood);
        }

        // GET: PetFoods/Create
        public IActionResult Create()
        {
            ViewData["AnimalId"] = new SelectList(_context.Set<Animal>(), "AnimalId", "Name");
            return View();
        }

        // POST: PetFoods/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Price,Name,Description,NutritionalInformation,Weight,Brand,ImageUrl,AnimalId")] PetFood petFood)
        {
            if (ModelState.IsValid)
            {
                _context.Add(petFood);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AnimalId"] = new SelectList(_context.Set<Animal>(), "AnimalId", "Name", petFood.AnimalId);
            return View(petFood);
        }

        // GET: PetFoods/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var petFood = await _context.PetFood.FindAsync(id);
            if (petFood == null)
            {
                return NotFound();
            }
            ViewData["AnimalId"] = new SelectList(_context.Set<Animal>(), "AnimalId", "Name", petFood.AnimalId);
            return View(petFood);
        }

        // POST: PetFoods/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Price,Name,Description,NutritionalInformation,Weight,Brand,ImageUrl, AnimalId")] PetFood petFood)
        {
            if (id != petFood.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(petFood);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PetFoodExists(petFood.Id))
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
            ViewData["AnimalId"] = new SelectList(_context.Set<Animal>(), "AnimalId", "Name", petFood.AnimalId);
            return View(petFood);
        }

        // GET: PetFoods/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var petFood = await _context.PetFood
                .Include(p => p.TypeOfAnimal)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (petFood == null)
            {
                return NotFound();
            }

            return View(petFood);
        }

        // POST: PetFoods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var petFood = await _context.PetFood.FindAsync(id);
            _context.PetFood.Remove(petFood);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PetFoodExists(int id)
        {
            return _context.PetFood.Any(e => e.Id == id);
        }
    }
}
