namespace ConsoleApp1
{

    class Student
    {
        int rollNo;
        string name;
        string course;

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setRollNo(int rollNo)
        {
            this.rollNo = rollNo;
        }

        public int getRollNo()
        {
            return this.rollNo;
        }

        public void setCourse(string course)
        {
            this.course = course;
        }

        public string getCourse()
        {
            return this.course;
        }


        public void AddData()
        {
            Console.WriteLine("Enter Student Info");
            Student st = new Student();

            Console.WriteLine("Enter student name :");
            st.setName(Console.ReadLine());
            Console.WriteLine("Enter student roll no :");
            st.setRollNo(int.Parse(Console.ReadLine()));

            Console.WriteLine("Enter student Course");
            st.setCourse(Console.ReadLine());
        }

        public void DisplayData()
        {
           
        }

      

    }
    internal class Program
    {
            static void Main(string[] args)
            {
            Console.WriteLine("Enter Student Info");
            Student st = new Student();

            Console.WriteLine("Enter student name :");
            st.setName(Console.ReadLine());
            Console.WriteLine("Enter student roll no :");
            st.setRollNo(int.Parse(Console.ReadLine()));

            Console.WriteLine("Enter student Course");
            st.setCourse(Console.ReadLine());


            Console.WriteLine("Entered Student Details");
            Console.WriteLine($"name of student is {st.getName()} with roll number {st.getRollNo()} and course entrolled {st.getCourse()}");

        }
    }
}
