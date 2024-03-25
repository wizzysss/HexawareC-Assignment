using SIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Repository
{
    internal class PaymentRepository
    {
        public static List<Payment> payments = new List<Payment>();

        public void InsertDetails(Payment payment)
        {
            payments.Add(payment);
        }

        public void GetStudent(int StudentId)
        {

            foreach (Student item in StudentRepository.stud)
            {
                if (item.StudentID == StudentId)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void GetPaymentAmount(int PaymentId)
        {
            foreach (Payment item in payments)
            {
                if (item.PaymentID == PaymentId)
                {
                    Console.WriteLine(item.Amount);
                }
            }
        }

        public void GetPaymentdate(int PaymentId)
        {
            foreach (Payment item in payments)
            {
                if (item.PaymentID == PaymentId)
                {
                    Console.WriteLine(item.PaymentDate);
                }
            }
        }

        public void displayDetails()
        {
            foreach (Payment item in payments)
            {
                Console.WriteLine(item);
            }
        }


    }
}
