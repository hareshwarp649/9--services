using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeObj
{
    internal class EmpHourClass
    {
        public int IS_FULL_TIME = 1;
        public int IS_PART_TIME = 2;

        public EmpHourClass(int a, int d)
        {
            IS_FULL_TIME = d;
            IS_PART_TIME = a;
        }



        public void EmployeeDaily()
        {

            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage :" + empWage);

        }
    }
}
