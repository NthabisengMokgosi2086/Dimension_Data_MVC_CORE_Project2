using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dimension_Data_MVC_CORE_Project2.Controllers
{
    public class HumanResourceController : Controller
    {
        [Authorize(Roles = "Human Resource")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
