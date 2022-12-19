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
    public class EatingDTO
    {
        public int EatingId { get; set; }

        /// <summary>
        /// Unique user ID.
        /// </summary>
        public int UserId { get; set; }
        public UserDTO? User { get; set; }

        /// <summary>
        /// User's meal date.
        /// </summary>
        public DateTime MealDate { get; set; }

        /// <summary>
        /// User's meal time.
        /// </summary>
        public DateTime MealTime { get; set; }

        public IEnumerable<FoodEatingDTO>? FoodEatings { get; set; }
        public IEnumerable<FoodDTO>? Foods { get; set; }
    }
}