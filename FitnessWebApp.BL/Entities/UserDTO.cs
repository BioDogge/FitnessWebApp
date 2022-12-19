using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessWebApp.BL.Entities
{
    public class UserDTO
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
        public GenderDTO? Gender { get; set; }

        public IEnumerable<ExerciseDTO>? Exercises { get; set; }
        public IEnumerable<EatingDTO>? Eatings { get; set; }
    }
}