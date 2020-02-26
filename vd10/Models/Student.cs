using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace vd10.Models
{
    public  enum Status
    {
        Undergraduate,
        PostGraduate,
        PhD,
        Suspended

    }
    public class Student
    {
        public Student()
        {
            Enrollment = new HashSet<Enrollment>();
        }
        [Key]
        public int StudentID { get; set; }
        [Column(TypeName ="ntext")]
        [StringLength(50)]
        [Required(ErrorMessage = "Not NULL")]
        public string FisrtName { get; set; }
        [Column(TypeName = "ntext")]
        [StringLength(50)]
        [Required(ErrorMessage = "Not NULL")]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Not NULL")]
        public DateTime DOB { get; set; }
        [ForeignKey("GenderID")]
        public int? GenderID { get; set; }
        [DataType(DataType.Date)]
        public DateTime? RegistrationDate { get; set; }

        public Status? Status { get; set; }

        public virtual Gender Gender { get; set; }
        public ICollection<Enrollment> Enrollment { get; set; }
        //public Gender Genders { get; set; }
    }
}
