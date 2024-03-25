using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISwithDB.Models;
using SISwithDB.Repositories;
using SISwithDB.Exceptions;

namespace SISwithDB.Service
{
    internal class EnrollmentService
    {
        private readonly EnrollmentRepository enrollmentRepository;

        public EnrollmentService()
        {
           enrollmentRepository = new EnrollmentRepository();
        }

        public void GetStudentByEnrollment(int enrollmentId)
        {
            enrollmentRepository.GetStudentfromenroll(enrollmentId);
        }

        public void GetCourseByEnrollments(int enrollmentId)
        {
            enrollmentRepository.GetCourse(enrollmentId);
        }

        
    }
}
