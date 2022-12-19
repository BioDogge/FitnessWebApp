using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessWebApp.BL.Entities
{
    public class FoodDTO
    {
        public int FoodId { get; set; }

        /// <summary>
        /// Name of food.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The amount of proteins in food (in 100 grams).
        /// </summary>
        public decimal Proteins { get; set; }

        /// <summary>
        /// The amount of fats in food (in 100 grams).
        /// </summary>
        public decimal Fats { get; set; }

        /// <summary>
        /// The amount of carbohydrates in food (in 100 grams).
        /// </summary>
        public decimal Carbohydrates { get; set; }

        /// <summary>
        /// The amount of calories in food (in 100 grams).
        /// </summary>
        public decimal Calories { get; set; }

        public VitaminDTO? Vitamin { get; set; }

        public IEnumerable<FoodEatingDTO>? FoodEatings { get; set; }
        public IEnumerable<EatingDTO>? Eatings { get; set; }
    }
}