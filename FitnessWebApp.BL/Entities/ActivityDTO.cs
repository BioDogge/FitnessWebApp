using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessWebApp.BL.Entities
{
    public class ActivityDTO
    {
        public int ActivityId { get; set; }

        /// <summary>
        /// Name of Activity.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Number of calories burned.
        /// </summary>
        public double CaloriesPerMinute { get; set; }

        public IEnumerable<ExerciseDTO>? Exercises { get; set; }
    }
}