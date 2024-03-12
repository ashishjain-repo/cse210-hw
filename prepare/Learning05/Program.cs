using System;

namespace employee_demo;
class Program
{
    static void Main(string[] args)
    {
        HourlyEmployee hEmployee = new HourlyEmployee();
        hEmployee.SetName("Jhon");
        hEmployee.SetIdNumber("123abc");
        hEmployee.SetPayRate(15);
        hEmployee.SetHourseWorked(35);

        SalaryEmployee sEmployee = new SalaryEmployee();
        sEmployee.SetName("Peter");
        sEmployee.SetIdNumber("456def");
        sEmployee.SetSalary(60000);
        
    }
}