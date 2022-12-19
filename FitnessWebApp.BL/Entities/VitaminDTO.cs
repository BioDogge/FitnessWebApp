using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessWebApp.BL.Entities
{
    public class VitaminDTO
    {
        public int FoodId { get; set; }
        public FoodDTO? Food { get; set; }

        /// <summary>
        /// The amount of vitamin C in food (in 100 grams).
        /// </summary>
        public decimal VitaminC { get; set; }

        /// <summary>
        /// The amount of vitamin B6 in food (in 100 grams).
        /// </summary>
        public decimal VitaminB6 { get; set; }

        /// <summary>
        /// The amount of vitamin B12 in food (in 100 grams).
        /// </summary>
        public decimal VitaminB12 { get; set; }

        /// <summary>
        /// The amount of vitamin D in food (in 100 grams).
        /// </summary>
        public decimal VitaminD { get; set; }

        /// <summary>
        /// The amount of iron in food (in 100 grams).
        /// </summary>
        public decimal Iron { get; set; }

        /// <summary>
        /// The amount of magnesium in food (in 100 grams).
        /// </summary>
        public decimal Magnesium { get; set; }

        /// <summary>
        /// The amount of calcium in food (in 100 grams).
        /// </summary>
        public decimal Calcium { get; set; }
    }
}