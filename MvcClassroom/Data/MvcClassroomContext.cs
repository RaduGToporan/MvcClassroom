using Microsoft.EntityFrameworkCore;
using MvcClassroom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcClassroom.Data
{
    public class MvcClassroomContext : DbContext
    {
        public MvcClassroomContext(DbContextOptions<MvcClassroomContext> options)
            : base(options)
        {
        }

        public DbSet<Class> Classes { get; set; }
        //public object Class { get; internal set; }

        public DbSet<Assignment> Assignments { get; set; }
        //public object Class { get; internal set; }

        public DbSet<MvcClassroom.Models.Grade> Grade { get; set; }
    }
}
