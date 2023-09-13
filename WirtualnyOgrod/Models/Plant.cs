using System;
using System.Collections.Generic;
using System.Text;

namespace WirtualnyOgrod.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; } // Ścieżka do obrazu rośliny.
        public double GrowthRate { get; set; } // Szybkość wzrostu rośliny.
        public double WaterNeeds { get; set; } // Ilość wody potrzebnej roślinie.

    }
}
