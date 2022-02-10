using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester2_Exercise3.Exercises
{

//    1. Write a console-based application that prompts a user for an hourly pay rate.While the user
//enters values less than $5.65 or greater than $49.99, continue to prompt the user. Before the
//program ends, display the valid pay rate.
    //It seems that this question was already on the exercise 2, so I did pretty much the same thing

    public class Question1
    {
        public void HourlyPayRate()
        {
            //propmts the user the hourly rate expected
            Console.Write("Hello, please input your hourly rate between $5.65 and $49.99: ");
            double hourRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("----------------------------");

            //A loop i created to check if the hour rate is within the range already set, if its not
            // prompt the user to do it again
            while (hourRate < 5.65 || hourRate > 49.99)
            {

                Console.WriteLine($"${hourRate} is invalid! Please, try an hourly rate between $5.99 and $49.99");

                Console.Write("\nPlease enter valid rate here:");

                //what does VS suggests _
                _ = double.TryParse(Console.ReadLine(), out hourRate);

            }
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Your valid hourly rate is ${hourRate}.");

            Console.WriteLine("----------------------------");



        }
    }
}

