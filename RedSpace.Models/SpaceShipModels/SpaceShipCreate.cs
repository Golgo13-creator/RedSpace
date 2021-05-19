﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSpace.Models.SpaceShipModels
{
    public class SpaceShipCreate
    {
        [Required]
        [Display(Name = "Ship Name")]
        public string ShipName { get; set; }
        [Required]
        [Display(Name = "Crew Capacity")]
        public int CrewCapacity { get; set; }
        [Required]
        public int LaunchSiteId { get; set; }
    }
}
