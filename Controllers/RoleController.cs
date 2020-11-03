using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Dimension_Data_MVC_CORE_Project2.Controllers
{
    public class RoleController : Controller
    {
        RoleManager<IdentityRole> _roleManger;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            _roleManger = roleManager;
        }
        public IActionResult Index()
        {
            var roles = _roleManger.Roles.ToList();
            return View(roles);
        }

        public IActionResult Create()
        {
            return View(new IdentityRole());
        }
        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            await _roleManger.CreateAsync(role);
            return RedirectToAction("Index");
        }
        public IActionResult Delete()
        {
            return View(new IdentityRole());
        }
        [HttpPost]
        public async Task<IActionResult> Delete(IdentityRole role)
        {
            await _roleManger.DeleteAsync(role);
            return RedirectToAction("Index");
        }
    }
}
