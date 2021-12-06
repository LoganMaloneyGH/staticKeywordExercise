using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is the temperature in F you want to convert?");
            double fahTemp = Convert.ToDouble(Console.ReadLine());
            double ConvertToCel = TempConverter.FahrenheitToCelsius(fahTemp);

            Console.WriteLine($"that equals {ConvertToCel} degrees Celsius.\n");

            Console.WriteLine("what is the temperature in celsius you want to convert?");
            double celTemp = Convert.ToDouble(Console.ReadLine()); ;
            double convertToFah = TempConverter.CelsiusToFahrenheit(celTemp);

            Console.WriteLine($"that equals {convertToFah} degrees Fahrenheit."); 
        }
    }
}
