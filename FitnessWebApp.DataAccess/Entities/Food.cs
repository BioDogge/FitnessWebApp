using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessWebApp.DataAccess.Entities
{
    public class Food
    {
        public int FoodId { get; set; }

        /// <summary>
        /// Name of food.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The amount of proteins in food.
        /// </summary>
        [Column(TypeName = "decimal(4,1)")]
        public decimal Proteins { get; set; }

        /// <summary>
        /// The amount of fats in food.
        /// </summary>
        [Column(TypeName = "decimal(4,1)")]
        public decimal Fats { get; set; }

        /// <summary>
        /// The amount of carbohydrates in food.
        /// </summary>
        [Column(TypeName = "decimal(4,1)")]
        public decimal Carbohydrates { get; set; }

        /// <summary>
        /// The amount of calories in food.
        /// </summary>
        [Column(TypeName = "decimal(4,1)")]
        public decimal Calories { get; set; }

        public Vitamin? Vitamin { get; set; }

        public IEnumerable<FoodEating>? FoodEatings { get; set; }
        public IEnumerable<Eating>? Eatings { get; set; }
    }
}