using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISwithDB.Models;
using SISwithDB.Repositories;

namespace SISwithDB.Exceptions
{
    internal class TeacherNotFoundException : Exception
    {
        public TeacherNotFoundException(string message):base(message)
        {
            
        }

        public static void TeacherNotFound(Teacher teacher)
        {
            TeacherRepository teacherRepository = new TeacherRepository();
            if (!teacherRepository.TeacherExists(teacher))
            {
                throw new TeacherNotFoundException("Teacher not found!!");
            }
        }
    }
}
