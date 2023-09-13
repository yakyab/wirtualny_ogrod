using System;

namespace WirtualnyOgrod.Models
{
    public class WateringSchedule
    {
        public int PlantId { get; set; }
        public DateTime LastWatered { get; set; }
        public TimeSpan WateringFrequency { get; set; }
        public DateTime NextWatering => LastWatered.Add(WateringFrequency);
    }
}

