using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2
{
    internal class Staff
    {
        [Key]
        public int StaffId { get; set; }
        public string Name { get; set; }
        
        public string Email { get; set; }
        public int ManagerId { get; set; }

        public Manager Manager { get; set; }

        public List<TaskItem> TaskItems { get; set; }

        public static Staff Accept()
        {
            Staff staff = new Staff();
            Console.WriteLine("Enter Name :");
            staff.Name = Console.ReadLine();

            Console.WriteLine("Enter Email :");
            staff.Email = Console.ReadLine();

            Console.WriteLine("Enter Manger Id ");
            int val = int.Parse(Console.ReadLine());
            if(Program.FindManagerById(val) != null){
                staff.ManagerId = val;
            }
            else
            {
                Console.WriteLine("Manager Not Present !!!");
                return null;
            }
            return staff;

        }
    }
}
