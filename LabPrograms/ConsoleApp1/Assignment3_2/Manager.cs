using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2
{
    internal class Manager
    {
        [Key]
        public int ManagerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Staff> Staffs { get; set; }

        public static Manager Accept()
        {
            Manager manager = new Manager();
            Console.WriteLine("Enter Name :");
            manager.Name = Console.ReadLine();

            Console.WriteLine("Enter Email :");
            manager.Email = Console.ReadLine();

           return manager;

        }

    }
}
