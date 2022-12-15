using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessWebApp.DataAccess.Entities
{
    public class Gender
    {
        [Key]
        [Column(TypeName = "char(1)")]
        public char Name { get; set; }

        public IEnumerable<User>? Users { get; set; }
    }
}