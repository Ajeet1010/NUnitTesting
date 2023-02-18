using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    internal class Amount
    {

        public static void MonthlyPayment()
        {
            Console.Write("\nEnter the princple amount that has been taken: ");
            int P = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the no of years for which amount has been taken: ");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the rate of interest at which amount has been given:  ");
            float R = float.Parse(Console.ReadLine());
            float r = R / (12 * 100);
            int n = 12 * Y;
            double payment = (P * r) / (1 - (Math.Pow((1 + r), -n)));
            Console.WriteLine("\nMonthly payment for {0} amount that has been taken on a interest of {1} for {2} years is :  {3}", P, R, Y, payment);

        }
    }
}
