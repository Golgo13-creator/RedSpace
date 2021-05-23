using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSpace.Models
{
    public class ShipOrigin
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string ShipName { get; set; }
        [Required]
        public int CrewCapacity { get; set; }
    }
}
