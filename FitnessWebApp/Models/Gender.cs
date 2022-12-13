using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessWebApp.Models
{
    public class Gender
    {
        [Column(TypeName = "char(1)")]
        public char Name { get; set; }

        public IEnumerable<User>? Users { get; set; }
    }
}