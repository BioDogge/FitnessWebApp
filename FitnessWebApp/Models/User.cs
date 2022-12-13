using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessWebApp.Models
{
    public class User
    {
        public int UserId { get; set; }

        /// <summary>
        /// Name of User.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Age of User.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Weight of User.
        /// </summary>
        public decimal Weight { get; set; }

        /// <summary>
        /// Height of User.
        /// </summary>
        public decimal Height { get; set; }

        /// <summary>
        /// Gender of User
        /// </summary>
        public char GenderName { get; set; }
        public Gender? Gender { get; set; }

        public IEnumerable<Exercise>? Exercises { get; set; }
        public IEnumerable<Eating>? Eatings { get; set; }
    }
}