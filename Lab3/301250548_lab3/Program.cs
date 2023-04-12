using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301250548_lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] daysOfTheWeek = { "Mon", "Tue", "Wed","Thu", "Fri","Sat","Sun"};
            
            for (int indexDays = 0; indexDays < daysOfTheWeek.Length; indexDays++)
            {
                Console.WriteLine("");
                Console.WriteLine(daysOfTheWeek[indexDays]);
               

                for (int hourOfDay = 1; hourOfDay <=24; hourOfDay++)
                {
                    string peak;

                    if (indexDays == 5 || indexDays == 6)
                    {
                       peak= "Off-peak";
                    }
                    else
                    {
                        if (hourOfDay >=7 && hourOfDay < 11 || hourOfDay >= 17 && hourOfDay < 19)
                        {
                            peak= "Mid-peak";
                        }
                        else if (hourOfDay >= 11 && hourOfDay < 17)
                        {
                            peak= "On-peak";
                        }
                        else
                        {
                            peak = "Off-peak";
                        }
                    }
                    if (hourOfDay>12 && hourOfDay!=24)
                    {
                        Console.WriteLine($"{hourOfDay-12}pm :{peak}");
                    }
                    
                    else if (hourOfDay==12)
                    {
                        Console.WriteLine($"{hourOfDay}pm :{peak}");
                    }
                    else if (hourOfDay == 24)
                    {
                        Console.WriteLine($"{hourOfDay-12}am :{peak}");
                    }
                    else
                    {
                        Console.WriteLine($"{hourOfDay}am :{peak}");
                    }
                    Console.WriteLine("");
                }               
            }     

        }
    }
}
