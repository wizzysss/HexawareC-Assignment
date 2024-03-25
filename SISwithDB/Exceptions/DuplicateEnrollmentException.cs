using SISwithDB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISwithDB.Models;

namespace SISwithDB.Exceptions
{
    internal class DuplicateEnrollmentException : Exception
    {
        public DuplicateEnrollmentException(string message): base (message)
        {
            
        }

        public static void DuplicateEnrollment(Enrollment enrollment)
        {
            EnrollmentRepository enrollmentRepository = new EnrollmentRepository();
            if(enrollmentRepository.DuplicateEnrollmentExists(enrollment))
            {
                throw new DuplicateEnrollmentException("The student has enrolled for the course already!!!");
            }
        }
    }
}
