using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessWebApp.DataAccess.Entities
{
    public class Eating
    {
        public int EatingId { get; set; }

        /// <summary>
        /// Unique user ID.
        /// </summary>
        public int UserId { get; set; }
        public User? User { get; set; }

        /// <summary>
        /// User's meal date.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime MealDate { get; set; }

        /// <summary>
        /// User's meal time.
        /// </summary>
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime MealTime { get; set; }

        public IEnumerable<FoodEating>? FoodEatings { get; set; }
        public IEnumerable<Food>? Foods { get; set; }
    }
}