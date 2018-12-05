using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            char initial;
            double danielle = 0;
            double edward = 0;
            double francis = 0;
            double total;

            do
            {
                WriteLine("Enter your salesperson's initial.");
                initial = Convert.ToChar(ReadLine());
                if (initial == 'D' || initial == 'd')
                {
                    WriteLine("Enter the amount of sales, or Z to end.");
                    danielle = danielle + Convert.ToDouble(ReadLine());
                }
                else if (initial == 'E' || initial == 'e')
                {
                    WriteLine("Enter the amount of sales, or Z to end.");
                    edward = edward + Convert.ToDouble(ReadLine());
                }
                else if (initial == 'F' || initial == 'f')
                {
                    WriteLine("Enter the amount of sales, or Z to end.");
                    francis = francis + Convert.ToDouble(ReadLine());
                }
                else if (initial != 'D' || initial != 'd' || initial != 'E' || initial != 'e' || initial != 'F' || initial != 'f' || initial != 'Z' || initial != 'z')
                {
                    WriteLine("Initial Not recognized, or Z inputed. Ending Program.");
                }
            } while (initial != 'z' && initial != 'Z');


            total = edward + francis + danielle;
            WriteLine("Edward sold ${0} worth of houses.", edward);
            WriteLine("Francis sold ${0} worth of houses.", francis);
            WriteLine("Danielle sold ${0} worth of houses.", danielle);
            WriteLine("${0} worth of houses were sold in total.", total);

            if (edward > danielle && edward > francis)
            {
                WriteLine("Edward sold the most, ${0} worth of housing.", edward);
            }
            else if (francis > danielle && francis > edward)
            {
                WriteLine("Francis sold the most, ${0} worth of housing.", francis);
            }
            else
            {
                WriteLine("Danielle sold the most, ${0} worth of housing.", edward);
            }

        }
    }
}
