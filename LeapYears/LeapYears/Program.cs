using System;

namespace LeapYears
{
    internal class Program
    {

        public Program(int currentYear)
        {

            for (int n = 1; n <= 80; n++)
            {
                if ((currentYear % 4) == 0 || (currentYear % 4) == 0 && (currentYear % 100) != 0)

                {

                    Console.WriteLine(currentYear);

                }

                currentYear++;

            }

        }

            static void Main(string[] args)
            {
            Console.WriteLine("Enter the year to print the next 20 leap years");
            int currentYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The next 20 leap years from " + currentYear + " are: ");

            Program Program = new Program(currentYear);
           
            Console.ReadLine();
            }
        }
}