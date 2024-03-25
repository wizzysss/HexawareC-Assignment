using SIS.Models;
using SIS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Exceptions
{
    internal class TeacherNotFoundException : Exception
    {
        public TeacherNotFoundException(string message) : base(message)
        {

        }

        public static void TeacherNotFound(Teacher teacher)
        {
            if (!TeacherRepository.teachers.Contains(teacher))
            {
                throw new TeacherNotFoundException("Teacher not found!!");
            }
        }
    }
}
