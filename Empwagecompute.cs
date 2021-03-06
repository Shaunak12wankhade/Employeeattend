
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace Empattendance 
    {
        public class UC6_WageTillNumOfWorkingDays
        {
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;
            public const int EMP_RATE_PER_HOUR = 20;
            public const int NUM_OF_WORKING_DAYS = 20;
            public const int MAX_HRS_IN_MONTH = 100;
            public static void Main(string[] args)
            {
                //Variables
                int empHrs = 0;
                int totalEmpHrs = 0;
                int totalWorkingDays = 0;
                Random random = new Random();

            //Computation
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
                {
                    totalWorkingDays++;
                    
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
                    totalEmpHrs += empHrs;
                    Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hours : " + empHrs);
                }
                int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("Total Emp Wage : " + totalEmpWage);
            }
        }
    }