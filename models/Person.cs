namespace Fundamentals.Models;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public string NameRepresentativePF { get; set; }

    public void Present()
    {
        Console.WriteLine($"Hello, my name is {Name} and I'm {Age} years old.");
    }
}