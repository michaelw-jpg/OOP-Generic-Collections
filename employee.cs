using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Generic_Collections
{
   
    //class for Employees
    public class Employee
    {
        public string Id;
        public string Name;
        public string Gender;
        public int Salary;

        public Employee(string id, string name, string gender, int salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }
        //method to return info 
        public override string ToString()
        {
            return $"Namn: {Name}, ID: {Id}, Gender: {Gender}, Salary: {Salary}";
        }
    }
}
