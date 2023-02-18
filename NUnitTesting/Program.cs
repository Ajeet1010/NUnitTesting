namespace NUnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----  NUnit Testing  -----");
            Console.WriteLine("Using Georgian Calender finding weekday on the given date ");
            WeekDays weekDays = new WeekDays();
            WeekDays.Calender();
        }
    }
}