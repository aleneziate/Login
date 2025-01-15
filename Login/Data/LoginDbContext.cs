using Login.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Login.Data
{
    public class LoginDbContext : DbContext
    {
        public LoginDbContext(DbContextOptions<LoginDbContext> options) : base(options)
        {

        }

            public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }
    
    }
    }





    

