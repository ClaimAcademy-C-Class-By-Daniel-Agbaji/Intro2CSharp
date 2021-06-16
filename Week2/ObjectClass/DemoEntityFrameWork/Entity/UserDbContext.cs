using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DemoEntityFrameWork.Entity
{
    public class UserDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=User;"
                + "Trusted_Connection=True;"));
        }
    }
}
