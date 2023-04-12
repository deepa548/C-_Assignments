using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_TicketPriceCal_301250548
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            double adultTicketCost = 3.75;
            double childTicketCost = 2.25;
            int adultTicketNumber;
            int childTicketNumber;

            Console.WriteLine(" ");
            Console.WriteLine("Welcome to the Ticket Counter!");
            Console.WriteLine(" ");
            Console.WriteLine($"The price of an adult ticket is: {adultTicketCost:C}.");
            Console.WriteLine($"The price of a child ticket is: {childTicketCost:C}.");
            Console.WriteLine(" ");
            Console.Write("Please enter the number of adult tickets you would like to buy: ");
            adultTicketNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the number of child tickets you would like to buy: ");
            childTicketNumber = Convert.ToInt32(Console.ReadLine());

            //PROCESSING

            int totalTickets;
            double totalAdultTicketCost;
            double totalChildTicketCost;
            double totalCost;



            totalTickets = adultTicketNumber + childTicketNumber;

            totalAdultTicketCost = (adultTicketCost * adultTicketNumber);

            totalChildTicketCost = (childTicketCost * childTicketNumber);

            totalCost = totalAdultTicketCost + totalChildTicketCost;

            //OUTPUT
            Console.WriteLine(" ");
            Console.WriteLine($"Date and Time: {DateTime.Now}");

            Console.WriteLine(" ");
            Console.WriteLine($"The total number of tickets are {totalTickets}.");
            Console.WriteLine(" ");


            Console.WriteLine($"Total Cost of Adult Tickets:          {totalAdultTicketCost,10:C}");
            Console.WriteLine($"Total Cost of Child Tickets:          {totalChildTicketCost,10:C}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Total Amount:                         {totalCost,10:C}");

            Console.WriteLine(" ");
            Console.WriteLine($"You pay {totalCost:C} for the tickets.Enjoy the Ride!");

            Console.WriteLine(" ");

        }
    }
}
