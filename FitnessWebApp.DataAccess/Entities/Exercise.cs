using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessWebApp.DataAccess.Entities
{
    public class Exercise
    {
        public int ExerciseId { get; set; }
     
        /// <summary>
        /// Unique activity ID.
        /// </summary>
        public int ActivityId { get; set; }
        public Activity? Activity { get; set; }

        /// <summary>
        /// Unique user ID.
        /// </summary>
        public int UserId { get; set; }
        public User? User { get; set; }

        /// <summary>
        /// User's exercise date. 
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// User's exercise start time.
        /// </summary>
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// User's exercise finish time.
        /// </summary>
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime FinishTime { get; set; }
    }
}