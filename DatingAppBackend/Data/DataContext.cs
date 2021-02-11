using DatingAppBackend.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppBackend.Data
{
    //we should derive from db context of entity framework
    public class DataContext:DbContext
    {
        //for database connections
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        //generating DBset for Users
        public DbSet<AppUser> Users { get; set; }
    }
}
