using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StringLength_Annotation.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "ID is Mandatory")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Name is Mandatory")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Name should be 5-20 character")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Age is Mandatory")]
        public int EmployeeAge { get; set; }

        [Required(ErrorMessage = "Gender is Mandatory")]
        public string EmployeeGender { get; set; }

        [Required(ErrorMessage = "Email is Mandatory")]
        public string EmployeeEmail { get; set; }

    }
}