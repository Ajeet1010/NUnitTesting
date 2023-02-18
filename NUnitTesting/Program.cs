namespace NUnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----  NUnit Testing  -----");
            Console.WriteLine("$ to be returned by vending machine: ");
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.Currency();
        }
    }
}