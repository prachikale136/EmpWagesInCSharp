using System.ComponentModel.Design;

namespace EmployeeWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            const int NUM_OF_WORKING_DAY = 20;
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            for (int days = 0; days < NUM_OF_WORKING_DAY; days++)
            {
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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Emp wage :" + empWage);

            }

            Console.WriteLine("total emp wages:" + totalEmpWage);
        }
        
    }
}