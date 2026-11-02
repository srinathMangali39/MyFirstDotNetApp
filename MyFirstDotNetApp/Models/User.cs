using Microsoft.AspNetCore.Mvc;

namespace MyFirstDotNetApp.Models;

public class User
{
    public string Name { get; set; } = string.Empty;

    [FromQuery]
    public int Age { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}