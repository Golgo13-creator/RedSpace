using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSpace.Models.SpaceStationModels
{
    public class SpaceStationEdit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaximumOccupancy { get; set; }
    }
}
