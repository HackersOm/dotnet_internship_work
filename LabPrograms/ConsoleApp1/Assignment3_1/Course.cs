using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assignment3_1
{
    internal class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

        internal  static Course Accept(int s_id = 0)
        {
            Course c = new Course();
            Console.WriteLine("Enter courses Name :");
            c.CourseName = Console.ReadLine();
            if(s_id == 0)
            {
            Console.WriteLine("Enter Student Id :");
            c.StudentId = int.Parse(Console.ReadLine());

            }
            c.StudentId = s_id; 
            return c;
        }

        public override string ToString()
        {
            return $" Course Id :{CourseId} Course Name :{CourseName}";
        }

    }
}
