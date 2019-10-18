using SQL_LightCodeFirst.models;
using System;

namespace SQL_LightCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ClassContext())
            {
                //   db.Add(new Instructor { InstructorId = "A00948735", Name = "Phil Weier" });
                //     db.SaveChanges();
                Console.Read();

                foreach (Instructor instructor in db.Instructors)
                {
                    Console.WriteLine(instructor.InstructorId + ": " + instructor.Name);
                }

                Console.WriteLine("Hello World!");
            }
        }
    }
}