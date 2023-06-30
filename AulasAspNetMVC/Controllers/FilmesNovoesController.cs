using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AulasAspNetMVC.Data;
using AulasAspNetMVC.Models;

namespace AulasAspNetMVC.Controllers
{
    public class FilmesNovoesController : Controller
    {
        private readonly AulasAspNetMVCContext _context;

        public FilmesNovoesController(AulasAspNetMVCContext context)
        {
            _context = context;
        }

        // GET: FilmesNovoes
        public async Task<IActionResult> Index()
        {
              return _context.FilmesNovo != null ? 
                          View(await _context.FilmesNovo.ToListAsync()) :
                          Problem("Entity set 'AulasAspNetMVCContext.FilmesNovo'  is null.");
        }

        // GET: FilmesNovoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FilmesNovo == null)
            {
                return NotFound();
            }

            var filmesNovo = await _context.FilmesNovo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (filmesNovo == null)
            {
                return NotFound();
            }

            return View(filmesNovo);
        }

        // GET: FilmesNovoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FilmesNovoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,DataLancamento,Genero,Valor")] FilmesNovo filmesNovo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(filmesNovo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(filmesNovo);
        }

        // GET: FilmesNovoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FilmesNovo == null)
            {
                return NotFound();
            }

            var filmesNovo = await _context.FilmesNovo.FindAsync(id);
            if (filmesNovo == null)
            {
                return NotFound();
            }
            return View(filmesNovo);
        }

        // POST: FilmesNovoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,DataLancamento,Genero,Valor")] FilmesNovo filmesNovo)
        {
            if (id != filmesNovo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(filmesNovo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmesNovoExists(filmesNovo.Id))
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
            return View(filmesNovo);
        }

        // GET: FilmesNovoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FilmesNovo == null)
            {
                return NotFound();
            }

            var filmesNovo = await _context.FilmesNovo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (filmesNovo == null)
            {
                return NotFound();
            }

            return View(filmesNovo);
        }

        // POST: FilmesNovoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FilmesNovo == null)
            {
                return Problem("Entity set 'AulasAspNetMVCContext.FilmesNovo'  is null.");
            }
            var filmesNovo = await _context.FilmesNovo.FindAsync(id);
            if (filmesNovo != null)
            {
                _context.FilmesNovo.Remove(filmesNovo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmesNovoExists(int id)
        {
          return (_context.FilmesNovo?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
