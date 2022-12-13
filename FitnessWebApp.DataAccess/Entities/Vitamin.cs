using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessWebApp.DataAccess.Entities
{
    public class Vitamin
    {
        public int Id { get; set; }

        public int FoodId { get; set; }
        public Food? Food { get; set; }

        /// <summary>
        /// The amount of vitamin C in food.
        /// </summary>
        [Column(TypeName = "decimal(4,1)")]
        public decimal VitaminC { get; set; }

        /// <summary>
        /// The amount of vitamin B6 in food.
        /// </summary>
        [Column(TypeName = "decimal(4,1)")]
        public decimal VitaminB6 { get; set; }

        /// <summary>
        /// The amount of vitamin B12 in food.
        /// </summary>
        [Column(TypeName = "decimal(4,1)")]
        public decimal VitaminB12 { get; set; }

        /// <summary>
        /// The amount of vitamin D in food.
        /// </summary>
        [Column(TypeName = "decimal(4,1)")]
        public decimal VitaminD { get; set; }

        /// <summary>
        /// The amount of iron in food.
        /// </summary>
        [Column(TypeName = "decimal(4,1)")]
        public decimal Iron { get; set; }

        /// <summary>
        /// The amount of magnesium in food.
        /// </summary>
        [Column(TypeName = "decimal(4,1)")]
        public decimal Magnesium { get; set; }

        /// <summary>
        /// The amount of calcium in food.
        /// </summary>
        [Column(TypeName = "decimal(4,1)")]
        public decimal Calcium { get; set; }
    }
}