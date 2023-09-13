using System;
using System.Collections.Generic;
using System.Text;

namespace WirtualnyOgrod.Models
{
    public class Garden
    {
        public int Id { get; set; }
        public string OwnerName { get; set; } // Nazwa właściciela ogrodu.
        public List<GardenSection> Sections { get; set; } // Lista sekcji w ogrodzie.

        public Garden()
        {
            Sections = new List<GardenSection>();
        }
    }
}
