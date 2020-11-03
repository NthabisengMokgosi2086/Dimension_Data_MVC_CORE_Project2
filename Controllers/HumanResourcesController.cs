using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dimension_Data_MVC_CORE_Project2.Data;
using Dimension_Data_MVC_CORE_Project2.Models;

namespace Dimension_Data_MVC_CORE_Project2.Controllers
{
    public class HumanResourcesController : Controller
    {
        private readonly HumanResourceContext _context;

        public HumanResourcesController(HumanResourceContext context)
        {
            _context = context;
        }

        // GET: HumanResources
        public async Task<IActionResult> Index()
        {
            return View(await _context.HumanResources.ToListAsync());
        }

        // GET: HumanResources/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var humanResource = await _context.HumanResources
                .FirstOrDefaultAsync(m => m.id == id);
            if (humanResource == null)
            {
                return NotFound();
            }

            return View(humanResource);
        }

        // GET: HumanResources/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HumanResources/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Age,BusinessTravel,Department,DistanceFromHome,EducationField,EmployeeNumber,Gender,JobRole,MaritalStatus,NumCompaniesWorked,OverTime,TotalWorkingYears,TrainingTimesLastYear,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] HumanResource humanResource)
        {
            if (ModelState.IsValid)
            {
                _context.Add(humanResource);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(humanResource);
        }

        // GET: HumanResources/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var humanResource = await _context.HumanResources.FindAsync(id);
            if (humanResource == null)
            {
                return NotFound();
            }
            return View(humanResource);
        }

        // POST: HumanResources/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Age,BusinessTravel,Department,DistanceFromHome,EducationField,EmployeeNumber,Gender,JobRole,MaritalStatus,NumCompaniesWorked,OverTime,TotalWorkingYears,TrainingTimesLastYear,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] HumanResource humanResource)
        {
            if (id != humanResource.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(humanResource);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HumanResourceExists(humanResource.id))
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
            return View(humanResource);
        }

        // GET: HumanResources/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var humanResource = await _context.HumanResources
                .FirstOrDefaultAsync(m => m.id == id);
            if (humanResource == null)
            {
                return NotFound();
            }

            return View(humanResource);
        }

        // POST: HumanResources/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var humanResource = await _context.HumanResources.FindAsync(id);
            _context.HumanResources.Remove(humanResource);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HumanResourceExists(int id)
        {
            return _context.HumanResources.Any(e => e.id == id);
        }
    }
}
