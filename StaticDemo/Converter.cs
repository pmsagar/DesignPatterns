using System;
using System.Collections.Generic;
using System.Text;

namespace StaticDemo
{
    /// <summary>
    /// Whenver there is a static computation we can go for static classes, but these are not as flexibles as Singleton
    /// </summary>
    public static class Converter
    {
        public static double ToFarenheit(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }

        public static double ToCelcius(double farenheit)
        {
            return (farenheit - 32) * 5/9;
        }
    }
}
