using System.ComponentModel.DataAnnotations;

namespace EF_simple.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
