using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISwithDB.Repositories;
using SISwithDB.Models;
using SISwithDB.Exceptions;

namespace SISwithDB.Service
{
    internal class PaymentService
    {
        private readonly PaymentRepository paymentRepository;
        public PaymentService()
        {
            paymentRepository = new PaymentRepository();
        }

        public void GetStudentByPayment(int paymentId)
        {
            paymentRepository.GetStudent(paymentId);
        }

        public void GetAmountByPayment(int paymentId)
        {
            paymentRepository.GetPaymentAmount(paymentId);
        }

        public void GetPaymentDateById(int paymentId)
        {
            paymentRepository.GetPaymentdate(paymentId);
        }

        public void PaymentMenu()
        {
            Payment payment = new Payment();
            int choice = 0;
            do
            {
                Console.WriteLine("Payment Management");
                Console.WriteLine("---------------------");
                Console.WriteLine($"1: Get student\n2: Get payment amount\n3. Get payment date\n4: Exit\n");
                Console.WriteLine("Enter your choice: ");
                choice= int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter payment id: ");
                        int payment_id = int.Parse(Console.ReadLine());
                        GetStudentByPayment(payment_id);
                        break;

                    case 2:
                        Console.WriteLine("Enter payment id: ");
                        int paymentid = int.Parse(Console.ReadLine());
                        GetAmountByPayment(paymentid);
                        break;

                    case 3:
                        Console.WriteLine("Enter payment id: ");
                        int paymentId = int.Parse(Console.ReadLine());
                        GetPaymentDateById(paymentId);
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
