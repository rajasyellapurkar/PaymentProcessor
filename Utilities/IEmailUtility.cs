using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessor.Utilities
{
    public interface IEmailUtility
    {
        void SendEmail(string message);
    }
}
