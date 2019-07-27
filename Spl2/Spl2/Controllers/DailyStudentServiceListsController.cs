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
    public class DailyStudentServiceListsController : Controller
    {
        private readonly Spl2Context _context;

        public DailyStudentServiceListsController(Spl2Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Show(string id) {

            DailyStudentServiceList dailyStudentServiceList = await _context.dailyStudentServiceLists
                .FirstOrDefaultAsync(m => m.Session == id);

            var druglist = _context.drugInfoPerStudents;

            foreach (var session in druglist) {
                if (dailyStudentServiceList.Session == session.Session) {
                    dailyStudentServiceList.DrugInfoPerStudents.Add(session);
                }
            }
            List<DrugInfoPerStudent> drugInfoPerStudent = dailyStudentServiceList.DrugInfoPerStudents;

            return View(drugInfoPerStudent);
        }



        // GET: DailyStudentServiceLists
        public async Task<IActionResult> Index()
        {

            return View(await _context.dailyStudentServiceLists.ToListAsync());
        }

        // GET: DailyStudentServiceLists/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dailyStudentServiceList = await _context.dailyStudentServiceLists
                .FirstOrDefaultAsync(m => m.Session == id);
            if (dailyStudentServiceList == null)
            {
                return NotFound();
            }

            return View(dailyStudentServiceList);
        }

        // GET: DailyStudentServiceLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DailyStudentServiceLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Session,studentname,email,problemDetails,DrugList")] DailyStudentServiceList dailyStudentServiceList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dailyStudentServiceList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dailyStudentServiceList);
        }

        // GET: DailyStudentServiceLists/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dailyStudentServiceList = await _context.dailyStudentServiceLists.FindAsync(id);
            if (dailyStudentServiceList == null)
            {
                return NotFound();
            }
            return View(dailyStudentServiceList);
        }

        // POST: DailyStudentServiceLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Session,studentname,email,problemDetails,DrugList")] DailyStudentServiceList dailyStudentServiceList)
        {
            if (id != dailyStudentServiceList.Session)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dailyStudentServiceList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DailyStudentServiceListExists(dailyStudentServiceList.Session))
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
            return View(dailyStudentServiceList);
        }

        // GET: DailyStudentServiceLists/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dailyStudentServiceList = await _context.dailyStudentServiceLists
                .FirstOrDefaultAsync(m => m.Session == id);
            if (dailyStudentServiceList == null)
            {
                return NotFound();
            }

            return View(dailyStudentServiceList);
        }

        // POST: DailyStudentServiceLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var dailyStudentServiceList = await _context.dailyStudentServiceLists.FindAsync(id);
            _context.dailyStudentServiceLists.Remove(dailyStudentServiceList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DailyStudentServiceListExists(string id)
        {
            return _context.dailyStudentServiceLists.Any(e => e.Session == id);
        }
    }
}
