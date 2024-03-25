using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Models
{
    internal class Course
    {     

        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string InstructorName { get; set; }



        public Course()
        {

        }
        public Course(int courseID, string courseName, string courseCode, string instructorName)
        {
            CourseID = courseID;
            CourseName = courseName;
            CourseCode = courseCode;
            InstructorName = instructorName;
        }

        public override string ToString()
        {
            return $"ID: {CourseID}, Name: {CourseName},Code {CourseCode}, Instructor: {InstructorName}";
        }


    }
}
