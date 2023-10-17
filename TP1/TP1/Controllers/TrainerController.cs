using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JuliePro_DataAccess;
using JuliePro_DataModels.Entities;

namespace TP1.Controllers
{
    public class TrainerController : Controller
    {
        private JulieProDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public TrainerController(JulieProDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            this.webHostEnvironment = webHostEnvironment;
        }

        // GET: Trainer 
        public async Task<IActionResult> Index()
        {
            var julieProDbContext = _context.Trainers.Include(t => t.Speciality);
            return View(await julieProDbContext.OrderBy(t => t.LastName).ThenBy(t => t.FirstName).ToListAsync());
        }

        // GET: Trainer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Trainers == null)
            {
                return NotFound();
            }

            var trainer = await _context.Trainers
                .Include(t => t.Speciality)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trainer == null)
            {
                return NotFound();
            }

            return View(trainer);
        }


        // GET: UPSERT
        public async Task<IActionResult> Upsert(int? id)
        {
            TrainerVM obj = new TrainerVM();
            obj.SpecialityList = _context.Specialities.Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });

            if (id == null) {
                return View(obj);            
            }
            return View(obj);

            obj.Trainer = await _context.Trainers.FirstOrDefaultAsync(x => x.Id == id);

            if (obj == null)
            {
                return NotFound(); ;
            }
            return View(obj);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(TrainerVM trainer)
        {

            if (ModelState.IsValid)
            {
                if (trainer.Trainer.Id == 0){
                    this._context.Trainers.Add(trainer.Trainer);
                }
                else {
                    this._context.Update(trainer);
                }
                await this._context.SaveChangesAsync();
                return this.RedirectToAction("Index");
            }
            return this.View(trainer);
        }




        // GET: Trainer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Trainers == null)
            {
                return NotFound();
            }

            var trainer = await _context.Trainers.FindAsync(id);
            if (trainer == null)
            {
                return NotFound();
            }
            ViewData["Speciality_Id"] = new SelectList(_context.Specialities, "Id", "Name", trainer.Speciality_Id);
            return View(trainer);
        }

        // POST: Trainer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,AuthorEmail,Photo,Speciality_Id,Active")] Trainer trainer)
        {
            if (id != trainer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trainer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrainerExists(trainer.Id))
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
            ViewData["Speciality_Id"] = new SelectList(_context.Specialities, "Id", "Name", trainer.Speciality_Id);
            return View(trainer);
        }

        // GET: Trainer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Trainers == null)
            {
                return NotFound();
            }

            var trainer = await _context.Trainers
                .Include(t => t.Speciality)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trainer == null)
            {
                return NotFound();
            }

            return View(trainer);
        }

        // POST: Trainer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Trainers == null)
            {
                return Problem("Entity set 'JulieProDbContext.Trainers'  is null.");
            }
            var trainer = await _context.Trainers.FindAsync(id);
            if (trainer != null)
            {
                _context.Trainers.Remove(trainer);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrainerExists(int id)
        {
          return _context.Trainers.Any(e => e.Id == id);
        }
    }
}
