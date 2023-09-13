﻿using System;

namespace WirtualnyOgrod.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public double GrowthRate { get; set; }
        public double WaterNeeds { get; set; }
        public DateTime LastWateredDate { get; set; }
        public DateTime NextWateringDate { get; set; }
    }
}


