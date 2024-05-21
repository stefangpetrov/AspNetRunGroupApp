using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroupWebAppCLone.Data;
using RunGroupWebAppCLone.Interfaces;
using RunGroupWebAppCLone.Models;

namespace RunGroupWebAppCLone.Controllers
{
    public class ClubController : Controller
    {
        public ClubController(IClubRepository clubRepository)
        {
            this._clubRepository = clubRepository;
        }

        private readonly IClubRepository _clubRepository;

        public async Task<IActionResult> Index()
        {
            var clubs = await _clubRepository.GetAll();
            return View(clubs);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var club = await _clubRepository.GetByIdAsync(id);
            return View(club);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Club club)
        {
            if (!ModelState.IsValid)
            {
                return View(club);
            }
            _clubRepository.Add(club);
            return RedirectToAction("Index");
        }
    }
}
