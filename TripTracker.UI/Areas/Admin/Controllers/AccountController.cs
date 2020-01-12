using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TripTracker.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("jeff/Account/[action]")]
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}