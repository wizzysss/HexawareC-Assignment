using SIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Repository
{
    internal class TeacherRepository
    {
        public static List<Teacher> teachers = new List<Teacher>();

        public void InsertDetails(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        public void displayDetails()
        {
            foreach (Teacher item in teachers)
            {
                Console.WriteLine(item);
            }
        }

        public void UpdateTeacherInfo(Teacher teacher)
        {
            foreach (Teacher item in teachers)
            {
                if (item.TeacherID == teacher.TeacherID)
                {
                    item.FirstName = teacher.FirstName;
                    item.LastName = teacher.LastName;
                    item.Email = teacher.Email;
                    break;
                }
            }
        }

        public void GetAssignedCourses(string t_name)
        {

            foreach (Course item in CourseRepository.courses)
            {
                if (item.InstructorName == t_name)
                {
                    Console.WriteLine(item.CourseName);
                }
            }
        }
    }
}
