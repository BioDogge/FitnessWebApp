using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessWebApp.DataAccess.Entities
{
    public class FoodEating
    {
        /// <summary>
        /// Unique eating ID.
        /// </summary>
        public int EatingId { get; set; }
        public Eating? Eating { get; set; }

        /// <summary>
        /// Unique food ID.
        /// </summary>
        public int FoodId { get; set; }
        public Food? Food { get; set; }

        /// <summary>
        /// Portion size in grams.
        /// </summary>
        [Column(TypeName = "decimal(4,1)")]
        public decimal PortionSize { get; set; }
    }
}