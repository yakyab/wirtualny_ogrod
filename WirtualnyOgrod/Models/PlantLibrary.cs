using System.Collections.Generic;

namespace WirtualnyOgrod.Models
{
    public class PlantLibrary
    {
        public List<Plant> AvailablePlants { get; set; }

        public PlantLibrary()
        {
            AvailablePlants = new List<Plant>();
        }
    }
}


