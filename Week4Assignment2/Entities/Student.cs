using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Assignment2.Entities
{
    public class Student : Human
    {
        // Constructor, also invokes base class constructor via `:base()` statement
        public Student(string firstName, string lastName, string mark)
           : base(firstName, lastName)
        {
            this.mark = mark;
        }

        // Properties & Encapsulated Fields
        string mark;
        public string Mark { get => mark; set=> mark = value; }

        // Overriden .ToString() Method
        public override string ToString()
        {
            return $"ObjectType:Human=>Student, FirstName:{FirstName}, LastName:{LastName}, Mark:{mark}";
        }
    }
}
