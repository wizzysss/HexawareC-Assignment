﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Models
{
    internal class Payment
    {

        public int PaymentID { get; set; }
        public int StudentID { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }


        public Payment()
        {

        }

        public Payment(int paymentID, int studentID, decimal amount, DateTime paymentDate)
        {
            PaymentID = paymentID;
            StudentID = studentID;
            Amount = amount;
            PaymentDate = paymentDate;
        }
        
    }
}
