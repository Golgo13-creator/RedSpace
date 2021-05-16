using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSpace.Models.SpaceStationModels
{
    public class SpaceStationCreate
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Max Capacity")]
        public int MaximumOccupancy { get; set; }
    }
}
