using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace vd10.Models
{
    public enum Grade
    {
        A,B,C,D,F
    }
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        [DisplayName("Srudent Name")]
        [Required(ErrorMessage ="Error Student")]
        public int? StudentID { get; set; }
        [DisplayName("Course ")]
        [Required(ErrorMessage = "Error Course")]
        public int? CourseID { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Not Null")]

        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Not Null")]
        public DateTime EndDate { get; set; }
        [DisplayFormat(NullDisplayText ="No Grade")]

        public Grade? Grade { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}
