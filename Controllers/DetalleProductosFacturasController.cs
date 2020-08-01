using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gran_Aki_Version_Final.Data;
using Gran_Aki_Version_Final.Models;

namespace Gran_Aki_Version_Final.Controllers
{
    public class DetalleProductosFacturasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DetalleProductosFacturasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DetalleProductosFacturas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DetalleProductosFactura.Include(d => d.Factura);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: DetalleProductosFacturas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleProductosFactura = await _context.DetalleProductosFactura
                .Include(d => d.Factura)
                .FirstOrDefaultAsync(m => m.DetalleId == id);
            if (detalleProductosFactura == null)
            {
                return NotFound();
            }

            return View(detalleProductosFactura);
        }

        // GET: DetalleProductosFacturas/Create
        public IActionResult Create()
        {
            ViewData["FacturaId"] = new SelectList(_context.Set<Factura>(), "FacturaId", "FacturaId");
            return View();
        }

        // POST: DetalleProductosFacturas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DetalleId,DetalleCantidad,DetalleIva,DetallePrecioUnitario,DetallePrecioTotal,DetalleSubTotal,FacturaId,ProductosId")] DetalleProductosFactura detalleProductosFactura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detalleProductosFactura);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FacturaId"] = new SelectList(_context.Set<Factura>(), "FacturaId", "FacturaId", detalleProductosFactura.FacturaId);
            return View(detalleProductosFactura);
        }

        // GET: DetalleProductosFacturas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleProductosFactura = await _context.DetalleProductosFactura.FindAsync(id);
            if (detalleProductosFactura == null)
            {
                return NotFound();
            }
            ViewData["FacturaId"] = new SelectList(_context.Set<Factura>(), "FacturaId", "FacturaId", detalleProductosFactura.FacturaId);
            return View(detalleProductosFactura);
        }

        // POST: DetalleProductosFacturas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DetalleId,DetalleCantidad,DetalleIva,DetallePrecioUnitario,DetallePrecioTotal,DetalleSubTotal,FacturaId,ProductosId")] DetalleProductosFactura detalleProductosFactura)
        {
            if (id != detalleProductosFactura.DetalleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detalleProductosFactura);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetalleProductosFacturaExists(detalleProductosFactura.DetalleId))
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
            ViewData["FacturaId"] = new SelectList(_context.Set<Factura>(), "FacturaId", "FacturaId", detalleProductosFactura.FacturaId);
            return View(detalleProductosFactura);
        }

        // GET: DetalleProductosFacturas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleProductosFactura = await _context.DetalleProductosFactura
                .Include(d => d.Factura)
                .FirstOrDefaultAsync(m => m.DetalleId == id);
            if (detalleProductosFactura == null)
            {
                return NotFound();
            }

            return View(detalleProductosFactura);
        }

        // POST: DetalleProductosFacturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detalleProductosFactura = await _context.DetalleProductosFactura.FindAsync(id);
            _context.DetalleProductosFactura.Remove(detalleProductosFactura);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetalleProductosFacturaExists(int id)
        {
            return _context.DetalleProductosFactura.Any(e => e.DetalleId == id);
        }
    }
}
