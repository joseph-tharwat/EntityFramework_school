using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_simple.Models
{
    public class StudentBook
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }

        public virtual Student student { get; set; }
        public virtual Book book { get; set; }
    }
}
