using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FurnitureFactoryWeb;

namespace FurnitureFactoryWeb.Controllers
{
    public class OrderRecordsController : Controller
    {
        private readonly FurnitureFactoryContext _context;

        public OrderRecordsController(FurnitureFactoryContext context)
        {
            _context = context;
        }

        // GET: OrderRecords
        public async Task<IActionResult> Index()
        {
            var furnitureFactoryContext = _context.OrderRecords.Include(o => o.Furniture).Include(o => o.Order);
            return View(await furnitureFactoryContext.ToListAsync());
        }

        // GET: OrderRecords/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderRecord = await _context.OrderRecords
                .Include(o => o.Furniture)
                .Include(o => o.Order)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderRecord == null)
            {
                return NotFound();
            }

            return View(orderRecord);
        }

        // GET: OrderRecords/Create
        public IActionResult Create()
        {
            ViewData["FurnitureId"] = new SelectList(_context.Furnitures, "Id", "Id");
            ViewData["OrderId"] = new SelectList(_context.Orders, "Id", "Id");
            return View();
        }

        // POST: OrderRecords/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OrderId,FurnitureId,TotalOrderPrice,NumberOrderByDate")] OrderRecord orderRecord)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderRecord);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FurnitureId"] = new SelectList(_context.Furnitures, "Id", "Id", orderRecord.FurnitureId);
            ViewData["OrderId"] = new SelectList(_context.Orders, "Id", "Id", orderRecord.OrderId);
            return View(orderRecord);
        }

        // GET: OrderRecords/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderRecord = await _context.OrderRecords.FindAsync(id);
            if (orderRecord == null)
            {
                return NotFound();
            }
            ViewData["FurnitureId"] = new SelectList(_context.Furnitures, "Id", "Id", orderRecord.FurnitureId);
            ViewData["OrderId"] = new SelectList(_context.Orders, "Id", "Id", orderRecord.OrderId);
            return View(orderRecord);
        }

        // POST: OrderRecords/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OrderId,FurnitureId,TotalOrderPrice,NumberOrderByDate")] OrderRecord orderRecord)
        {
            if (id != orderRecord.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderRecord);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderRecordExists(orderRecord.Id))
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
            ViewData["FurnitureId"] = new SelectList(_context.Furnitures, "Id", "Id", orderRecord.FurnitureId);
            ViewData["OrderId"] = new SelectList(_context.Orders, "Id", "Id", orderRecord.OrderId);
            return View(orderRecord);
        }

        // GET: OrderRecords/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderRecord = await _context.OrderRecords
                .Include(o => o.Furniture)
                .Include(o => o.Order)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderRecord == null)
            {
                return NotFound();
            }

            return View(orderRecord);
        }

        // POST: OrderRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderRecord = await _context.OrderRecords.FindAsync(id);
            _context.OrderRecords.Remove(orderRecord);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderRecordExists(int id)
        {
            return _context.OrderRecords.Any(e => e.Id == id);
        }
    }
}
