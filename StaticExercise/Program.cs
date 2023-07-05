namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"2.0 degrees farenheight is equal to {TempConverter.FahrenheitToCelsius(2.0)} degrees celsius");

            Console.WriteLine($"40.0 degrees celsius is equal to {TempConverter.CelsiusToFahrenheight(40.0)} degrees fahrenheight");

        }
    }
}
