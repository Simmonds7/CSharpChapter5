using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MessinWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i <= 9)
            {
                WriteLine(i);
                i++;
            }

            while (i >= 0)
            {
                WriteLine(i);
                i--;
            }
            do
            {
                WriteLine(i);
                i++;
            } while (i <= 9);
            do
            {
                WriteLine(i);
                i++;
            } while (i >= 0);
            for (int j = 0; j <= 9; ++j)
            {
                WriteLine(j);
            }
        }
    }
}
