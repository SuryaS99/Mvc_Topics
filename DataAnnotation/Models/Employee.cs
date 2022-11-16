using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotation.Models
{
    public class Employee
    {

        [Required(ErrorMessage = "Id is Mandatory")]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Name is Mandatory")]
        public String EmployeeName { get; set; }
        //when we add after the data type?(question mark) then it will become nullable means it can have the null value.
        [Required(ErrorMessage = "Age is Mandatory")]
        public int EmployeeAge { get; set; }
        [Required(ErrorMessage = "Gender is Mandatory")]
        public string EmployeeGender { get; set; }
        [Required(ErrorMessage = "Email is Mandatory")]
        public string EmployeeEmail { get; set; }


    }
}