using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    internal class WeekDays
    {
        public static void Calender()
        {
            Console.Write("Please enter the date: ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("On {0} {1} of year {2}", date, month, year);

            // Formula for calculating week day
            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (date + x + 31 * m0 / 12) % 7;
            d0 = d0 % 7;
            switch (d0)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
        }
    }
}
