using System;
namespace StaticExercise
{
	public class TempConverter
	{
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * (5.0 / 9);
            return celsius;
        }


        public static double CelsiusToFahrenheight(double celsius)
        {
            double fahrenheight = (celsius * 9 / 5) + (32);
            return fahrenheight;
        }


    }
}