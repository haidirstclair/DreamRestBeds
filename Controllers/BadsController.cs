using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DreamRestBeds.Data;
using DreamRestBeds.Models;

namespace DreamRestBeds.Controllers
{
    public class BadsController : Controller
    {
        private readonly DreamRestBedsContext _context;

        public BadsController(DreamRestBedsContext context)
        {
            _context = context;
        }

        // GET: Bads
        public async Task<IActionResult> Index()
        {
              return _context.Bads != null ? 
                          View(await _context.Bads.ToListAsync()) :
                          Problem("Entity set 'DreamRestBedsContext.Bads'  is null.");
        }

        // GET: Bads/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Bads == null)
            {
                return NotFound();
            }

            var bads = await _context.Bads
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bads == null)
            {
                return NotFound();
            }

            return View(bads);
        }

        // GET: Bads/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bads/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Material,Mattress,Color,Price,Warranty,CountryOfOrigin,AssemblyRequired,InstallationRequired,Durability,Design,Support,Feature,MinLength,MaxLength,Height,BedWidth,MaxLoad,MattressLength,MattressWidth,PictureUrl,SizeType,Description")] Bads bads)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bads);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bads);
        }

        // GET: Bads/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Bads == null)
            {
                return NotFound();
            }

            var bads = await _context.Bads.FindAsync(id);
            if (bads == null)
            {
                return NotFound();
            }
            return View(bads);
        }

        // POST: Bads/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Material,Mattress,Color,Price,Warranty,CountryOfOrigin,AssemblyRequired,InstallationRequired,Durability,Design,Support,Feature,MinLength,MaxLength,Height,BedWidth,MaxLoad,MattressLength,MattressWidth,PictureUrl,SizeType,Description")] Bads bads)
        {
            if (id != bads.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bads);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BadsExists(bads.Id))
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
            return View(bads);
        }

        // GET: Bads/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Bads == null)
            {
                return NotFound();
            }

            var bads = await _context.Bads
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bads == null)
            {
                return NotFound();
            }

            return View(bads);
        }

        // POST: Bads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Bads == null)
            {
                return Problem("Entity set 'DreamRestBedsContext.Bads'  is null.");
            }
            var bads = await _context.Bads.FindAsync(id);
            if (bads != null)
            {
                _context.Bads.Remove(bads);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BadsExists(int id)
        {
          return (_context.Bads?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
