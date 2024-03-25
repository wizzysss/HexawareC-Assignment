﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISwithDB.Models;
using SISwithDB.Utility;

namespace SISwithDB.Repositories
{
    internal class EnrollmentRepository
    {
        SqlConnection connect = null;
        SqlCommand cmd = null;
        public EnrollmentRepository()
        {
            connect = new SqlConnection(DataConnectionUtility.GetConnectionString());
            cmd = new SqlCommand();
        }
        public void GetStudentfromenroll(int enrollment_id)
        {
            cmd.CommandText = "Select student_id  from ENROLLMENTS where enrollment_id=@e_id";
            cmd.Parameters.AddWithValue("@e_id",enrollment_id);
            connect.Open();
            cmd.Connection = connect;
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int student_id = (int)reader["student_id"];
                Console.WriteLine($"Student enrolled: {student_id}");
            }
            connect.Close();
        }

        public void GetCourse(int enrollment_id)
        {
            cmd.CommandText = "Select course_id from ENROLLMENTS where enrollment_id=@e_id";
            cmd.Parameters.AddWithValue("@e_id", enrollment_id);
            connect.Open();
            cmd.Connection = connect;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int course_id = (int)reader["course_id"];
                Console.WriteLine($"Course: {course_id}");
            }
            connect.Close();
        }

        public bool DuplicateEnrollmentExists(Enrollment enrollment)
        {
            int count = 0;
            cmd.CommandText = "Select count(*) as total from ENROLLMENTS where student_id=@s_id and course_id=@c_id";
            cmd.Parameters.AddWithValue("@s_id", enrollment.StudentId);
            cmd.Parameters.AddWithValue("@c_id", enrollment.CourseId);
            connect.Open();
            cmd.Connection = connect;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                count = (int)reader["total"];
            }
            connect.Close();
            if (count > 1)
            {
                return true;
            }
            return false;
        }
    }
}
