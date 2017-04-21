using System;
using System.Data.Entity;
using System.Threading.Tasks;
using ManagerReports.Data;
using ManagerReports.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ManagerReports.Controllers.Web
{
    public class ManagerLogController : Controller
    {
        private readonly ReportsDatabase _db;

        public ManagerLogController(ReportsDatabase db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index(DateTime? forDate = null)
        {
            if (forDate == null)
                forDate = DateTime.Today;

            
            var vm = new ManagerLogIndexViewModel()
            {
                Locations = await _db.Locations.ToListAsync(),
                ForDate = forDate.Value.Date
            };

            return View(vm);
        }
    }
}