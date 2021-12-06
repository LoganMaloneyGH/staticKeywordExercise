using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_keyword
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fTemp)
        {
            var celTemp = (fTemp - 32) * 5 / 9;
            return celTemp; 
        }

        public static double CelsiusToFahrenheit(double cTemp)
        {
            var fahTemp = (cTemp * 9 / 5) + 32;
            return fahTemp; 
        }
    }
}
