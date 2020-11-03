using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dimension_Data_MVC_CORE_Project2.Controllers
{
    public class EmployeeController : Controller
    {
        [Authorize(Roles = "Sales Executive,Research Scientist,Laboratory Technician,Manufacturing Director,Sales Representative,Research Director,Healthcare Representative")]
        public IActionResult Index()
        {
            return View();
        }

    }
}
