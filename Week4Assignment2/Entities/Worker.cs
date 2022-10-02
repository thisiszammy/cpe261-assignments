using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Assignment2.Entities
{
    public class Worker : Human
    {
        // Constructor, also invokes base class constructor via `:base()` statement
        public Worker(string firstName, string lastName, double wage, double hoursWorked)
            : base(firstName, lastName)
        {
            this.wage = wage;
            this.hoursWorked = hoursWorked;
        }

        // Properties & Encapsulated Fields
        double wage;
        public double Wage { get => wage; set => wage = value; }
        double hoursWorked;
        public double HoursWorked { get => hoursWorked; set => hoursWorked = value; }

        // Calculates Hourly Rate based on total wage and total hours worked.
        public double CalculateHourlyWage()
        {
            return (wage/hoursWorked);
        }

        // Overriden .ToString() Method
        public override string ToString()
        {
            return $"ObjectType:Human=>Worker, FirstName:{FirstName}, LastName:{LastName}, " +
                $"Hours Worked:{hoursWorked.ToString("N2")} hours, " +
                $"Wage:PHP{wage.ToString("N2")}, Hourly Rate:PHP{CalculateHourlyWage().ToString("N2")}/hr";
        }
    }
}
