using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301250548Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            int initialPriceOfMachine = 28000;
            int endOfYearValue = 28000;
            int numOfYears = 1;
            int accumulatedDepreciation = 4000;
            accumulatedDepreciation = (numOfYears * 4000);
            endOfYearValue = initialPriceOfMachine - accumulatedDepreciation;

            Console.WriteLine("The depreciation table is as follows:");
            Console.WriteLine("");
            Console.WriteLine("                         END-OF-             ACCUMULATED  ");
            Console.WriteLine("YEAR     DEPRECIATION    YEAR-VALUE          DEPRECIATION ");
            Console.WriteLine("----     ------------    ----------          ------------ ");
            do
            {
                Console.WriteLine($"{numOfYears,0}       4000        {endOfYearValue,10}      {accumulatedDepreciation,15}");
                numOfYears++;
                accumulatedDepreciation = (numOfYears * 4000);
                endOfYearValue = initialPriceOfMachine - accumulatedDepreciation;

            }
            while (numOfYears <= 7);
        }
    }
}
