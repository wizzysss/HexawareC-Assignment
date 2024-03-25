using SIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Exceptions
{
    internal class InvalidEnrollmentDataException : Exception
    {
        public InvalidEnrollmentDataException(string message) : base(message)
        {

        }

        public static void InvalidEnrollmentData(Enrollment enrollment)
        {
            if (enrollment.StudentID == null)
            {
                throw new InvalidEnrollmentDataException("Student id missing");
            }
            else if (enrollment.CourseID == null)
            {
                throw new InvalidEnrollmentDataException("Course id missing");
            }
        }
    }
}
