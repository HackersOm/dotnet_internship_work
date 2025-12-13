
namespace Assignment3_2
{
    internal class Program
    {
        public static sbContext sb = new sbContext();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static void menu()
        {
            int val = 0;
            do
            {
                Console.WriteLine("\n\n1. Add Manager \n2. Add Staff (assign to Manager) \n3. Add Task (assign to Staff) \n4. View all Managers, Staff & Tasks \n5. Update Task (mark as completed) \n6.Delete Task \n7. Exit\n");
                Console.Write("Enter your choice : ");
                val = int.Parse(Console.ReadLine());
                switch (val)
                {
                    case 1:
                        AddManager();
                        break;
                    case 2:
                        AddStaff();
                        break;
                    case 3:
                        AddTask();
                        break;
                    case 4:
                        GetAll();
                        break;
                    case 5:
                        UpdateTask();
                        break;
                    case 6:
                        DeleteTask();
                        break;
                    case 7:
                        val = -1;
                        break;
                    default:
                        Console.WriteLine("Wrong Value");
                        break;
                }
            } while (val > 0);
        }

        private static void DeleteTask()
        {
            throw new NotImplementedException();
        }

        private static void UpdateTask()
        {
            throw new NotImplementedException();
        }

        private static void GetAll()
        {
            throw new NotImplementedException();
        }

        private static void AddTask()
        {
            throw new NotImplementedException();
        }

        private static void AddStaff()
        {
            throw new NotImplementedException();
        }

        private static void AddManager()
        {
           
        }
    }
}
