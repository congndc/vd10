using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace vd10.Models
{
    public class Gender
    {
        public Gender()
        {
            Student = new HashSet<Student>();
        }
        [Key]
        public int GenderID { get; set; }
        [Column(TypeName ="ntext")]
        [StringLength(50)]
        [Required(ErrorMessage = "Not NULL")]
        public string GenderName { get; set; }
        public ICollection<Student> Student { get; set; }
    }
}
