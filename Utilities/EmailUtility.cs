using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessor.Utilities
{
    public class EmailUtility : IEmailUtility
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Email Sent successfully with message {message}");
        }
    }
}
