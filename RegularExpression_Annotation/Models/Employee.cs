using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegularExpression_Annotation.Models
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
        //[RegularExpression(@"\A(?:[a-z0-9!#$%&'+/=?^_{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_{|}~-]+)@(?:[a-z0-9](?:[a-z0-9-][a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-][a-z0-9])?)\Z", ErrorMessage ="Invalid Email")]
        //[RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$", ErrorMessage = "Your email address is not in a valid format. Example of correct format: joe.example@example.org")]
        //[RegularExpression(@"^\w+([-+.']\w+)*@123g.com$", ErrorMessage = "Invalid Email.")]
        //[RegularExpression("^[a-za-z0-9_\\.-]+@([a-za-z0-9-]+\\.)+[a-za-z]{2,6}$",ErrorMessage ="Invalid Email")]
        //[RegularExpression(@"^ ([a - zA - Z0 - 9_\-\.] +)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{ 1,3}\.)| (([a - zA - Z0 - 9\-] +\.)+))([a - zA - Z]{ 2,4}|[0 - 9]{ 1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
        [RegularExpression("^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-z]{2,9})$", ErrorMessage = "Invalid Email")]
        public string EmployeeEmail { get; set; }

        [Required(ErrorMessage = "Password is Mandatory")]
        //[RegularExpression(@"(?= ^.{8,}$) ((?=.*\d) | (?=.*\W+)) (?! [. \n]) (?=.*[A-Z]) (?=.*[a-z]).*$",ErrorMessage ="UpperCase,Lower Case,Number,Symbols, 8 Character")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$", ErrorMessage = "UpperCase,Lower Case,Number,Symbols, 8 Character")]
        public string EmployeePassword { get; set; }

    }
}