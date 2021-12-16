using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a temperature in Fahrehenheit:");
            double f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The temperature in Celsius is {TempConverter.FahrenheitToCelsius(f)}");
            Console.WriteLine();
            Console.WriteLine("Enter a temperature in Celsius:");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The temperature in Fahrenheit is {TempConverter.CelsiusToFahrenheit(c)}");
        }
    }
}
