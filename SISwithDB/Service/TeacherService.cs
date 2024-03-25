﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISwithDB.Repositories;
using SISwithDB.Models;
using SISwithDB.Exceptions;

namespace SISwithDB.Service
{
    internal class TeacherService
    {
        private readonly TeacherRepository _teacherRepository;

        public TeacherService()
        {
            _teacherRepository = new TeacherRepository();
        }

        public void DisplayTeacherRecords()
        {
            _teacherRepository.displayTeacherInfo();
        }

        public void UpdateTeacherRecords(Teacher teacher)
        {
            _teacherRepository.UpdateTeacherInfo(teacher);
        }

        public void GetAssignedCoursesByTeacher(int teacherId)
        {
            _teacherRepository.GetAssignedCourses(teacherId);
        }

        public void TeacherMenu()
        {
            Teacher teacher = new Teacher();
            int choice = 0;
            do
            {
                Console.WriteLine("Teacher Management");
                Console.WriteLine("---------------------");
                Console.WriteLine($"1: Update teacher details\n2: Get Assigned Course\n3: Display Teacher info\n4: Exit\n");
                Console.WriteLine("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                            Console.WriteLine("Enter teacher id: ");
                            int u_tid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter first name: ");
                            string u_fname = Console.ReadLine();
                            Console.WriteLine("Enter last name: ");
                            string u_lname = Console.ReadLine();
                            Console.WriteLine("Enter email: ");
                            string u_email = Console.ReadLine();
                            Teacher teacher1 = new Teacher(u_tid, u_fname, u_lname, u_email);
                            UpdateTeacherRecords(teacher1);
                            break;

                    case 2:
                        Console.WriteLine("Enter teacher id: ");
                        int teacherId = int.Parse(Console.ReadLine());
                        GetAssignedCoursesByTeacher(teacherId);
                        break;

                    case 3:
                        Console.WriteLine("Teacher details: ");
                        DisplayTeacherRecords();
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Try again!!!");
                        break;
                }
            } while (choice != 4);
        }
    }
}
