using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_simple.Models
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }
        public float Physics { get; set; }
        public float Math { get; set; }
        public float Arabic { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }
        
        public virtual Student student { get; set; }

    }
}
