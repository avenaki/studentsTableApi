using Microsoft.EntityFrameworkCore;
using StudentTableAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTableAPI.Context
{ 
    public class EFContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public EFContext(DbContextOptions options) : base(options) {
            Database.EnsureCreated();
        }
    }
}
