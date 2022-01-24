using System;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Phani.SOLID.SingleResponsibilityPrinciple
{
    public class SRPBefore
    {
        public void GetProduct(string productName)
        {
            // 3 different responsibilities here
            if (productName is null)
            {
                throw new InvalidOperationException();
            }

            SqlConnection connection = new SqlConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("Select name from Product where name =" + productName);

            SmtpClient client = new SmtpClient("smtp.localhost.com");
            MailMessage message = new MailMessage("test@test.com", "tes1t@test.com", command.CommandText.ToString(), "Product Name");
            client.Send(message);
        }
    }
}
