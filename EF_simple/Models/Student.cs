using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_simple.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateBirth { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public virtual Grade grade { get; set; }
        public virtual Department department { get; set; }
    }
}
