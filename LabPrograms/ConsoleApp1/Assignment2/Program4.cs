using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program4
    {
        public static void Main1(String[] args)
        {
            List<Student> slist = new List<Student>{
                new Student { Id = 1, Name ="Om"},
                new Student { Id = 2, Name ="Sai"},
                new Student { Id = 3, Name ="Sham"},
                new Student { Id = 4, Name ="Ram"}

            };

            List<Marks> marks = new List<Marks>()
            {
                new Marks{StudentId = 1,StudentSubject = "Java",Score = 90},
                new Marks{StudentId = 2,StudentSubject = "Java",Score = 60},
                new Marks{StudentId = 3,StudentSubject = "Java",Score = 40},
                new Marks{StudentId = 4,StudentSubject = "Java",Score = 80}
            };


            var query = from s in slist
                        join m in marks on s.Id equals m.StudentId
                        select new
                        {

                            s.Name,
                            m.StudentSubject,
                            m.Score

                        };

            foreach(var item in query)
            {
                Console.WriteLine($"Name : {item.Name}  Subject :{item.StudentSubject}  Score :{item.Score}");
            }


            String[] cities = { "Pune", "Karad", "Satara", "ichalkarangi", "Paris", "Singapore" };
            
            Console.WriteLine("\nThe cities Contains 'p' letter in it :");
            foreach(var c in cities)
            {
                if (c.ToLower().Contains("p"))
                {
                    Console.WriteLine(c);
                }
            }
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {

            return $"Student Id : {Id} Student Name : {Name} \n";
        }
    }
    class Marks
    {
        public int StudentId { get; set; }
        public string StudentSubject { get; set; }
        public int Score {  get; set; }


        public override string ToString()
        {
            return $" Id :{StudentId} Subject :{StudentSubject} Score : {Score} \n";
        }
    }

    
}
