using System;
using System.Collections.Generic;
using System.Text;

namespace Empattendance 
{
    public class UC5_Monthlywage 

    {   // UC5 Empwage

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public static void Main(string[] args) 
        {    
            //Variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            Random random = new Random();
            //Computation
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)

            {
                
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage of day : " + (day + 1) + " is : " + empWage);
            }
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }
    }
}