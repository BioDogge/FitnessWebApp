using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessWebApp.Models
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
        public decimal Proteins { get; set; }

        /// <summary>
        /// The amount of fats in food.
        /// </summary>
        public decimal Fats { get; set; }

        /// <summary>
        /// The amount of carbohydrates in food.
        /// </summary>
        public decimal Carbohydrates { get; set; }

        /// <summary>
        /// The amount of calories in food.
        /// </summary>
        public decimal Calories { get; set; }

        public Vitamin? Vitamin { get; set; }
    }
}