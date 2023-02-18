using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    internal class Temperature
    {

        // Convert Celsius to Fahrenheit and Fahrenheit to Celsius
        public void Conversion()
        {
            Console.Write("\nChoose to convert temperature in 1. Fahrenheit 2. Clesius\nEnter to choose  ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the temperature to convert:  ");
            float temp = float.Parse(Console.ReadLine());
            switch (choice)
            {            
                case 1:
                    float fahrenheit = (temp * 9 / 5) + 32;
                    Console.WriteLine("After converting celsius {0} to fahrenheit the temperature is: {1}", temp, fahrenheit);
                    break;
                case 2:
                    float Celsius = (temp - 32) * 5 / 9;
                    Console.WriteLine("After converting fahrenheit {0} to celsius the temperature is: {1}", temp, Celsius);
                    break;
                default:
                    Console.WriteLine("Enter incorrect option");
                    break;
            }
        }        
    }
}
