using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Models
{


    internal class Student
    {

        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        

        //parameterized constructor

        public Student(int studentID, string firstName, string lastName, DateOnly dateOfBirth, string email, string phoneNumber)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
            PhoneNumber = phoneNumber;
            
        }

        //default constructor
        public Student()
        {

        }

        public override string ToString()
        {
           
            return $"ID: {StudentID}, Name: {FirstName} {LastName}, DOB: {DateOfBirth}, Email: {Email}, Phone: {PhoneNumber}";
        
    }

    }
}
