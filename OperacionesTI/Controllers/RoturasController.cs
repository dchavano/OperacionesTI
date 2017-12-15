using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OperacionesTI.Data;
using OperacionesTI.Models;

namespace OperacionesTI.Controllers
{
    public class RoturasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoturasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Roturas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Roturas.Include(r => r.UN);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Roturas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roturas = await _context.Roturas
                .Include(r => r.UN)
                .SingleOrDefaultAsync(m => m.IdRotura == id);
            if (roturas == null)
            {
                return NotFound();
            }

            return View(roturas);
        }

        // GET: Roturas/Create
        public IActionResult Create()
        {
            ViewData["IdUn"] = new SelectList(_context.Set<Roturas_UN>(), "IdUN", "IdUN");
            return View();
        }

        // POST: Roturas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdRotura,Serial,IdUn,IdBandera,IdLocal,IdMarca,IdModelo,Identificacion,IdFalla,Ticket,FechaEnvioaCD,FechaRecibido,FechaReparado,IdEstadoReparacion,Observaciones,Fechaenviomicro,Fechaautogarencia,Presupuesto,valorMyProperty,Fecharecemicro,Capex")] Roturas roturas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roturas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdUn"] = new SelectList(_context.Set<Roturas_UN>(), "IdUN", "IdUN", roturas.IdUn);
            return View(roturas);
        }

        // GET: Roturas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roturas = await _context.Roturas.SingleOrDefaultAsync(m => m.IdRotura == id);
            if (roturas == null)
            {
                return NotFound();
            }
            ViewData["IdUn"] = new SelectList(_context.Set<Roturas_UN>(), "IdUN", "IdUN", roturas.IdUn);
            return View(roturas);
        }

        // POST: Roturas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdRotura,Serial,IdUn,IdBandera,IdLocal,IdMarca,IdModelo,Identificacion,IdFalla,Ticket,FechaEnvioaCD,FechaRecibido,FechaReparado,IdEstadoReparacion,Observaciones,Fechaenviomicro,Fechaautogarencia,Presupuesto,valorMyProperty,Fecharecemicro,Capex")] Roturas roturas)
        {
            if (id != roturas.IdRotura)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roturas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoturasExists(roturas.IdRotura))
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
            ViewData["IdUn"] = new SelectList(_context.Set<Roturas_UN>(), "IdUN", "IdUN", roturas.IdUn);
            return View(roturas);
        }

        // GET: Roturas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roturas = await _context.Roturas
                .Include(r => r.UN)
                .SingleOrDefaultAsync(m => m.IdRotura == id);
            if (roturas == null)
            {
                return NotFound();
            }

            return View(roturas);
        }

        // POST: Roturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roturas = await _context.Roturas.SingleOrDefaultAsync(m => m.IdRotura == id);
            _context.Roturas.Remove(roturas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoturasExists(int id)
        {
            return _context.Roturas.Any(e => e.IdRotura == id);
        }
    }
}
