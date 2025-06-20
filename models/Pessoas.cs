namespace Fundamentals.Models;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public string NameRepresentativePF { get; set; } // Changed to English: NameRepresentativePF

    public void Present() // Removed semicolon and corrected the method body
    {
        Console.WriteLine($"Hello, my name is {Name} and I'm {Age} years old."); // Corrected interpolation and added "years old"
    }
}