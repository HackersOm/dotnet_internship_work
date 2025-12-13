using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2
{
    internal class sbContext:DbContext
    {
        DbSet<Manager> Managers {  get; set; }
        DbSet<Staff> Staffs { get; set; }
        DbSet<TaskItem> TaskItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=Assignment3_2Db;Trusted_Connection=True;");
        }

    }
}
