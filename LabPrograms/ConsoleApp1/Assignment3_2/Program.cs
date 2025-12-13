
using Microsoft.EntityFrameworkCore;

namespace Assignment3_2
{
    internal class Program
    {
        public static SbContext sb = new SbContext();
        static void Main(string[] args)
        {
            menu();
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

            Console.WriteLine("Enter Task Id :");
            int id = int.Parse(Console.ReadLine());
            if (Program.FindTaskById(id) != null)
            {
                TaskItem item = Program.FindTaskById(id);
                sb.TaskItems.Remove(item);
                Console.WriteLine("Deletion Successful !!!");

            }
            else
            {
                Console.WriteLine("Deletion Failed !!!");
            }
                sb.SaveChanges();

            }

        private static void UpdateTask()
        {

            Console.WriteLine("Enter Task Id :");
            int id = int.Parse(Console.ReadLine());
            if (Program.FindTaskById(id) != null)
            {
                TaskItem item = Program.FindTaskById(id);

                Console.WriteLine("Enter Updated Task Title :");
                item.Title = Console.ReadLine();

                Console.WriteLine("Enter Updated Task Description :");
                item.Description = Console.ReadLine();

                Console.WriteLine("Enter Updated Task Status :");
                item.IsCompleted = bool.Parse(Console.ReadLine());

            }
            sb.SaveChanges();
            }

        private static TaskItem FindTaskById(int id)
        {
            return sb.TaskItems.Find(id);
        }

        private static void GetAll()
        {
            List<Manager> mangers = sb.Managers.Include(m => m.Staffs).ThenInclude(s =>s.TaskItems).ToList();
            foreach (Manager m in mangers)
            {
                Console.WriteLine("Manager Name : "+m.Name);
                foreach(Staff s in m.Staffs)
                {
                    Console.WriteLine("Staff Name :"+s.Name);
                    List<TaskItem> items = s.TaskItems;
                    foreach(TaskItem item in items)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }

        private static void AddTask()
        {

            Console.WriteLine("Enter Staff Id :");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of Task to Add :");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {

                Console.WriteLine($"Enter {i + 1} Task info :");
                TaskItem item = TaskItem.Accept(id);
                if (item != null)
                {
                    sb.TaskItems.Add(item);
                }
                else
                {
                    Console.WriteLine("Insertaion Failed !!!");
                    return;
                }
                
            }
            
            sb.SaveChanges();
           
        }

        private static void AddStaff()
        {
            Console.WriteLine("Enter number of staff to Add :");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {

                Console.WriteLine($"Enter {i + 1} Staff info :");
                Staff staff = Staff.Accept();
                if (staff != null)
                {
                    sb.Staffs.Add(staff);
                    sb.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Insertaion Failed !!!");
                    return;
                }
            }
        }

        private static void AddManager()
        {
            Console.WriteLine("Enter Manager info :");
            Manager m = Manager.Accept();
            sb.Managers.Add(m);
            sb.SaveChanges();
        }

        internal static Manager FindManagerById(int val)
        {
           return sb.Managers.Find(val);
        }

        internal static Staff FindStaffById(int val)
        {
            return sb.Staffs.Find(val);
        }
    }
}
