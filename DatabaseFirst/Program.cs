using System;
using System.Linq;

namespace DatabaseFirst
{
    class Program
    {
   
        static void Main()
        {
            var dbContext = new PlutoDbContext();
            var courses = dbContext.GetCourses().ToList();
            foreach (var course in courses)
            {
                Console.WriteLine(course.Title);
            }

            while (true)
            {
                
            }
        }
    }
}
