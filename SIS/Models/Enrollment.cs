using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Models
{
    internal class Enrollment
    {

        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public DateOnly EnrollmentDate { get; set; }

        public Enrollment(int enrollmentID, int studentID, int courseID, DateOnly enrollmentDate)
        {
            EnrollmentID = enrollmentID;
            StudentID = studentID;
            CourseID = courseID;
            EnrollmentDate = enrollmentDate;
        }

        public Enrollment() { 
        
        }


        public override string ToString()
        {
            return $"{EnrollmentID} {StudentID} {CourseID} {EnrollmentDate} ";
        }
    }

}
