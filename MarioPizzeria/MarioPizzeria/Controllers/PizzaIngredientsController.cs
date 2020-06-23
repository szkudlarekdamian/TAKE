using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MarioPizzeria.Data;
using MarioPizzeria.Models;

namespace MarioPizzeria.Controllers
{
    public class PizzaIngredientsController : Controller
    {
        private readonly PizzaDbContext _context;

        public PizzaIngredientsController(PizzaDbContext context)
        {
            _context = context;
        }

        // GET: PizzaIngredients
        public async Task<IActionResult> Index()
        {
            var pizzaDbContext = _context.PizzaIngredients.Include(p => p.Ingredient).Include(p => p.Pizza);
            return View(await pizzaDbContext.ToListAsync());
        }

        // GET: PizzaIngredients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizzaIngredient = await _context.PizzaIngredients
                .Include(p => p.Ingredient)
                .Include(p => p.Pizza)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pizzaIngredient == null)
            {
                return NotFound();
            }

            return View(pizzaIngredient);
        }

        // GET: PizzaIngredients/Create


        public IActionResult Create(int id)
        {
            ViewData["IngredientId"] = new SelectList(_context.Ingredients, "Id", "Name");
            var ingredients = _context.Ingredients.OrderBy(i=>i.Name).ToList();
            var selects = new List<IngredientCheckbox>();
            foreach (Ingredient ingredient in ingredients){
                bool isOnPizza = _context.PizzaIngredients.Where(pi => pi.PizzaId == id && pi.IngredientId == ingredient.Id).Any();
                selects.Add(new IngredientCheckbox(ingredient.Id, ingredient.Name, isOnPizza));
            }
           
            ViewData["PizzaId"] = new SelectList(_context.Pizzas.Where(x=> x.Id==id), "Id", "Name");
            foreach (var s in selects)
                Console.WriteLine(ViewData["PizzaId"] + " has " + s.Name + " ? " + s.IsChecked);
            ViewData["Ingredients"] = selects;
            return View();
        }

        // POST: PizzaIngredients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int PizzaId, List<int> NewIngredients)
        {
            if(ModelState.IsValid)
            {
                var oldIngredients = _context.PizzaIngredients.Where(m => m.PizzaId == PizzaId).Select(m => m.IngredientId).ToList();
                List<int> deleteIngredientsIds = oldIngredients.Except(NewIngredients).ToList();
                List<PizzaIngredient> toDelete = _context.PizzaIngredients.Where(m => m.PizzaId == PizzaId && deleteIngredientsIds.Contains(m.IngredientId)).ToList();
                List<int> addIngredientsIds = NewIngredients.Except(oldIngredients).ToList();
                List<PizzaIngredient> toAdd = new List<PizzaIngredient>();
                foreach (int i in addIngredientsIds)
                    toAdd.Add(new PizzaIngredient { PizzaId = PizzaId, IngredientId = i });

                _context.RemoveRange(toDelete);
                _context.AddRange(toAdd);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index","Pizzas");
            }
            ViewData["PizzaId"] = new SelectList(_context.Pizzas.Where(x => x.Id == PizzaId), "Id", "Name");
            return View();
        }

        // GET: PizzaIngredients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizzaIngredient = await _context.PizzaIngredients.FindAsync(id);
            if (pizzaIngredient == null)
            {
                return NotFound();
            }
            ViewData["IngredientId"] = new SelectList(_context.Ingredients, "Id", "Name", pizzaIngredient.IngredientId);
            ViewData["PizzaId"] = new SelectList(_context.Pizzas, "Id", "Name", pizzaIngredient.PizzaId);
            return View(pizzaIngredient);
        }

        // POST: PizzaIngredients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PizzaId,IngredientId")] PizzaIngredient pizzaIngredient)
        {
            if (id != pizzaIngredient.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pizzaIngredient);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PizzaIngredientExists(pizzaIngredient.Id))
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
            ViewData["IngredientId"] = new SelectList(_context.Ingredients, "Id", "Name", pizzaIngredient.IngredientId);
            ViewData["PizzaId"] = new SelectList(_context.Pizzas, "Id", "Crust", pizzaIngredient.PizzaId);
            return View(pizzaIngredient);
        }

        // GET: PizzaIngredients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizzaIngredient = await _context.PizzaIngredients
                .Include(p => p.Ingredient)
                .Include(p => p.Pizza)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pizzaIngredient == null)
            {
                return NotFound();
            }

            return View(pizzaIngredient);
        }

        // POST: PizzaIngredients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pizzaIngredient = await _context.PizzaIngredients.FindAsync(id);
            _context.PizzaIngredients.Remove(pizzaIngredient);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PizzaIngredientExists(int id)
        {
            return _context.PizzaIngredients.Any(e => e.Id == id);
        }
    }
}
