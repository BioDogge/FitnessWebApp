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
    public class ExerciseDTO
    {
        public int ExerciseId { get; set; }

        /// <summary>
        /// Unique activity ID.
        /// </summary>
        public int ActivityId { get; set; }
        public ActivityDTO? Activity { get; set; }

        /// <summary>
        /// Unique user ID.
        /// </summary>
        public int UserId { get; set; }
        public UserDTO? User { get; set; }

        /// <summary>
        /// User's exercise date. 
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// User's exercise start time.
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// User's exercise finish time.
        /// </summary>
        public DateTime FinishTime { get; set; }
    }
}