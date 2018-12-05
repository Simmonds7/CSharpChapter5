using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OddNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCounter = 1;
            WriteLine("-Odd Numbers through 99-");
            do
            {
                
                WriteLine(numCounter);
                numCounter = numCounter + 2;
                WriteLine("--");
            } while (numCounter <= 99);
        }
    }
}
