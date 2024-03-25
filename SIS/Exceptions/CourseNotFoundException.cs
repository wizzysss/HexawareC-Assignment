using SIS.Models;
using SIS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Exceptions
{
    internal class CourseNotFoundException:Exception
    {
        public CourseNotFoundException(string message) : base(message)
        {

        }

        public static void CourseNotFound(Course course)
        {
            if (!CourseRepository.courses.Contains(course))
            {
                throw new CourseNotFoundException("Course not found!!");
            }
        }
    }
}
