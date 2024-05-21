using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroupWebAppCLone.Data;
using RunGroupWebAppCLone.Models;

namespace RunGroupWebAppCLone.Controllers
{
    public class RaceController : Controller
    {

        public RaceController(ApplicationDbContext context)
        {
            this._context = context;
        }

        private readonly ApplicationDbContext _context;
        public IActionResult Index()
        {
            var races = _context.Races.ToList();
            return View(races);
        }
        public IActionResult Detail(int id)
        {
            Race race = _context.Races.Include(a => a.Address).FirstOrDefault(c => c.Id == id);
            return View(race);
        }
    }
}
