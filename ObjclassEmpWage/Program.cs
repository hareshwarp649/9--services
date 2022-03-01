using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeObj
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ClassEmpPre ravi = new ClassEmpPre(2);
            //ravi.CheckEmp();


            //EmpHourClass rem = new EmpHourClass(2, 3);
            //rem.EmployeeDaily();





            ClassEmpCheck mahindra = new ClassEmpCheck("Mahindra", 20, 2, 10);
            ClassEmpCheck Jagauar = new ClassEmpCheck("Jagauar", 10, 4, 20);

            mahindra.EmpClass();
            Console.WriteLine(mahindra.toString());
            Jagauar.EmpClass();
            Console.WriteLine(Jagauar.toString());
        }
    }
}
