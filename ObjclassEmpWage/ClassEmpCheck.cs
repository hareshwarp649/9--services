using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeObj
{
    internal class ClassEmpCheck
    {

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRate;
        private int numOfWorkingDay;
        private int maxHrsMonth;
        private int totalEmpWage;


        public ClassEmpCheck(string company, int empRate, int numOfWorkingDay, int maxHrsMonth)
        {
           this.company = company;
            this.empRate = empRate;
            this.numOfWorkingDay = numOfWorkingDay;
            this.maxHrsMonth = maxHrsMonth;
        }
       

        
        public void EmpClass()

        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= maxHrsMonth && totalWorkingDays < numOfWorkingDay)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(1, 2);
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

                Console.WriteLine("Day:" + totalWorkingDays + "Employee Hourse :" + empHrs);


            }
            int totalEmpWage = totalEmpHrs * this.empRate;
            Console.WriteLine("Total Emp Wage :" + company + "is:" +totalEmpWage);
        }
        public string toString()
        {
            return "Total Emp Wage for Company:" + this.company + "is" + this.totalEmpWage;
        }
    }
}
