using SIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Exceptions
{
    internal class InvalidStudentDataException:Exception
    {
        public InvalidStudentDataException(string message) : base(message)
        {

        }
        public static void InvalidStudentData(Student student)
        {
            if (student.DateOfBirth > DateOnly.FromDateTime(DateTime.Now))
            {
                throw new InvalidStudentDataException("Date of birth is not valid bro");
            }
            else if (!student.Email.Contains('@'))
            {
                throw new InvalidStudentDataException("email address is not valid(need @)");
            }
        }
    }
}
