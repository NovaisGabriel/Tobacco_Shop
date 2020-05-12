using Tobacco_Shop.Context;
using Tobacco_Shop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Tobacco_Shop.Areas.Admin.Controllers
{
    [Area("Admin")]
    // [Authorize(Roles = "Admin")]
    public class AdminTobaccosController : Controller
    {
        private readonly AppDbContext _context;

        public AdminTobaccosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Tobaccos.Include(l => l.Category);
            return View(await appDbContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tobacco = await _context.Tobaccos
                .Include(l => l.Category)
                .FirstOrDefaultAsync(m => m.TobaccoId == id);
            if (tobacco == null)
            {
                return NotFound();
            }

            return View(tobacco);
        }

        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryName");
            return View();
        }

        [HttpPost]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TobaccoId,Name,ShortDescription,LongDescription,Price,ImageURL,ImageThumbnailUrl,IsTobaccoBest,Available,CategoryyId")] Tobacco tobacco)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tobacco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryName", tobacco.CategoryId);
            return View(tobacco);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tobacco = await _context.Tobaccos.FindAsync(id);
            if (tobacco == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryName", tobacco.CategoryId);
            return View(tobacco);
        }

        [HttpPost]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TobaccoId,Name,ShortDescription,LongDescription,Price,ImageURL,ImageThumbnailUrl,IsTobaccoBest,Available,CategoryyId")] Tobacco tobacco)
        {
            if (id != tobacco.TobaccoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tobacco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TobaccoExists(tobacco.TobaccoId))
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
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryName", tobacco.CategoryId);
            return View(tobacco);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tobacco = await _context.Tobaccos
                .Include(l => l.Category)
                .FirstOrDefaultAsync(m => m.TobaccoId == id);
            if (tobacco == null)
            {
                return NotFound();
            }

            return View(tobacco);
        }

        [HttpPost, ActionName("Delete")]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tobacco = await _context.Tobaccos.FindAsync(id);
            _context.Tobaccos.Remove(tobacco);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TobaccoExists(int id)
        {
            return _context.Tobaccos.Any(e => e.TobaccoId == id);
        }
    }
}
