namespace NUnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----  NUnit Testing  -----");
            Console.WriteLine("Conversion of temperature  in Celsius or Fahrenheit");
            Temperature temperature = new Temperature();
            temperature.Conversion();
        }
    }
}