using SISwithDB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISwithDB.Models;
using SISwithDB.Exceptions;

namespace SISwithDB.Service
{
    internal class CourseService
    {
        private readonly CourseRepository courseRepository;

        public CourseService()
        {
            courseRepository = new CourseRepository();
        }

        public void AssignTeacherToCourse(Teacher teacher,Course course)
        {
            try
            {
                TeacherNotFoundException.TeacherNotFound(teacher);
                CourseNotFoundException.CourseNotFound(course);
                courseRepository.AssignTeacher(teacher, course);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetEnrollentByCourse(int course_id)
        {
            try
            {
                Course course = new Course();
                course.CourseId = course_id;
                CourseNotFoundException.CourseNotFound(course);
                courseRepository.GetEnrollments(course_id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void GetTeacherByCourse(string courseName)
        {
            try
            {
                Course course = new Course();
                course.CourseName = courseName;
                InvalidCourseDataexception.InvalidCourseData(course);
                courseRepository.GetTeacher(courseName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void DisplayCourse()
        {
            courseRepository.DisplayCourseInfo();
        }

        public void UpdateCourseDetails(Course course)
        {
            try
            {
                CourseNotFoundException.CourseNotFound(course);
                courseRepository.UpdateCourseInfo(course);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

       

        
    }
}
