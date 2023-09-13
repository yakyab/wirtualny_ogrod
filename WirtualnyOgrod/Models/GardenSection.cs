using System;
using System.Collections.Generic;
using System.Text;

namespace WirtualnyOgrod.Models
{
    public class GardenSection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Plant> Plants { get; set; } // Lista roślin w danej sekcji.

        public GardenSection()
        {
            Plants = new List<Plant>();
        }
    }
}

