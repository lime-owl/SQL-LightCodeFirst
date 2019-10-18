using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQL_LightCodeFirst.models
{
    public class ClassContext : DbContext
    {
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Class> Classes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=C:\\Users\\A01211467\\source\\repos\\SQL-LightCodeFirst\\SQL-LightCodeFirst\\classes.db");
    }
}