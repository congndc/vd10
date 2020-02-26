using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace vd10.Models
{
    public class Course
    {
        public Course()
        {
            Enrollment = new HashSet<Enrollment>();
        }
        [Key]
        public int CourseID { get; set; }   
        [Column(TypeName ="ntext")]
        [StringLength(50)]
        [Required(ErrorMessage ="Not NULL")]
        public string CourseName { get; set; }
        
        [StringLength(50)]
        [Required(ErrorMessage = "Not NULL")]
        public string Credits { get; set; }
        public ICollection<Enrollment> Enrollment { get; set; }
    }
}
