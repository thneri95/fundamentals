using System;


namespace Fundamentals.Models
{
    public class Calculator
    {
        public void Sum(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtraction(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplication(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void Division(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
    }
}