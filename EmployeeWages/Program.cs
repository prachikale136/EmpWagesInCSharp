namespace EmployeeWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            //int EMP_RATE_PER_HOUR = 20;
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee id present"); ;
            }
            else
            {
                Console.WriteLine("Employee is abscent");
            }
            /*empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp wage :" +empWage);*/
        }
    }
}