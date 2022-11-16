using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Range_Annotation.Models
{
    public class Employee
    {
        [DisplayName("ID")]
        [Required(ErrorMessage = "Id is Mandatory")]
        public int EmployeeId { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Name is Mandatory")]
        public String EmployeeName { get; set; }

        [DisplayName("Age")]
        //when we add after the data type?(question mark) then it will become nullable means it can have the null value.
        [Required(ErrorMessage = "Age is Mandatory")]
        [Range(20, 25, ErrorMessage = "Age should be in 20-25 range")]
        public int EmployeeAge { get; set; }

        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is Mandatory")]
        public string EmployeeGender { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is Mandatory")]
        public string EmployeeEmail { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is Mandatory")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$", ErrorMessage = "UpperCase,Lower Case,Number,Symbols, 8 Character")]
        [DataType(DataType.Password)]
        public string EmployeePassword { get; set; }

        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Comfirm Password is Mandatory")]
        [Compare("EmployeePassword", ErrorMessage = "Password is not identical")]
        [DataType(DataType.Password)]
        public string EmployeeConfirmPassword { get; set; }


        [DisplayName("Organization Name")]
        [ReadOnly(true)]
        public string EmployeeOrganizationName { get; set; }

        [DisplayName("Address")]
        [Required(ErrorMessage = "Address is Mandatory")]
        [DataType(DataType.MultilineText)]
        public string EmployeeAddress { get; set; }

        [DisplayName("Joining Date")]
        [Required(ErrorMessage = "Date is Mandatory")]
        [DataType(DataType.Date)]
        public string EmployeeJoiningDate { get; set; }

        [DisplayName("Joining Time")]
        [Required(ErrorMessage = "Time is Mandatory")]
        [DataType(DataType.Time)]
        public string EmployeeJoiningTime { get; set; }

    }
}