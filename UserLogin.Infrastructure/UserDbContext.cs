using System;
using System.Collections.Generic;
using System.Data.Entity;
using UserLogin.Core.Model;

namespace UserLogin.Infrastructure
{
    public class UserContext : DbContext
    {
        public UserContext() : base("Users")
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
