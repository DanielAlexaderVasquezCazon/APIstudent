using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIstudent.Models
{
    public class Student
    {
        [Key]
        [Required]
        [Range(1,9999)]
        public int StudentID { get; set; }



        [StringLength(30)]//lIMITA A 30 CARACTERES
        [Required(ErrorMessage = "YOU MUST ENTER THE FIELD {0} ")]
        public string LastName { get; set; }



        [StringLength(30, ErrorMessage ="The field {0} must contain betwen {2} and {1} character ", MinimumLength =2)]
        [Required(ErrorMessage = "YOU MUST ENTER THE FIELD {0} ")]
        public string FirstName { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

    }
}