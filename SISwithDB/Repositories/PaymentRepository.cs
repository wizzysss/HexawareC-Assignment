using System;
using System.Data.SqlClient;
using SISwithDB.Models;
using SISwithDB.Utility;

namespace SISwithDB.Repositories
{
    internal class PaymentRepository
    {
        SqlConnection connect = null;
        SqlCommand cmd = null;

        public PaymentRepository()
        {
            connect = new SqlConnection(DataConnectionUtility.GetConnectionString());
            cmd = new SqlCommand();
        }
        public void GetStudent(int paymentId)
        {
            cmd.CommandText = "Select * from PAYMENTS where payment_id=@p_id";
            cmd.Parameters.AddWithValue("@p_id", paymentId);
            connect.Open();
            cmd.Connection = connect;
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Payment payment = new Payment();
                payment.PaymentId = (int)reader["payment_id"];
                payment.StudentId = Convert.IsDBNull(reader["student_id"])?null:(int)reader["student_id"];
                payment.Amount = Convert.IsDBNull(reader["amount"])?null:(int)reader["amount"];
                payment.PaymentDate = (DateTime)reader["payment_date"];
                Console.WriteLine(payment);
            }
            connect.Close();
        }

        public void GetPaymentAmount(int paymentId)
        {
            cmd.CommandText = "Select amount from PAYMENTS where payment_id=@pid";
            cmd.Parameters.AddWithValue("@pid", paymentId);
            connect.Open();
            cmd.Connection = connect;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int amount = (int)reader["amount"];
                Console.WriteLine($"Amount : {amount}");
            }
            connect.Close();
        }

        public void GetPaymentdate(int paymentId)
        {
            cmd.CommandText = "Select payment_date from PAYMENTS where payment_id=@payment_id";
            cmd.Parameters.AddWithValue("@payment_id", paymentId);
            connect.Open();
            cmd.Connection = connect;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DateTime date = (DateTime)reader["payment_date"];
                Console.WriteLine($"Payment Date : {date}");
            }
            connect.Close();
        }

    }
}
