using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Spl2.Models;

namespace Spl2.Controllers
{
    public class DrugInfoPerStudentsController : Controller
    {
        private readonly Spl2Context _context;

        public DrugInfoPerStudentsController(Spl2Context context)
        {
            _context = context;
        }

        // GET: DrugInfoPerStudents
        public async Task<IActionResult> Index()
        {
            return View(await _context.drugInfoPerStudents.ToListAsync());
        }

        // GET: DrugInfoPerStudents/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drugInfoPerStudent = await _context.drugInfoPerStudents
                .FirstOrDefaultAsync(m => m.name == id);
            if (drugInfoPerStudent == null)
            {
                return NotFound();
            }

            return View(drugInfoPerStudent);
        }

        // GET: DrugInfoPerStudents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DrugInfoPerStudents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("name,amount,Session")] DrugInfoPerStudent drugInfoPerStudent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(drugInfoPerStudent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(drugInfoPerStudent);
        }

        // GET: DrugInfoPerStudents/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drugInfoPerStudent = await _context.drugInfoPerStudents.FindAsync(id);
            if (drugInfoPerStudent == null)
            {
                return NotFound();
            }
            return View(drugInfoPerStudent);
        }

        // POST: DrugInfoPerStudents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("name,amount,Session")] DrugInfoPerStudent drugInfoPerStudent)
        {
            if (id != drugInfoPerStudent.name)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(drugInfoPerStudent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DrugInfoPerStudentExists(drugInfoPerStudent.name))
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
            return View(drugInfoPerStudent);
        }

        // GET: DrugInfoPerStudents/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drugInfoPerStudent = await _context.drugInfoPerStudents
                .FirstOrDefaultAsync(m => m.name == id);
            if (drugInfoPerStudent == null)
            {
                return NotFound();
            }

            return View(drugInfoPerStudent);
        }

        // POST: DrugInfoPerStudents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var drugInfoPerStudent = await _context.drugInfoPerStudents.FindAsync(id);
            _context.drugInfoPerStudents.Remove(drugInfoPerStudent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DrugInfoPerStudentExists(string id)
        {
            return _context.drugInfoPerStudents.Any(e => e.name == id);
        }
    }
}
