using System;

namespace trytry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Today's Date: {DateTime.Today.ToShortDateString()}");
            Console.Write("Enter your Employer ID:");
            string employeeID = Console.ReadLine();

            TimeSpan timeIn = new TimeSpan(8, 45, 0);
            Console.WriteLine($"Log-in time: {timeIn}");

            TimeSpan regularhourStart = new TimeSpan(8, 0, 0);
            TimeSpan lateIn = new TimeSpan(0, 0, 0);
            TimeSpan totalLate = new TimeSpan(0, 0, 0);
            TimeSpan gracePeriod = new TimeSpan(8, 30, 0);


            if (timeIn > regularhourStart)
            {
                lateIn = timeIn - regularhourStart;
                if (timeIn > new TimeSpan(8, 30, 0))
                {
                    totalLate = timeIn - regularhourStart;
                    Console.WriteLine($"\nYou are {totalLate.Minutes} minutes late! ");
                }
            }

            Console.Write("\nEnter your Employer ID: ");
            employeeID = Console.ReadLine();

            TimeSpan timeOut = new TimeSpan(17, 0, 0);
            Console.WriteLine($"Log-out time: {timeOut}");

            TimeSpan lunchbreakDuration = new TimeSpan(1, 0, 0);
            TimeSpan totalHours = (timeOut - timeIn) - lunchbreakDuration;

            Console.WriteLine($"\nYour total hours worked: {totalHours}");
            TimeSpan totalRegularHours = totalHours - lateIn;
            Console.WriteLine($"Regular hours worked: {totalRegularHours}");
        }
    }
}
