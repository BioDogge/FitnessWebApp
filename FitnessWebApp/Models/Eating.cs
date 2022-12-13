using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessWebApp.Models
{
    public class Eating
    {
        public int EatingId { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }

        public DateTime MealDate { get; set; }

        public DateTime MealTime { get; set; }
    }
}