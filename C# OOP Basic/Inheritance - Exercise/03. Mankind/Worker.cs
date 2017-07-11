using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Worker : Human
{
    private decimal weeklySalary;
    private decimal hoursPerDay;

    public Worker(string firstName, string lastName, decimal weeklySalary, decimal hoursPerDay)
        : base(firstName, lastName)
    {
        this.WeeklySalary = weeklySalary;
        this.HoursPerDay = hoursPerDay;
    }
    public decimal HoursPerDay
    {
        get { return this.hoursPerDay; }
        set
        {
            if (value<1 || value>12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            this.hoursPerDay = value;
        }
    }

    public decimal WeeklySalary
    {
        get { return this.weeklySalary; }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.weeklySalary = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + $"{Environment.NewLine}" +
            $"Week Salary: {this.weeklySalary:f2}{Environment.NewLine}" +
            $"Hours per day: {this.hoursPerDay:f2}{Environment.NewLine}" +
            $"Salary per hour: {(this.weeklySalary/(this.hoursPerDay*5)):f2}";
    }
}
