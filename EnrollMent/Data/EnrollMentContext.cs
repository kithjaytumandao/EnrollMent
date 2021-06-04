using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EnrollMent.Models;

namespace EnrollMent.Data
{
    public class EnrollMentContext : DbContext
    {
        public EnrollMentContext (DbContextOptions options): base(options)
        
        {
        }

        public DbSet<Student> Student { get; set; }
    }
}
