using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroupWebAppCLone.Data;
using RunGroupWebAppCLone.Interfaces;
using RunGroupWebAppCLone.Models;
using RunGroupWebAppCLone.Repository;

namespace RunGroupWebAppCLone.Controllers
{
    public class RaceController : Controller
    {
        private IRaceRepository _raceRepository;

        public RaceController(IRaceRepository raceRepository)
        {
            this._raceRepository = raceRepository;
        }

        public async Task<IActionResult> Index()
        {
            var races = await _raceRepository.GetAll();
            return View(races);
        }
        public async Task<IActionResult> Detail(int id)
        {
            Race race = await _raceRepository.GetByIdAsync(id);
            return View(race);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Race race)
        {
            if (!ModelState.IsValid)
            {
                return View(race);
            }
            _raceRepository.Add(race);
            return RedirectToAction("Index");
        }
    }
}
