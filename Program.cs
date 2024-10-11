using System.IO;
using static System.Reflection.Metadata.BlobBuilder;

namespace OOP_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("a001", "stefan", "male", 28000);
            Employee employee2 = new Employee("b001", "markus", "male", 20000);
            Employee employee3 = new Employee("c001", "oliver", "male", 31000);
            Employee employee4 = new Employee("d001", "sara", "female", 25000);
            Employee employee5 = new Employee("e001", "camilla", "female", 30000);

            Stack<Employee> EmployeeStack = new Stack<Employee>();

            EmployeeStack.Push(employee);
            EmployeeStack.Push(employee2);
            EmployeeStack.Push(employee3);
            EmployeeStack.Push(employee4);
            EmployeeStack.Push(employee5);

            //writes every object in stack to console. second line to show we dont remove anything from stack
            Console.WriteLine("Hämtar alla värden");
            foreach (var item in EmployeeStack)
            {    
                Console.WriteLine(item);
                Console.WriteLine($"Det finns {EmployeeStack.Count} kvar i stacken");
            }

            //create 1 array to store employee info that way we have the option to use a loop or other logic to push all objects back into the stack
            Console.WriteLine();
            Employee[] array = [employee, employee2, employee3, employee4, employee5];

            //we use the array length for the .Pop loop becouse the count of the stack will decrease with every Pop
            Console.WriteLine("Hämtar alla värden med Pop");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(EmployeeStack.Pop());
                Console.WriteLine($"Det finns {EmployeeStack.Count} kvar i stacken");
            }
            Console.WriteLine();
            EmployeeStack.Push(employee);
            EmployeeStack.Push(employee2);
            EmployeeStack.Push(employee3);
            EmployeeStack.Push(employee4);
            EmployeeStack.Push(employee5);

            Console.WriteLine("Hämtar 2 värden med peek");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(EmployeeStack.Peek());
                Console.WriteLine($"Det finns {EmployeeStack.Count} kvar i stacken");
            }
            Console.WriteLine("\nLetar efter employee 3");
            if (EmployeeStack.Contains(employee3))
                Console.WriteLine("Employee 3 is in stack");



            //del 2

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(employee);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            employeeList.Add(employee4);
            employeeList.Add(employee5);

            //searches for element employee2 in list
            Console.WriteLine("\nFinns employee 2 i listan?");
            if (employeeList.Contains(employee2))
                Console.WriteLine("Employee 2 finns i listan");
            else 
                Console.WriteLine("Employee 2 finns inte i listan");

            //uses contain to search for first element containing "male" in Gender property
            //we can also use the == operator instead of Contains to get the exact match
            Console.WriteLine();
            Console.WriteLine("letar efter första element med värde: male ");
            Console.WriteLine(employeeList.Find(x => x.Gender.Contains("male")));

            
            //searches for all objects where Gender contains "male" and adds it to a new list
            Console.WriteLine();
            Console.WriteLine("letar efter alla element med värde: male");
            List<Employee> results = employeeList.FindAll(x => x.Gender == "male");

            // if list Count is higer then 0 print out results 
            if (results.Count != 0)
                foreach (var item in results)
                    Console.WriteLine(item);
        }
    }
}
