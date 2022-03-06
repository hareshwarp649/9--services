using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeObj
{


    public class ClassEmpPre
    {
        public int IS_FULL_TIME;

        public ClassEmpPre(int a)
        {
            IS_FULL_TIME =a ;
        }

       
        
        public void CheckEmp()
        {
            IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else

                Console.WriteLine("Employee is Absent");

        }




    }
}    


