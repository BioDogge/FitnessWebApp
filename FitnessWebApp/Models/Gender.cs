using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessWebApp.Models
{
    public class Gender
    {
        public char Name { get; set; }

        public IEnumerable<User>? Users { get; set; }
    }
}