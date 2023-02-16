using System.ComponentModel.Design;

namespace EmployeeWages
{
    internal class Program
    {
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;
        const int EMP_RATE_PER_HOUR = 20;
        const int NUM_OF_WORKING_DAY = 20;
        const int MAX_HRS_PER_MONTH = 10;
        static void Main(string[] args)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDay = 0;
            while(totalEmpHrs <= MAX_HRS_PER_MONTH && totalWorkingDay < NUM_OF_WORKING_DAY )
            {
                totalWorkingDay++;
                Random random = new Random();

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
                Console.WriteLine("Days:" +totalWorkingDay + " emp Hrs:" +empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("total emp wages:" + totalEmpWage);
        }
        
    }
}