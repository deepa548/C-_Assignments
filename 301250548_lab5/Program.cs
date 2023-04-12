using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301250548_lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Menu();
                Console.WriteLine("Enter a valid value from the Menu:");
                choice = Console.ReadLine();
                switch (choice)
                {

                    case "A": OptionA();
                        break;

                    case "B": OptionB();
                       break;

                    case "X":
                        Console.WriteLine("End of Program!");
                        break;

                    default:
                        Console.WriteLine("Invalid Input!");
                        break;
                }

            }
            while (choice!= "X");

        }

        static void Menu()
        {
            Console.WriteLine("A-Convert Pound to Kilograms");
            Console.WriteLine("B-Convert Miles to Kilometers");
            Console.WriteLine("X-Exit the Application");
        }

        static void OptionA()
        {
            Console.WriteLine("POUNDS     KILOGRAMS");
            Console.WriteLine("--------------------");
            for (double pounds = 200; pounds >= 50; pounds -= 5)
            {
                double kilograms;
                kilograms = PoundsToKilograms(pounds);
                Console.WriteLine($"{pounds,6}   {kilograms,9:N1}");
            }
        }

        static double PoundsToKilograms(double pounds)
        {   
            double kilograms = pounds * 0.453592;
            return kilograms;
        }

        static void OptionB()
        {
            Console.WriteLine("MILES     KILOMETERS");
            Console.WriteLine("--------------------");
            for (double miles = 10; miles <=100; miles+=10)
            {
                double kilometers;
                MilesToKilometers(miles, out kilometers);
                Console.WriteLine($"{miles, 5}     {kilometers, 10:N1}");
            }
           
        }

        static void  MilesToKilometers (double miles, out double kilometers)
         {
            kilometers = miles * 1.609344;
         }

    }
    
}
