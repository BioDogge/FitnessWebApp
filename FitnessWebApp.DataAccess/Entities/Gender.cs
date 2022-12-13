using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessWebApp.DataAccess.Entities
{
    public class Gender
    {
        [Column(TypeName = "char(1)")]
        public char Name { get; set; }

        public IEnumerable<User>? Users { get; set; }
    }
}