using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2
{
    internal class TaskItem
    {
        [Key]
        public int TaskItemId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public bool IsCompleted { get; set; }
        public int StaffId { get; set; }

        public Staff Staff { get; set; }


        public static TaskItem Accept()
        {
            TaskItem item = new TaskItem();
            Console.WriteLine("Enter Task Title :");
            item.Title = Console.ReadLine();

            Console.WriteLine("Enter Task Description :");
            item.Description = Console.ReadLine();

            Console.WriteLine("Enter Task Description :");
            item.Description = Console.ReadLine();

            Console.WriteLine("Enter Task Status :");
            item.IsCompleted = bool.Parse(Console.ReadLine());

            return item;

        }
    }
}
