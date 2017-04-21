using ManagerReports.Data;
using Microsoft.AspNetCore.Mvc;

namespace ManagerReports.Controllers.Web
{
    public class HomeController : Controller
    {
        private readonly ReportsDatabase _db;

        public HomeController(ReportsDatabase db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "ManagerLog");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

