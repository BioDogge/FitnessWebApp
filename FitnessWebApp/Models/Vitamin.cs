using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessWebApp.Models
{
    public class Vitamin
    {
        public int Id { get; set; }

        public int FoodId { get; set; }
        public Food? Food { get; set; }

        /// <summary>
        /// The amount of vitamin C in food.
        /// </summary>
        public decimal VitaminC { get; set; }

        /// <summary>
        /// The amount of vitamin B6 in food.
        /// </summary>
        public decimal VitaminB6 { get; set; }

        /// <summary>
        /// The amount of vitamin B12 in food.
        /// </summary>
        public decimal VitaminB12 { get; set; }

        /// <summary>
        /// The amount of vitamin D in food.
        /// </summary>
        public decimal VitaminD { get; set; }

        /// <summary>
        /// The amount of iron in food.
        /// </summary>
        public decimal Iron { get; set; }

        /// <summary>
        /// The amount of magnesium in food.
        /// </summary>
        public decimal Magnesium { get; set; }

        /// <summary>
        /// The amount of calcium in food.
        /// </summary>
        public decimal Calcium { get; set; }
    }
}