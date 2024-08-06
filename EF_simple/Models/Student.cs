using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_simple.Models
{
    //[Index("Name")]
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Column("DateOfBarth", TypeName ="varchar(50)")]
        public string Name { get; set; }
        public int Age { get; set; }

        [NotMapped] 
        public DateTime DateBirth { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public int Order { get; set; } // for sequence

        public virtual Grade grade { get; set; }
        public virtual Department department { get; set; }
    }
}
