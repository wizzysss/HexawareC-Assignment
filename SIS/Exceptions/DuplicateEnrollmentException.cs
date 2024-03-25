using SIS.Models;
using SIS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Exceptions
{
    internal class DuplicateEnrollmentException:Exception
    {
        public DuplicateEnrollmentException(string message) : base(message)
        {

        }

        public static void DuplicateEnrollment(int student_id)
        {
            foreach (Enrollment item in EnrollmentRepository.enrollments)
            {
                if (item.StudentID == student_id)
                    throw new DuplicateEnrollmentException("Student already enrolled. Try again!!!");
            }
        }
    }
}
