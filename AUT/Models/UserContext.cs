using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AUT.Models
{
    public class UserContext : DbContext
    {
        public UserContext() :
            base("Default")
        { }

        public DbSet<User> Users { get; set; }
    }
}