using PaymentProcessor.Interfaces;
using PaymentProcessor.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessor.Managers
{
    public class BasicMemberPaymentManager : IPaymentManager
    {
        IEmailUtility emailUtility;

        public BasicMemberPaymentManager(IEmailUtility emailUtility)
        {
            this.emailUtility = emailUtility;
        }

        public virtual void ProcessPayement()
        {
            ActivateMembership();
            SendEmail("Basic Membership activated");
        }

        protected void ActivateMembership()
        {
            // if not a member activate basic membership
            Console.WriteLine("Basic memebership updated");
        }

        protected void SendEmail(string message)
        {
            emailUtility.SendEmail(message);
        }
    }
}
