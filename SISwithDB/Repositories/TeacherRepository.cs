﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using SISwithDB.Models;
using SISwithDB.Utility;

namespace SISwithDB.Repositories
{
    internal class TeacherRepository
    {
        SqlConnection connect = null;
        SqlCommand cmd = null;

        public TeacherRepository()
        {
            connect =new SqlConnection(DataConnectionUtility.GetConnectionString());
            cmd = new SqlCommand();
        }
        public void displayTeacherInfo()
        {
            List<Teacher> teachers = new List<Teacher>();
            cmd.CommandText = "Select * from TEACHER";
            connect.Open();
            cmd.Connection = connect;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Teacher teacher = new Teacher();
                teacher.TeacherId = (int)reader["teacher_id"];
                teacher.FirstName = (string)reader["first_name"];
                teacher.LastName = (string)reader["last_name"];
                teacher.Email = (string)reader["email"];
                teachers.Add(teacher);
            }
            foreach(Teacher teacher in teachers)
            {
                Console.WriteLine(teacher);
            }
            connect.Close();
        }

        public void UpdateTeacherInfo(Teacher teacher)
        {
            cmd.CommandText = "Update TEACHER set first_name=@fname,last_name=@lname,email=@email where teacher_id=@t_id";
            cmd.Parameters.AddWithValue("@t_id", teacher.TeacherId);
            cmd.Parameters.AddWithValue("@fname", teacher.FirstName);
            cmd.Parameters.AddWithValue("@lname", teacher.LastName);
            cmd.Parameters.AddWithValue("@email", teacher.Email);
            connect.Open();
            cmd.Connection= connect;
            cmd.ExecuteNonQuery();
            connect.Close() ;
        }

        public void GetAssignedCourses(int teacherId)
        {
            List<Course> courses = new List<Course>();
            cmd.CommandText = "Select * from COURSES where teacher_id=@t_id";
            cmd.Parameters.AddWithValue("@t_id", teacherId);
            connect.Open();
            cmd.Connection = connect;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Course course = new Course();
                course.CourseId = (int)reader["course_id"];
                course.CourseName = (string)reader["course_name"];
                course.Credits = Convert.IsDBNull(reader["credits"])?null:(int)reader["credits"];
                course.InstructorId = Convert.IsDBNull(reader["teacher_id"])?null:(int)reader["teacher_id"];
                courses.Add(course);
            }
            foreach(Course course in courses)
            {
                Console.WriteLine(course);
            }
            connect.Close();
        }

        public bool TeacherExists(Teacher teacher)
        {
            int count = 0;
            cmd.CommandText = "Select count(*) as total from TEACHER where teacher_id=@t_id";
            cmd.Parameters.AddWithValue("@t_id", teacher.TeacherId);
            connect.Open();
            cmd.Connection = connect;
            SqlDataReader reader = cmd.ExecuteReader();
            connect.Close();
            while (reader.Read())
            {
                count = (int)reader["total"];
            }
            if (count > 0)
            {
                return true;
            }
            return false;
        }

    }
}
