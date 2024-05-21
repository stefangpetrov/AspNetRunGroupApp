using RunGroupWebAppCLone.Data.Enum;
using RunGroupWebAppCLone.Models;

namespace RunGroupWebAppCLone.ViewModels
{
    public class CreateRaceViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public IFormFile Image { get; set; }
        public ClubCategory RaceCategory { get; set; }
    }
}
