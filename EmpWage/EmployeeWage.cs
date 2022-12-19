using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class EmployeeWage
    {
        public static void employeeWage()
        {
            //Attendace 
            int PRESENT = 1;

            Random random= new Random();
            int ATTENDANCE = random.Next(0,2);

            if(ATTENDANCE == PRESENT ) {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
