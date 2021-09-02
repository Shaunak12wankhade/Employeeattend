using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empattendance
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants
            int IS_PRESENT = 1;

            //Predefined Random class for generating random values
            Random random = new Random();
            //Next method() 0-initial value,2-number of elements from 0
            int empcheck = random.Next(0, 2);
            //selection statement
            if (empcheck == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is Absent");
                Console.Read();
        }
    }
}
