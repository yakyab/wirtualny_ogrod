using System.Collections.Generic;

namespace WirtualnyOgrod.Models
{
    /// <summary>
    /// Reprezentuje bibliotekę dostępnych roślin w aplikacji.
    /// </summary>
    public class PlantLibrary
    {
        /// <summary>
        /// Lista dostępnych roślin w bibliotece.
        /// </summary>
        public List<Plant> AvailablePlants { get; set; }

        /// <summary>
        /// Inicjalizuje nową instancję klasy <see cref="PlantLibrary"/> i tworzy listę dostępnych roślin.
        /// </summary>
        public PlantLibrary()
        {
            AvailablePlants = new List<Plant>();
        }
    }
}



