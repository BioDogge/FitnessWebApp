using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessWebApp.Models
{
    public class Exercise
    {
        public int ExerciseId { get; set; }
     
        public int ActivityId { get; set; }
        public Activity? Activity { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }

        /// <summary>
        /// Exercise date. 
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Exercise start time.
        /// </summary>
        [Column(TypeName = "time(0)")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Exercise finish time.
        /// </summary>
        [Column(TypeName = "time(0)")]
        public DateTime FinishTime { get; set; }

        //TODO: Perhaps it will need to fix
    }
}