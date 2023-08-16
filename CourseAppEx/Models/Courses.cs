using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseAppEx.Models
{
    [Table("Course")]
    public class Courses
    {
        [Key]
        public int CId { get; set; }
        public int CName { get; set; }
        public int CFee { get; set; }
        public int Status { get; set; }
        public int Technology { get; set; }

    }
}
