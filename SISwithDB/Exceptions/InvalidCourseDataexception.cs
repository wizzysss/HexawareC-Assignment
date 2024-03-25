using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISwithDB.Models;

namespace SISwithDB.Exceptions
{
    internal class InvalidCourseDataexception:Exception
    {
        public InvalidCourseDataexception(string message):base(message)
        {
            
        }

        public static void InvalidCourseData(Course course)
        {
            if(string.IsNullOrWhiteSpace(course.CourseName)) 
            {
                throw new InvalidCourseDataexception("Invalid course name!!");
            }
        }
    }
}
