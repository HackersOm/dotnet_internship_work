using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assignment3_1
{
    internal class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string First_Name { get; set; } 
        public string Last_Name { get; set; }


        public List<Course> Courses { get; set; } = new List<Course>();

        public override string ToString()
        {

            return $"Student Id :{StudentId} FirstName :{First_Name} , LastName :{Last_Name}";
        }

        internal void Accept()
        {
            Console.WriteLine("Enter Student First Name :");
            this.First_Name = Console.ReadLine();
            Console.WriteLine("Enter Student Last Name");
            this.Last_Name = Console.ReadLine();
            //Console.WriteLine("Do Student Enroll for Courses (0 for No / count for number of Courses )");
            //int val = Convert.ToInt32(Console.ReadLine());

            //if (val > 0)
            //{
            //    List<Course> c = new List<Course>();
            //    for (int i = 0; i < val; i++)
            //    {
            //        c[i] = Course.Accept(this.StudentId);
            //    }
            //}


        }
    }
}
