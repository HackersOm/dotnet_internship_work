using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections;
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

        public override string ToString()
        {
              return $" Title : {Title} Description : {Description} Status :{IsCompleted}";
        }
        public static TaskItem Accept(int id=-1)
        {
            int val = 0;
            TaskItem item = new TaskItem();
            if (id < 0)
            {
                Console.WriteLine("Enter Staff Id :");
                val = int.Parse(Console.ReadLine());
            }
            val = id;
                if (Program.FindStaffById(val) != null)
                {
                    item.StaffId = val;
                }
                else
                {
                    Console.WriteLine("Manager Not Present !!!");
                    return null;
                }

            Console.WriteLine("Enter Task Title :");
            item.Title = Console.ReadLine();

            Console.WriteLine("Enter Task Description :");
            item.Description = Console.ReadLine();

            Console.WriteLine("Enter Task Status :");
            item.IsCompleted = bool.Parse(Console.ReadLine());
            return item;

        }
    }
}
