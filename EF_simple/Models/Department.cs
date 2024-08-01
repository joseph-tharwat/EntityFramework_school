using System.ComponentModel.DataAnnotations;

namespace EF_simple.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> students { get; set; } 
    }
}
