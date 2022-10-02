using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Assignment2.Entities
{
    public class Human
    {
        // Constructor
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        
        // Properties & Encapsulated Fields
        string firstName;
        public string FirstName { get => firstName; set => firstName = value; }
        string lastName;
        public string LastName { get => lastName; set => lastName = value; }

        // Overriden .ToString() Method
        public override string ToString()
        {
            return $"ObjectType:Human, FirstName:{firstName}, LastName:{lastName}";
        }
    }
}
