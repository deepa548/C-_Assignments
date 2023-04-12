using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301250548_assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercise 1
            Console.WriteLine("Exercise 1: Display Menu");
            DisplayMenu();
            Console.WriteLine();

            //exercise 2
            Console.WriteLine(" ");
            Console.WriteLine("Exercise 2 : Terminate on 0, other values produce Error");
            string CalNum;
            do
            {
                Console.WriteLine(" ");
                DisplayMenu();

                CalNum = Console.ReadLine();
                switch (CalNum)
                {
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }


            } while (CalNum != "0");

            //exercise 3
            Console.WriteLine(" ");
            Console.WriteLine("Exercise 3: Choice 3 Will produce Sum of 5 Inputs, other choices returns Error, 0 to Exit");
            do
            {
                Console.WriteLine(" ");
                DisplayMenu();

                CalNum = Console.ReadLine();
                switch (CalNum)
                {
                    case "3":
                        int sum = CalculateSum(5);
                        Console.WriteLine($"The sum of numbers is {sum}");
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }


            } while (CalNum != "0");

            //exercise 4
            Console.WriteLine(" ");
            Console.WriteLine("Exercise 4: Choice 3 & 4 Will return output, 5 will return Error, 0 to Exit");
            do
            {
                Console.WriteLine(" ");
                DisplayMenu();
                CalNum = Console.ReadLine();
                
                switch (CalNum)
                {
                    case "3":
                        int sum = CalculateSum(5);
                        Console.WriteLine($"The sum of numbers is {sum}");
                        break;
                    case "4":
                        int numOfInput2;
                        Console.WriteLine("Enter the number of inputs you would like to work with: ");
                         numOfInput2 = Convert.ToInt32(Console.ReadLine());

                        int sumOfSquares = CalculateSumOfSquares(numOfInput2);
                        Console.WriteLine($"The sum of squares of numbers is {sumOfSquares}");
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }


            } while (CalNum != "0");

            //exercise 5
            Console.WriteLine(" ");
            Console.WriteLine("Exercise 5: All choices will return output, 0 to Exit");
            do
            {
                Console.WriteLine(" ");
                DisplayMenu();

                CalNum = Console.ReadLine();
                switch (CalNum)
                {
                    case "3":
                        int sum = CalculateSum(5);
                        Console.WriteLine($"The sum of numbers is {sum}");
                        break;
                    case "4":
                        int numOfInput2;
                        Console.WriteLine("Enter the number of inputs you would like to work with: ");
                        numOfInput2 = Convert.ToInt32(Console.ReadLine());
                        int sumOfSquares = CalculateSumOfSquares(numOfInput2);
                        Console.WriteLine($"The sum of squares of numbers is {sumOfSquares}");
                        break;
                    case "5":
                        int sumOfCubes = CalculateSumOfCubes();
                        Console.WriteLine($"The sum of numbers is {sumOfCubes}");
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }

            } while (CalNum != "0");

        }

        static void DisplayMenu()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Calculation Menu");
            Console.WriteLine("3) Calculate Sum");
            Console.WriteLine("4) Calculate Sum of Squares");
            Console.WriteLine("5) Calculate Sum of Cubes");
            Console.WriteLine("0) To Exit");
            Console.WriteLine(" ");
            Console.Write("Enter a number that corresponds to your choice: ");
        }

        static int CalculateSum(int numOfInput1)
        {
            int sum = 0;
            for (int i= 1; i <= numOfInput1; i++)
            {
                Console.WriteLine($"Enter your #{i} input to calculate the sum: ");
                int inputNumber1 = Convert.ToInt32(Console.ReadLine());
                sum += inputNumber1;
            }
            return sum;   
        }
       
        static int CalculateSumOfSquares(int numOfInput2)
        {
            int sumOfSquares =0;
            for (int i = 1; i <= numOfInput2; i++)
            {
                Console.WriteLine($"Enter your #{i} input to calculate the sum of squares: ");
                int inputNumber2 = Convert.ToInt32(Console.ReadLine());
                int sqOfInput2 = (inputNumber2) * (inputNumber2);
                sumOfSquares += sqOfInput2;
            }
            return sumOfSquares;
        }

        static int CalculateSumOfCubes()
        {
            int sumOfCubes = 0;

            int numOfInput3;
            Console.WriteLine("Enter the number of inputs you would like to work with: ");
            numOfInput3 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numOfInput3; i++)
            {
                Console.WriteLine($"Enter your #{i} input to calculate the sum of cubes: ");
                int inputNumber3 = Convert.ToInt32(Console.ReadLine());
                int cubeOfInput3 = (inputNumber3) * (inputNumber3) * (inputNumber3);
                sumOfCubes += cubeOfInput3;
            }
            return sumOfCubes;
        }

    }
}
