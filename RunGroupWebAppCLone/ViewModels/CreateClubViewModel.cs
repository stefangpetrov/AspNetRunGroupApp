﻿using RunGroupWebAppCLone.Data.Enum;
using RunGroupWebAppCLone.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace RunGroupWebAppCLone.ViewModels
{
    public class CreateClubViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public IFormFile Image { get; set; }
        public ClubCategory ClubCategory { get; set; }
    }
}
