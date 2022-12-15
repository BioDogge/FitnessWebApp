using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessWebApp.DataAccess.Entities
{
    public class Vitamin
    {
        [Key]
        public int FoodId { get; set; }
        public Food? Food { get; set; }

        /// <summary>
        /// The amount of vitamin C in food (in 100 grams).
        /// </summary>
        [Column(TypeName = "decimal(4,1)")]
        public decimal VitaminC { get; set; }

        /// <summary>
        /// The amount of vitamin B6 in food (in 100 grams).
        /// </summary>
        [Column(TypeName = "decimal(4,1)")]
        public decimal VitaminB6 { get; set; }

        /// <summary>
        /// The amount of vitamin B12 in food (in 100 grams).
        /// </summary>
        [Column(TypeName = "decimal(4,1)")]
        public decimal VitaminB12 { get; set; }

        /// <summary>
        /// The amount of vitamin D in food (in 100 grams).
        /// </summary>
        [Column(TypeName = "decimal(4,1)")]
        public decimal VitaminD { get; set; }

        /// <summary>
        /// The amount of iron in food (in 100 grams).
        /// </summary>
        [Column(TypeName = "decimal(4,1)")]
        public decimal Iron { get; set; }

        /// <summary>
        /// The amount of magnesium in food (in 100 grams).
        /// </summary>
        [Column(TypeName = "decimal(4,1)")]
        public decimal Magnesium { get; set; }

        /// <summary>
        /// The amount of calcium in food (in 100 grams).
        /// </summary>
        [Column(TypeName = "decimal(4,1)")]
        public decimal Calcium { get; set; }
    }
}