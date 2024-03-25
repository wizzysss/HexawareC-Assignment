using SIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Exceptions
{
    internal class InvalidCourseDataException : Exception
    {
        public InvalidCourseDataException(string message) : base(message)
        {

        }

        public static void InvalidCourseData(Course course)
        {
            if (string.IsNullOrWhiteSpace(course.CourseCode))
            {
                throw new InvalidCourseDataException("Invalid course code!!");
            }
            else if (string.IsNullOrWhiteSpace(course.InstructorName))
            {
                throw new InvalidCourseDataException("Invalid instructor name!!");
            }
        }
    }
}
