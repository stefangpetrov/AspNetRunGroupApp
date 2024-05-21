using Microsoft.EntityFrameworkCore;
using RunGroupWebAppCLone.Data;
using RunGroupWebAppCLone.Interfaces;
using RunGroupWebAppCLone.Models;

namespace RunGroupWebAppCLone.Repository
{
    public class RaceRepository : IRaceRepository
    {
        private readonly ApplicationDbContext _context;
        public RaceRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public bool Add(Race race)
        {
            _context.Add(race);
            return Save();
        }

        public bool Delete(Race race)
        {
            _context.Remove(race);
            return Save();
        }

        public async Task<IEnumerable<Race>> GetAll()
        {

            return await _context.Races.ToListAsync();
        }

        public async Task<Race> GetByIdAsync(int id)
        {
            return await _context.Races.Include(i => i.Address).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Race>> GetRaceByCity(string city)
        {
            return await _context.Races.Where(r => r.Address.City.Contains(city)).ToListAsync();

        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved == 0 ? true : false;
        }

        public bool Update(Race race)
        {
            _context.Update(race);
            return Save();
        }
    }
}
