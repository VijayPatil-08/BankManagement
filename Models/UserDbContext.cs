using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankManagmentSystem.Models
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions option): base(option)
        {

        }
       public DbSet<User> Users { get; set; }
    }
}
