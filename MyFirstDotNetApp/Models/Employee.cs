using System.ComponentModel.DataAnnotations;

namespace MyFirstDotNetApp.Models;

public class Employee
{
    [Required(ErrorMessage ="field cannot be empty or null")]
    public string? FullName { get; set;  }

    public string? Email { get; set; }
    
    public string? PhoneNumber { get; set; }

    public string? Password { get; set; }

    public string? ConfirmPassword { get; set; }    


}