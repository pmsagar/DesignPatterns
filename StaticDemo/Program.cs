using System;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius = 37; double farenheit = 98.6;
            Console.WriteLine("C to F:"+ Converter.ToFarenheit(celcius));
            Console.WriteLine("F to C:"+ Converter.ToCelcius(farenheit));
            Console.ReadLine();
        }
    }
}
