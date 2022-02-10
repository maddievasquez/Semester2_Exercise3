using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester2_Exercise3.Exercises
{
    public  class Question2
    {
        //2. Write a console-based application that sums the integers from 1 to 50
        public void IntegerNumberSum()
        {

            int num;
            int NumberSum = 0;
            for (num = 1; num <= 50; num++)
            {
                NumberSum = NumberSum + num;
            }
            Console.WriteLine($"The sum of number from 1 to 50 is = ${NumberSum}");
            Console.ReadLine();
        }
    }
}
  
