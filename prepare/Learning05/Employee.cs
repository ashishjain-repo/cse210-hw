using System;

namespace employee_demo;

public class Employee
{
    protected string _name;
    protected string _idNumber;

    public Employee()
    {
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetIdNumber()
    {
        return _idNumber;
    }

    public void SetIdNumber(string idNumber)
    {
        _idNumber = idNumber;
    }
}

public class SalaryEmployee : Employee
{
    private float _salary = 0;

    public float GetSalary()
    {
        return _salary;
    }

    public void SetSalary(float salary)
    {
        _salary = salary;
    }
}

public class HourlyEmployee : Employee
{
    private float _payRate = 0;
    private int _hoursWorked = 0;

    public float GetPayRate()
    {
        return _payRate;
    }

    public void SetPayRate(float payRate)
    {
        _payRate = payRate;
    }

    public int GetHoursWorked()
    {
        return _hoursWorked;
    }

    public void SetHourseWorked(int hoursWorked)
    {
        _hoursWorked = hoursWorked;
    }
}