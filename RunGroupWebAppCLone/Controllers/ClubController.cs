using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroupWebAppCLone.Data;
using RunGroupWebAppCLone.Models;

namespace RunGroupWebAppCLone.Controllers
{
    public class ClubController : Controller
    {
        public ClubController(ApplicationDbContext context)
        {
            this._context = context;
        }

        private readonly ApplicationDbContext _context;

        public IActionResult Index()
        {
            var clubs = _context.Clubs.ToList();
            return View(clubs);
        }

        public IActionResult Detail(int id)
        {
            Club club = _context.Clubs.Include(a => a.Address).FirstOrDefault(c => c.Id == id);
            return View(club);
        }
    }
}
