using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    internal class VendingMachine
    {
        public void Currency()
        {
            int[] notes = new int[] {1, 2, 5, 10, 20, 50, 100, 200, 500, 2000};
            int[] Counting = new int[10];

            Console.Write("Enter the specific amount to change: ");
            int amount = Convert.ToInt32( Console.ReadLine() );

            for (int i = 0; i < Counting.Length; i++)
            {
                if (amount >= notes[i])
                {
                    Counting[i] = amount / notes[i];
                    amount = amount % notes[i];
                }
            }

            Console.WriteLine("Number of notes withdrawn");
            for (int i = 0; i < Counting.Length; i++)
            {
                if (Counting[i] != 0)
                    Console.WriteLine("{1} note of {0}", notes[i], Counting[i]);
            }
        }
    }
}
