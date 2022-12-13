namespace FitnessWebApp.Models
{
    public class Activity
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

        public IEnumerable<Exercise>? Exercises { get; set; }
    }
}