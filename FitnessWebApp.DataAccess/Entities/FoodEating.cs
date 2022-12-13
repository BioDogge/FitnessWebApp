using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessWebApp.DataAccess.Entities
{
    public class FoodEating
    {
        public int EatingId { get; set; }
        public Eating? Eating { get; set; }

        public int FoodId { get; set; }
        public Food? Food { get; set; }

        [Column(TypeName = "decimal(4,1)")]
        public decimal PortionSize { get; set; }
    }
}