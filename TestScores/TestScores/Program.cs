
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int high = 0;
            int low = 100;
            int average = 0;
            int count = 0;
            int userChoice = 0;
            int total = 0;
            int userExit = 0;

            while (userExit != 999)
            {
                WriteLine("Enter the scores");
                userChoice = Convert.ToInt32(ReadLine());
                if (userChoice >= high && userChoice < 101)
                {
                    high = userChoice;
                    count = count + 1;
                }
                else if (userChoice <= low && userChoice > -1)
                {
                    low = userChoice;
                    count = count + 1;
                }
                else if (userChoice <= 101 && userChoice >= 0)
                {
                    count = count + 1;
                }
                else if (userChoice > 100 || userChoice < 0)
                {
                    WriteLine("Out of range. ");
                }
                total = userChoice + total;
                average = total / count;
                WriteLine("Enter a number to continue to exit 999");
                userExit = Convert.ToInt32(ReadLine());
            }

            WriteLine("There were " + count + " scores entered, the average was " + average
                    + " The highest score was " + high + " the lowest score was " + low + " ");

        }
    }
}
