using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessWebApp.BL.Entities
{
    public class FoodEatingDTO
    {
        /// <summary>
        /// Unique eating ID.
        /// </summary>
        public int EatingId { get; set; }
        public EatingDTO? Eating { get; set; }

        /// <summary>
        /// Unique food ID.
        /// </summary>
        public int FoodId { get; set; }
        public FoodDTO? Food { get; set; }

        /// <summary>
        /// Portion size in grams.
        /// </summary>
        public decimal PortionSize { get; set; }
    }
}