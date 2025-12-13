using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace Assignment3_1
{
    internal class Program
    {
        static sbConotext sb = new sbConotext();
        static void Main(string[] args)
        {
            GetAllStudentWithCourses();
            menu();
        }



        public static void menu()
        {
            int val = 0;
            do
            {
                Console.WriteLine("1. Add Student \n2. Add Course (assign to Student) \n3. View all Students with Courses \n4. Update Course Name \n5. Delete Course \n6. Exit");
                Console.Write("Enter your choice");
                val = int.Parse(Console.ReadLine());

                switch(val){
                    case 1:
                        Console.WriteLine("Row Affected :"+ AddStudent());
                        
                        break;
                    case 2:
                        Console.WriteLine("Row Affected :"+AddCourse());
                        break;
                    case 3:
                        GetAllStudentWithCourses();
                        break;
                    case 4:
                        UpdateCourseName();
                        break;
                    case 5:
                        DeleteCourse();
                        break;
                    case 6:
                        val = -1;
                        break;
                    default:
                        Console.WriteLine("Wrong Value");
                        break;
                }
            } while (val > 0);
        }

        private static void DeleteCourse()
        {

            Console.WriteLine();
            Console.Write("Enter Student Id :");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter Course name To Delete :");
            string dle_course = Console.ReadLine();
            if (FindStudent(id) != null)
            {
                Student s = FindStudent(id);

                foreach (Course course in s.Courses)
                {
                    if (course.CourseName == dle_course)
                    {
                        s.Courses.Remove(course);
                        break;
                    }
                }
                sb.SaveChanges();   
            }
        }

        private static void UpdateCourseName()
        {
            Console.WriteLine();
            Console.Write("Enter Student Id :");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter Course name To Update :");
            string to_update = Console.ReadLine();
            Console.Write("Enter Course new name  :");
            string name = Console.ReadLine();
            if (FindStudent(id) != null)
            {
                Student s = FindStudent(id);

                foreach (Course course in s.Courses)
                {
                    if (course.CourseName == to_update)
                    {
                        course.CourseName = name;
                        Console.WriteLine("Updated Successfull ");
                        break;
                    }
                }
                sb.SaveChanges();
            }
        }

        private static int AddCourse()
        {
            Console.WriteLine("Enter student Id : ");
            int id = int.Parse(Console.ReadLine());
            Student s = FindStudent(id);
            if(s != null)
            {

                Course c = Course.Accept(id);
                sb.Courses.Add(c);
                return sb.SaveChanges();
            }
            else
            {
                Console.WriteLine("Student not present !!!");
                return -1;
            }
        }



        private static int AddStudent()
        {

            Student s = new Student();
            Console.WriteLine("Enter Student Details: ");
            s.Accept();
            sb.Students.Add(s);
            return sb.SaveChanges();
        }

        public static void GetAllStudentWithCourses()
        {
            var s = sb.Students.Include(s=>s.Courses).ToList();
            foreach (var student in s)
            {
                Console.WriteLine(student);
                Console.WriteLine("courses Enroll : ");
                foreach(Course c in student.Courses)
                {
                    Console.WriteLine(c);
                }
                Console.WriteLine();
            }
        }



        public static Student FindStudent(int id)
        {
           return  sb.Students.Find(id);
        }

        public static Course FindCourse(int id)
        {

            return sb.Courses.Find(id);


        }
    }
}
