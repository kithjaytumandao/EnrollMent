﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnrollMent.Models
{
    public class EnrollDBContext:DbContext
    {
        public EnrollDBContext(DbContextOptions<EnrollDBContext>options):base(options)
        {
           
    }
        public DbSet<Student> Students { get; set; }

    }
}
