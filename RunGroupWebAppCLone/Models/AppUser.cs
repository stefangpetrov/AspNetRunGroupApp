using System.ComponentModel.DataAnnotations;

namespace RunGroupWebAppCLone.Models
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }

        public int? Pace { get; set; }

        public int?  Mileage { get; set; }
        public Address? Address { get; set; }
    }
}
