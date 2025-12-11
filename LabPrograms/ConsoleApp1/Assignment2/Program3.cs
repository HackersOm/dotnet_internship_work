using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program3
    {

        public static void Main1(String[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id = 1, Name ="OM",Dept="IT",Salary = 250000},
                new Employee{Id = 2, Name ="Swapnil",Dept="E&C",Salary = 25000},
                new Employee{Id = 3, Name ="Anurag",Dept="AIML",Salary = 20000},
                new Employee{Id = 4, Name ="Rohan",Dept="CSE",Salary = 2500},
                new Employee{Id = 5, Name ="Suresh",Dept="CIVIL",Salary = 50000}
            };

            var val = from emp in employees
                      where emp.Dept == "IT"
                      select emp;

            Console.WriteLine("Printing employee data which as IT Department :");
            foreach (Employee emp in val)
            {
                Console.WriteLine(emp);
            }

             Employee emp_max_sal = employees.Find(e => e.Salary == employees.Max(e => e.Salary));
            Console.WriteLine($"Employee with higher salary {emp_max_sal}");

            var group_val = from emp in employees
                  group emp by emp.Dept into emp_group
                  select emp_group.FirstOrDefault();

            foreach (var group in group_val)
            {
                Console.WriteLine("Count : "+group.Dept);
                //foreach (Employee emp in group_val)
                //{
                //    Console.WriteLine(emp);
                //}
            }
                  

        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public int Salary { get; set; }


        public override string ToString()
        {
            return $"Id : {Id} Name : {Name} Department :{Dept} Salary :{Salary}";
        }


    }
}
