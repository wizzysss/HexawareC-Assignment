using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISwithDB.Models;
using SISwithDB.Service;

namespace SISwithDB.StudentManagementApp
{
    internal class StudManagementSys
    {

        CourseService courseService;
        StudentService studentService;
        EnrollmentService enrollmentService;
        TeacherService teacherService;
        PaymentService paymentService;

        public StudManagementSys()
        {
            studentService = new StudentService();
            courseService = new CourseService();
            enrollmentService = new EnrollmentService();
            teacherService = new TeacherService();
            paymentService = new PaymentService();
        }

        public void CourseFunctionsMenu()
        {
            CourseService courseService = new CourseService();
            int option = 0;
            Course course = new Course();

            do
            {
                Console.WriteLine("Course Management");
                Console.WriteLine("....................");
                Console.WriteLine($"1: Update Course Records\t2: Get enrollments\n3: Get teacher\t4: Display course Records\n5: Assign Teacher\t6: Exit\n");
                Console.WriteLine("Enter your choice: ");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter course id: ");
                        int u_cid = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter course name: ");
                        string u_cname = Console.ReadLine();
                        Console.WriteLine("Enter course credits: ");
                        int u_credits = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter instructor id: ");
                        int u_instructorId = int.Parse(Console.ReadLine());
                        Course course1 = new Course(u_cid, u_cname, u_credits, u_instructorId);
                        courseService.UpdateCourseDetails(course1);
                        break;

                    case 2:
                        Console.WriteLine("Enter course id: ");
                        int course_id = int.Parse(Console.ReadLine());
                        courseService.GetEnrollentByCourse(course_id);
                        break;

                    case 3:
                        Console.WriteLine("Enter course name: ");
                        string course_name = Console.ReadLine();
                        courseService.GetTeacherByCourse(course_name);
                        break;

                    case 4:
                        Console.WriteLine("Course List: ");
                        courseService.DisplayCourse();
                        break;

                    case 5:
                        Console.WriteLine("Enter teacher id: ");
                        int tid = int.Parse(Console.ReadLine());
                        Teacher teachers = new Teacher() { TeacherId = tid };
                        Console.WriteLine("Enter course id: ");
                        int cid = int.Parse(Console.ReadLine());
                        Course course2 = new Course();
                        course2.CourseId = cid;
                        courseService.AssignTeacherToCourse(teachers, course2);
                        break;

                    case 6:
                        Console.WriteLine("Exiting..");
                        break;

                    default:
                        Console.WriteLine("Try again!!!");
                        break;
                }
            } while (option != 6);
        }
        public void EnrollmentFunctionMenu()
        {
            Enrollment enrollment = new Enrollment();
            EnrollmentService enrollmentService = new EnrollmentService();
            int option;
            do
            {
                Console.WriteLine("Enrollment Management");
                Console.WriteLine("---------------------");
                Console.WriteLine($"1: Get Student\t2: Get Course\n3: Exit\n");
                Console.WriteLine("Enter your choice: ");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter enrollment id: ");
                        int enrollmentId = int.Parse(Console.ReadLine());
                        enrollmentService.GetStudentByEnrollment(enrollmentId);
                        break;

                    case 2:
                        Console.WriteLine("Enter enrollment id: ");
                        int enrollment_Id = int.Parse(Console.ReadLine());
                        enrollmentService.GetCourseByEnrollments(enrollment_Id);
                        break;

                    case 3:
                        Console.WriteLine("Exiting..");
                        break;

                    default:
                        Console.WriteLine("Try again!!!");
                        break;
                }
            } while (option != 3);
        }
        public void MainMenu()
        {
            int option = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Main Menu");
                Console.WriteLine(".................");
                Console.WriteLine($"1:: Student\t2:: Course\n3:: Enrollment\t4:: Teacher\n5:: Payment\t6:: Exit\n");
                Console.WriteLine("Enter your choice: ");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        studentService.StudentMenu();
                        break;

                    case 2:
                        CourseFunctionsMenu();
                        break;

                    case 3:
                        EnrollmentFunctionMenu();
                        break;

                    case 4:
                        teacherService.TeacherMenu();
                        break;

                    case 5:
                        paymentService.PaymentMenu();
                        break;

                    case 6:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Try again...");
                        break;
                }
            } while (option != 6);
        }
    }
}
