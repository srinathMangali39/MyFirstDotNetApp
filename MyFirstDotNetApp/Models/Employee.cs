using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MyFirstDotNetApp.Models;

public class Employee
{
    [ValidateNever]
    [Required(ErrorMessage = "field {0} cannot be empty or null")]
    [Display(Name = "Employee Name")]
    [StringLength(10, MinimumLength = 3, ErrorMessage = "{0} should be min length of {2} and max length of {1}")]
    //[RegularExpression("[A-Za-z _]$", ErrorMessage = "{0} should be of all alphabets")]
    public string? FullName { get; set; }

    [EmailAddress(ErrorMessage ="{0} should follow email format")]
    public string? Email { get; set; }

    [Phone(ErrorMessage = "{0} should follow Phone Number format")]
    public string? PhoneNumber { get; set; }

    public string? Password { get; set; }

    [Compare("Password",ErrorMessage ="{0} should be same as {1} value")]
    public string? ConfirmPassword { get; set; }

    [BindNever]
    [Range(25, 60, ErrorMessage = "{0} should be between {1} and {2}")]
    public string? Age { get; set; }


}